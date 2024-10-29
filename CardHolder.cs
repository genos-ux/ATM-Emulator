using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace ATM_Emulator
{
    public class CardHolder
    {
        //field data
        private string _firstName;
        private string _pin;
        private string _lastName;


        //properties with setters and getters.
        public string FirstName
        {
            get => _firstName;
            set
            {
                if(isValidName(value) && value.Length > 0)
                {
                    _firstName = value;
                }
                else
                {
                    throw new ArgumentException("Provide a last name and make sure there are no special characters.");
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if(isValidName(value) && value.Length > 0)
                {
                    _lastName = value;
                }
                else
                {
                    throw new ArgumentException("Provide a last name and make sure there are no special characters.");
                }
            }
        }


        public string Pin
        {
            get => _pin;
            set
            {
                if(isValidPin(value))
                    _pin = value;

                else
                {
                    throw new InvalidPinException("Invalid PIN. PIN must be a 4-digit number consisting of only numeric characters.");
                }
            }
        }

        public string CardNum {get; set;}

        public double Balance { get; set; }

        //CardHolder Methods
        public void Deposit()
        {
            Console.WriteLine("How much $$ would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            this.Balance += deposit;

            Console.WriteLine("Thank you for your $$$... Your new balance is ${0}",this.Balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("How much $$$ will you like to withdraw? ");
            double withdrawal = Double.Parse(Console.ReadLine());

            //Check if the user has enough money
            if(withdrawal > this.Balance)
            {
                Console.WriteLine("Insufficient funds :(");
            }

            else
            {
                this.Balance -= withdrawal;
                Console.WriteLine("You're good to go! Thank you : ");

            }
        }

        private bool isValidName(string name) => Regex.IsMatch(name, @"^[a-zA-Z\s]+$");

        private bool isValidPin (string pin)
        {
            if(pin.Length == 4 && IsAllDigits(pin))
                return true;

            return false;
        }

        private bool IsAllDigits(string str)
        {
            foreach (char c in str)
            {
                if(!char.IsDigit(c))
                    return false;
            }

            return true;
        }
    }
}
