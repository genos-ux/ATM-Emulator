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

    static void PrintOptions()
    {
        Console.WriteLine("Please choose from one of the following options...");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Withdraw");
        Console.WriteLine("3. Show Balance");
        Console.WriteLine("4. Exit");
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
    }

    static void CheckPinNo()
    {
        string pinNo = "";
        CardHolder currentUser;

        while(true)
        {
            try
            {
                pinNo = Console.ReadLine();
                //Check against our db
                currentUser = UsersDB.users.FirstOrDefault(x => x.Pin == pinNo);

                if(currentUser != null)
                    break;

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


}
