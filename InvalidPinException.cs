using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Emulator
{
    public class InvalidPinException : Exception
    {
        public InvalidPinException(string message) : base(message) {}
    }
}
