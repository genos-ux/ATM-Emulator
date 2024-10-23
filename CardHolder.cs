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



        private bool isValidName(string name) => Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
    }
}
