using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.PurchaseReports
{
    class NotEnoughMoney : IPurchaseReport
    {
        private readonly string _username;
        private readonly string _productName;
        private readonly decimal _price;

        public NotEnoughMoney(string username, string productName, decimal price)
        {
            _username = username;
            _productName = productName;
            _price = price;
        }

        public string ToUiText()
        {
            return string.Format("Dear {0},\nYou do not have {1:C} to pay for the {2}.", _username, _price, _productName);
        }
    }
}
