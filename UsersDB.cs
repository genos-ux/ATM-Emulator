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
            new CardHolder {FirstName = "Cosmos",LastName="Green",Pin="1212",CardNum = "4000123456789010",Balance = 150.31},
            new CardHolder {FirstName = "Oliver", LastName = "Thomas", Pin = "3234", CardNum = "5105105105105100", Balance = 321.13},
            new CardHolder {FirstName = "Dig", LastName = "Robert", Pin = "2215", CardNum = "6011000990139424", Balance = 105.59},
            new CardHolder {FirstName = "Ashley", LastName = "Jones", Pin = "7834", CardNum = "3530111333300000", Balance = 851.83},
            new CardHolder {FirstName = "Dawn", LastName = "Smith", Pin = "4845", CardNum = "4000519980003000", Balance = 54.27}
        };


    }
}
