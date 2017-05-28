using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Implementaion.Commands
{
    class LoginCommand : ICommand
    {
        private readonly IApplicationServices _applicationServices;

        public LoginCommand(IApplicationServices applicationServices)
        {
            _applicationServices = applicationServices;
        }

        public void Execute()
        {
           Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            if(_applicationServices.Login(username))
                Console.WriteLine("User '{0}' is now logged in.",username);
            else
                Console.WriteLine("Login failed for use '{0}'.", username);
        }
    }
}
