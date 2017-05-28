using NullReferencesDemoApplication.Presentation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Implementaion.Commands
{
    class DoNothingCommand : ICommand
    {
        public void Execute()
        {            
        }
    }
}
