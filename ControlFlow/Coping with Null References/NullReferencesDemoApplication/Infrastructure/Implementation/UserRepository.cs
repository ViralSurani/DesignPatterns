using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Domain.Interfaces;

namespace NullReferencesDemoApplication.Infrastructure.Implementation
{
    class UserRepository : IUserRepository
    {
        private IDictionary<string, IUser> _usernameToUser;

        public UserRepository()
        {
            _usernameToUser = new Dictionary<string, IUser>();
        }

        public void Add(IUser user)
        {
            _usernameToUser.Add(user.Username, user);
        }

        public IUser Find(string username)
        {
            IUser user = null;
            if (_usernameToUser.TryGetValue(username, out user))
                return user;
            return null;
        }
    }
}
