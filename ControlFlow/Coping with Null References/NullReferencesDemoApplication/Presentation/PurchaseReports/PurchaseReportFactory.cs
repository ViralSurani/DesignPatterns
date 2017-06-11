using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Presentation.PurchaseReports
{
    class PurchaseReportFactory : IPurchaseReportFactory
    {
        public IPurchaseReport CreateFailedPurchase()
        {
            return FailedPurchase.Instance;
        }

        public IPurchaseReport CreateNotSignedIn()
        {
            return new NotSignedIn();
        }

        public IPurchaseReport CreateNotRegistered(string username)
        {
            return new NotRegistered(username);
        }

        public IPurchaseReport CreateProductNotFound(string usrename, string productName)
        {
            return new ProductNotFound(usrename, productName);
        }

        public IPurchaseReport CreateNotEnoughMoney(string username, string productName, decimal price)
        {
            return new NotEnoughMoney(username, productName, price);
        }

        public IPurchaseReport CreateReport(string username, string productName, decimal price)
        {
            return new Receipt(username, productName, price);
        }
    }
}
