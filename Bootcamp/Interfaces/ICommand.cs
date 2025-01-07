using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ICommand
    {
        void Execute();
        void Undo();
    }
}