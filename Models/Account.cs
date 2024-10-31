using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Emulator.Models
{
    public class Account
    {
        public int Id {get; set;}

        public string FullName {get; set;} = null!;

        public string AccountNumber {get; set;}

        public double Balance {get; set;}

        public int Pin {get; set;}


    }
}
