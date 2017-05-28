using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Domain.Interfaces;
using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Domain.Implementation
{
    class User : IUser
    {
        public string Username { get; private set; }
        private IAccount _account;

        public User(string username,IAccount account)
        {
            Username = username;
            _account = account;
        }

        public decimal Balance
        {
            get { return _account.Balance; }
        }

        public void Deposit(decimal amount)
        {
            _account.Deposit(amount);
        }

        public Presentation.Interfaces.Receipt Purchase(IProduct product)
        {
            MoneyTransaction transaction = _account.Withdraw(product.Price);
            if (transaction == null)
                return null;
            return new Receipt(product.Name, product.Price);
        }
    }
}
