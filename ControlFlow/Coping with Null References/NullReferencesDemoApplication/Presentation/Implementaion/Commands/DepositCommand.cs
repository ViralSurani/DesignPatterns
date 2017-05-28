using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Implementaion.Commands
{
    class DepositCommand : ICommand
    {
        private IApplicationServices _applicationServices;

        public DepositCommand(IApplicationServices applicationServices)
        {
            _applicationServices = applicationServices;
        }

        public void Execute()
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            _applicationServices.Deposit(amount);
        }
    }
}
