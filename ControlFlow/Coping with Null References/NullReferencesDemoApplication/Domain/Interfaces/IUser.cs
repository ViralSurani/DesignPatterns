using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Domain.Interfaces
{
    interface IUser
    {
        string Username { get; }
        decimal Balance { get; }

        void Deposit(decimal amount);
        Receipt Purchase(IProduct product);
    }
}
