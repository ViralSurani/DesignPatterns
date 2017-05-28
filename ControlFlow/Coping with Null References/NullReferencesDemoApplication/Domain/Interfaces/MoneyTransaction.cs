using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Domain.Interfaces
{
    class MoneyTransaction
    {
        public decimal Amount { get; private set; }

        public MoneyTransaction(decimal amount)
        {
            Amount = amount;
        }
    }
}
