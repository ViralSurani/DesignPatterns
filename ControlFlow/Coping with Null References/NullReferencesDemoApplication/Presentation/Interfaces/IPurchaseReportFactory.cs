using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Interfaces
{
    interface IPurchaseReportFactory
    {
        IPurchaseReport CreateFailedPurchase();
        IPurchaseReport CreateNotSignedIn();
        IPurchaseReport CreateNotRegistered(string username);
        IPurchaseReport CreateProductNotFound(string usrename, string productName);
        IPurchaseReport CreateNotEnoughMoney(string username, string productName, decimal price);
        IPurchaseReport CreateReport(string username, string productName, decimal price);
    }
}
