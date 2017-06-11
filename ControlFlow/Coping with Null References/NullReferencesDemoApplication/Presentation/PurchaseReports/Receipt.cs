using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Presentation.PurchaseReports
{
     class Receipt : IPurchaseReport
     {
         private readonly string _username;
         private readonly string _productName;
         private readonly decimal _price;

         public Receipt(string username, string productName, decimal price)
         {
             _username = username;
             _productName = productName;
             _price = price;
         }

         public string ToUiText()
         {
             return string.Format("Dear {0},\nThank you for buying {1} for {2:C}.", _username, _productName,_price);
         }
    }
}
