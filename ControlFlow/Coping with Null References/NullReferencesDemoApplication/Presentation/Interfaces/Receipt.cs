using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Interfaces
{
     class Receipt
    {
         public string ItemName { get; private set; }
         public decimal Price { get; private set; }

         public Receipt(string iteamName,decimal price)
         {
             ItemName = iteamName;
             Price = price;
         }
    }
}
