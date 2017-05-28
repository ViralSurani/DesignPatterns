using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Domain.Interfaces;

namespace NullReferencesDemoApplication.Domain.Implementation
{
    class Account : IAccount
    {
        private IList<MoneyTransaction> _transactions;

        public Account()
        {
            _transactions = new List<MoneyTransaction>();
        }

        public decimal Balance
        {
            get { return _transactions.Sum(trans => trans.Amount); }
        }

        public MoneyTransaction Deposit(decimal amount)
        {
            MoneyTransaction transaction = new MoneyTransaction(amount);
            _transactions.Add(transaction);
            return transaction;
        }

        public MoneyTransaction Withdraw(decimal amount)
        {
            if (amount > Balance)
                return null;

            MoneyTransaction moneyTransaction = new MoneyTransaction(-amount);
            _transactions.Add(moneyTransaction);
            return moneyTransaction;
        }
    }
}
