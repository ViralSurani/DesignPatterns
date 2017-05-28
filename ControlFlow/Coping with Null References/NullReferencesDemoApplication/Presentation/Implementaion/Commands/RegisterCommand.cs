using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Implementaion.Commands
{
    class RegisterCommand : ICommand
    {
        private IApplicationServices _applicationServices;

        public RegisterCommand(IApplicationServices applicationServices)
        {
            _applicationServices = applicationServices;
        }


        public void Execute()
        {
            Console.Write("Enter username to register: ");
            string username = Console.ReadLine();

            _applicationServices.RegisterUser(username);

            Console.WriteLine("User '{0}' is now registered.", username);
        }
    }
}
