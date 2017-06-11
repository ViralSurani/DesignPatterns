using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Application.Interfaces
{
    interface IDomainServices
    {
        void CreateUser(string username);
        bool IsRegistered(string username);
        void Deposit(string username, decimal amount);
        decimal GetBalance(string username);
        IPurchaseReport Purchase(string username, string itemName);
        IEnumerable<StockItem> GetAvaliableItems();
    }
}
