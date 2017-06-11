using NullReferencesDemoApplication.Presentation.Interfaces;

namespace NullReferencesDemoApplication.Presentation.PurchaseReports
{
    class FailedPurchase : IPurchaseReport
    {
        private static FailedPurchase _instance;

        private FailedPurchase()
        {
        }

        public static FailedPurchase Instance {
            get
            {
                if(_instance==null)
                    _instance = new FailedPurchase();
                return _instance;
            }
        }

        public string ToUiText()
        {
            return "Purchase Failed.";
        }
    }
}
