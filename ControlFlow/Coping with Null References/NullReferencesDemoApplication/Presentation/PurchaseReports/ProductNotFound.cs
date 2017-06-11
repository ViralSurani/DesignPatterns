using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Presentation.PurchaseReports
{
    class ProductNotFound : IPurchaseReport
    {
        private readonly string _username;
        private readonly string _productName;

        public ProductNotFound(string username, string productName)
        {
            _username = username;
            _productName = productName;
        }

        public string ToUiText()
        {
            return string.Format("Dear {0},\nSorry to inform you that we have no {1} left.", _username, _productName);
        }
    }
}
