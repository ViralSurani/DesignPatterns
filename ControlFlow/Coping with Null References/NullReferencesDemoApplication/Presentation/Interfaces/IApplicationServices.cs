using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Interfaces
{
    interface IApplicationServices
    {
        bool IsUserLoggedIn { get; }
        string LoggedInUsername { get; }
        decimal LoggedInUserBalance { get; }
        void RegisterUser(string username);
        bool Login(string username);
        void Logout();
        void Deposit(decimal amount);
        IEnumerable<StockItem> GetAvaliableItems();
        IPurchaseReport Purchase(string itemName);
    }
}
