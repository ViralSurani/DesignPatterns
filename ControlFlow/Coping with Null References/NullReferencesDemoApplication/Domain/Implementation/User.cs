using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Domain.Interfaces;
using NullReferencesDemoApplication.Presentation.Interfaces;
using NullReferencesDemoApplication.Presentation.PurchaseReports;

namespace NullReferencesDemoApplication.Domain.Implementation
{
    class User : IUser
    {
        public string Username { get; private set; }
        private IAccount _account;
        private IPurchaseReportFactory _purchaseReportFactory;

        public User(string username, IAccount account, IPurchaseReportFactory purchaseReportFactory)
        {
            Username = username;
            _account = account;
            _purchaseReportFactory = purchaseReportFactory;
        }

        public decimal Balance
        {
            get { return _account.Balance; }
        }

        public void Deposit(decimal amount)
        {
            _account.Deposit(amount);
        }

        public Presentation.Interfaces.IPurchaseReport Purchase(IProduct product)
        {
            MoneyTransaction transaction = _account.Withdraw(product.Price);
            if (transaction == null)
                return _purchaseReportFactory.CreateNotEnoughMoney(Username, product.Name, product.Price);
            return new Receipt(Username, product.Name, product.Price);
        }
    }
}
