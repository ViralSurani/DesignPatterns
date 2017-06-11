using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Presentation.Interfaces;
using NullReferencesDemoApplication.Application.Interfaces;
using NullReferencesDemoApplication.Presentation.PurchaseReports;

namespace NullReferencesDemoApplication.Application.Implementation
{
    class ApplicationServices : IApplicationServices
    {
        private readonly IDomainServices _domainService;
        private IPurchaseReportFactory _purchaseReportFactory;
        private string _loggedInUsername;

        public ApplicationServices(IDomainServices domainService, IPurchaseReportFactory purchaseReportFactory)
        {
            _domainService = domainService;
            _purchaseReportFactory = purchaseReportFactory;
            _loggedInUsername = string.Empty;
        }

        public bool IsUserLoggedIn
        {
            get { return !string.IsNullOrEmpty(_loggedInUsername); }
        }

        public string LoggedInUsername
        {
            get
            {
                AssertUserLoggedIn();
                return _loggedInUsername;
            }
        }

        public decimal LoggedInUserBalance
        {
            get
            {
                AssertUserLoggedIn();
                return _domainService.GetBalance(_loggedInUsername);
            }
        }

        public void RegisterUser(string username)
        {
            _domainService.CreateUser(username);
        }

        public bool Login(string username)
        {
            bool loggedIn = _domainService.IsRegistered(username);

            if (loggedIn)
                _loggedInUsername = username;

            return loggedIn;
        }

        public void Logout()
        {
            _loggedInUsername = string.Empty;
        }

        public void Deposit(decimal amount)
        {
            AssertUserLoggedIn();
            _domainService.Deposit(LoggedInUsername, amount);
        }

        public IEnumerable<StockItem> GetAvaliableItems()
        {
            return _domainService.GetAvaliableItems();
        }

        public IPurchaseReport Purchase(string itemName)
        {
            if (!IsUserLoggedIn)
                return _purchaseReportFactory.CreateNotSignedIn();
            return _domainService.Purchase(_loggedInUsername, itemName);
        }

        private void AssertUserLoggedIn()
        {
            if (!IsUserLoggedIn)
                throw new InvalidOperationException("No user logged in.");
        }
    }
}
