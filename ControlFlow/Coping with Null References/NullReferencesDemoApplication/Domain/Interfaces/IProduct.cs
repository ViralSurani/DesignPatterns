using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Domain.Interfaces
{
    interface IProduct
    {
        string Name { get; }
        decimal Price { get; }
    }
}
