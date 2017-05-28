using NullReferencesDemoApplication.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Infrastructure.Implementation
{
    class ProductData:IProduct
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public ProductData(string name,decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
