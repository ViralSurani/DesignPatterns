using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Domain.Interfaces
{
    interface IUserRepository
    {
        void Add(IUser user);
        IUser Find(string username);
    }
}
