using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Domain.Interfaces
{
    interface IAccount
    {
        decimal Balance { get; }
        MoneyTransaction Deposit(decimal amount);
        MoneyTransaction Withdraw(decimal amount);
    }
}
