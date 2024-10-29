using System;

namespace ATM_Emulator;
class Program
{
    static void Main(string[] args)
    {
    //    CardHolder cs = new CardHolder("Gabriel","Hill","1232");

        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");

        CheckDebitCard();

        Console.ReadLine();
    }

    static void CheckDebitCard()
    {
        string debitCardNum = "";
        CardHolder currentUser;

        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //Check against our db
                currentUser = UsersDB.users.FirstOrDefault(x => x.CardNum == debitCardNum);

                if(currentUser != null)
                    break;

                else
                {
                    Console.WriteLine("Card not recognized. Try again");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Card not recognized: {0}",ex.Message);
            }
        }

        CheckPinNo();
    }

    static void CheckPinNo()
    {
        string pinNo = "";
        CardHolder currentUser;

        Console.WriteLine("Next insert your pin");

        while(true)
        {
            try
            {

                pinNo = Console.ReadLine();
                //Check against our db
                currentUser = UsersDB.users.FirstOrDefault(x => x.Pin == pinNo);

                if(currentUser != null)
                {
                    Console.WriteLine("Welcome {0} :)",currentUser.FirstName);
                    PrintOptions(currentUser);
                    Console.WriteLine("Have a nice day, {0} :)",currentUser.FirstName);
                    break;
                }

                else
                {
                    Console.WriteLine("Incorrect pin. Try again");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Incorrect pin: {0}",ex.Message);
            }
        }

    }

    static void Print()
    {
        Console.WriteLine("Please choose from one of the following options...");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
    }


    static void PrintOptions(CardHolder user)
    {
        int option = 0;

        do
        {
            Print();
            option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1 :
                    user.Deposit();
                    break;
                case 2:
                    user.Withdraw();
                    break;
                case 3:
                    Console.WriteLine("Show balance: ${0}",user.Balance);
                    break;
            }

        }while(option != 4);
    }


}
