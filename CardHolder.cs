using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ATM_Emulator
{
    public class CardHolder
    {
        private string _firstName;
        private string _pin;
        private string _lastName;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if(isValidName(_firstName) && _firstName.Length > 0)
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
                if(isValidName(_lastName) && _lastName.Length > 0)
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
                if(isValidPin(_pin))
                    value = _pin;

                else
                {
                    throw new InvalidPinException("Invalid PIN. PIN must be a 4-digit number consisting of only numeric characters.");
                }
            }
        }

        public double Balance {get; set;}

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
