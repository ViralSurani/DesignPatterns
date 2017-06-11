using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.PurchaseReports
{
    class NotRegistered : IPurchaseReport
    {
        private readonly string _username;

        public NotRegistered(string username)
        {
            _username = username;
        }

        public string ToUiText()
        {
            return string.Format("User {0} is not registered.", _username);
        }
    }
}
