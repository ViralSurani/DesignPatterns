using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Implementaion.Commands
{
    class PurchaseCommand : ICommand
    {
        private IApplicationServices _applicationServices;

        public PurchaseCommand(IApplicationServices applicationServices)
        {
            _applicationServices = applicationServices;
        }

        public void Execute()
        {
            ShowStock();

            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();

            IPurchaseReport report = _applicationServices.Purchase(itemName);

            DisplayReceipt(report);
        }

        private void ShowStock()
        {
            Console.WriteLine("Available items:");
            foreach (StockItem item in _applicationServices.GetAvaliableItems())
            {
                Console.WriteLine("{0,10} {1:C}", item.Name, item.Price);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private void DisplayReceipt(IPurchaseReport report)
        {            
            Console.WriteLine(report.ToUiText());
        }
    }
}
