using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Emulator
{
    static class UsersDB
    {
        public static List<CardHolder> users = new List<CardHolder>()
        {
            new CardHolder {FirstName = "Cosmos",LastName="Green",Pin="1212"},
            new CardHolder {FirstName = "Oliver", LastName = "Thomas", Pin = "3234"},
            new CardHolder {FirstName = "Diggle", LastName = "Robert", Pin = "2215"},
            new CardHolder {FirstName = "Ashley", LastName = "Jones", Pin = "7834"},
            new CardHolder {FirstName = "Dawn", LastName = "Smith", Pin = "4845"}
        }


    }
}
