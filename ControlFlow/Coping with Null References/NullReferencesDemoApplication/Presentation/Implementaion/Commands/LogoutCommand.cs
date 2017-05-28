using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Implementaion.Commands
{
    class LogoutCommand : ICommand
    {
        private IApplicationServices _applicationServices;

        public LogoutCommand(IApplicationServices applicationServices)
        {
            _applicationServices = applicationServices;
        }

        public void Execute()
        {
           _applicationServices.Logout();
           Console.WriteLine("User is now logged out.");
        }
    }
}
