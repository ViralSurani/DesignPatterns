using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferencesDemoApplication.Presentation.Interfaces
{
    interface IUserInterface
    {
        bool ReadCommand();
        void ExecuteCommand();
    }
}
