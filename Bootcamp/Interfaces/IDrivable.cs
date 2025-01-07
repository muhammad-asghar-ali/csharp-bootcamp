using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IDrivable
    {
        int Wheels { get; set; }
        double Speed { get; set; }

        // Classes that inherit an interface must fulfill the contract and implement every abstract method
        void Move();
        void Stop();
    }
}