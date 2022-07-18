using MapplesInterop.Structs.MapplesStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MapplesInterop.Interfaces
{
    public interface IProcess
    {
        bool Inject(byte[] code, string arguments = "");
        void WaitForExit();
        void WaitForExit(int milliseconds);

        bool Start();
        bool StartWithCredentials(MapplesLogonInformation logonInfo);

        bool StartWithCredentials(IntPtr hToken);

    }
}
