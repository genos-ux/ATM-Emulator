using System;

namespace ATM_Emulator;
class Program
{
    static void Main(string[] args)
    {
    //    CardHolder cs = new CardHolder("Gabriel","Hill","1232");

        Console.WriteLine("Welcome to SimpleATM");
        Console.WriteLine("Please insert your debit card: ");

        string debitCardNum = "";
        CardHolder currentUser;

        while(true)
        {
            try
            {
                debitCardNum = Console.ReadLine();
                //Check against our db
                currentUser = UsersDB.users.FirstOrDefault(x => x.CardNum == debitCardNum);
            }
            catch()
            {

            }
        }

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


}
