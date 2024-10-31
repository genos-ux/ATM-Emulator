using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATM_Emulator.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public int AccountId { get; set; }

        public TransactionType TransactType { get; set; }

        public double Amount { get; set; }

        public string? Description { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}

public enum TransactionType
{
    Deposit,
    Withdraw,
    Transfer
}
