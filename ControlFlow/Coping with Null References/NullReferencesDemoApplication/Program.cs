using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Application.Implementation;
using NullReferencesDemoApplication.Domain.Implementation;
using NullReferencesDemoApplication.Infrastructure.Implementation;
using NullReferencesDemoApplication.Presentation.Implementaion;
using NullReferencesDemoApplication.Presentation.Interfaces;
using NullReferencesDemoApplication.Presentation.PurchaseReports;

namespace NullReferencesDemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IPurchaseReportFactory purchaseReportFactory = new PurchaseReportFactory();

            UserInterface ui =
               new UserInterface(
                   new ApplicationServices(
                       new DomainServices(
                           new UserRepository(),
                           new ProductRepository(),
                           purchaseReportFactory),
                           purchaseReportFactory));

            while (ui.ReadCommand())
            {
                ui.ExecuteCommand();
            }
        }
    }
}
