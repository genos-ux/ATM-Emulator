using System;

namespace ATM_Emulator;
class Program
{
    static void Main(string[] args)
    {


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

    static void Deposit(CardHolder currentUser)
    {
        Console.WriteLine("How much $$ would you like to deposit? ");
        double deposit = Double.Parse(Console.ReadLine());
        currentUser.Balance += deposit;

        Console.WriteLine("Thank you for your $$$... Your new balance is {0}",currentUser.Balance);
    }
}
