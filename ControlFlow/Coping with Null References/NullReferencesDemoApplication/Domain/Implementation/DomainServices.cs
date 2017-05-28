using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Application.Interfaces;
using NullReferencesDemoApplication.Domain.Interfaces;
using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Domain.Implementation
{
    class DomainServices : IDomainServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;

        public DomainServices(IUserRepository userRepository, IProductRepository productRepository)
        {
            _userRepository = userRepository;
            _productRepository = productRepository;
        }

        public void CreateUser(string username)
        {
            IAccount userAccount = new Account();
            IUser user = new User(username, userAccount);
            _userRepository.Add(user);
        }

        public bool IsRegistered(string username)
        {
            IUser user = _userRepository.Find(username);
            return user != null;
        }

        public void Deposit(string username, decimal amount)
        {
            IUser user = _userRepository.Find(username);
            user.Deposit(amount);
        }

        public decimal GetBalance(string username)
        {
            IUser user = _userRepository.Find(username);
            return user.Balance;
        }

        public Presentation.Interfaces.Receipt Purchase(string username, string itemName)
        {
            IProduct product = _productRepository.Find(itemName);
            if (product == null)
                return null;

            IUser user = _userRepository.Find(username);
            if (user == null)
                return null;

            return user.Purchase(product);
        }

        public IEnumerable<Presentation.Interfaces.StockItem> GetAvaliableItems()
        {
            return _productRepository.GetAll().Select(product => new StockItem(product.Name, product.Price));
        }
    }
}
