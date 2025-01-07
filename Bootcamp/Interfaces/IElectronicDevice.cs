using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IElectronicDevice
    {
        // Each device to have these capabilities
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}