using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Domain.Interfaces;

namespace NullReferencesDemoApplication.Infrastructure.Implementation
{
    class ProductRepository : IProductRepository
    {
        private IDictionary<string, decimal> _nameToPrice;

        public ProductRepository()
        {
            _nameToPrice=new Dictionary<string, decimal>();
            _nameToPrice.Add("book",27.46M);
            _nameToPrice.Add("pen", 6.28M);
            _nameToPrice.Add("ruler", 2.86M);
        }

        public IEnumerable<IProduct> GetAll()
        {
            return _nameToPrice.Select(pair => new ProductData(pair.Key, pair.Value));
        }

        public IProduct Find(string name)
        {
            decimal price;
            if(_nameToPrice.TryGetValue(name,out price))
                return new ProductData(name,price);

            return null;
        }
    }
}
