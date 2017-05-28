using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Domain.Interfaces
{
    interface IProductRepository
    {
        IEnumerable<IProduct> GetAll();
        IProduct Find(string name);
    }
}
