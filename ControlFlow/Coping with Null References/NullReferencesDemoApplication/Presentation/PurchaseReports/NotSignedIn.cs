using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Presentation.PurchaseReports
{
    class NotSignedIn : IPurchaseReport
    {
        public string ToUiText()
        {
            return "No user is signed in.";
        }
    }
}
