using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NullReferencesDemoApplication.Application.Implementation;
using NullReferencesDemoApplication.Domain.Implementation;
using NullReferencesDemoApplication.Infrastructure.Implementation;
using NullReferencesDemoApplication.Presentation.Implementaion;

namespace NullReferencesDemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui =
               new UserInterface(
                   new ApplicationServices(
                       new DomainServices(
                           new UserRepository(),
                           new ProductRepository())));

            while (ui.ReadCommand())
            {
                ui.ExecuteCommand();
            }
        }
    }
}
