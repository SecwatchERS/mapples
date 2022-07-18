using MapplesInterop.Structs.MapplesStructs;
using MapplesInterop.Structs.MythicStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;

namespace MapplesInterop.Interfaces
{
    public interface IIdentityManager
    {
        WindowsIdentity GetCurrentPrimaryIdentity();
        WindowsIdentity GetCurrentImpersonationIdentity();
        WindowsIdentity GetOriginal();

        bool GetCurrentLogonInformation(out MapplesLogonInformation logonInfo);

        void Revert();

        void SetPrimaryIdentity(WindowsIdentity identity);

        void SetPrimaryIdentity(IntPtr hToken);

        void SetImpersonationIdentity(WindowsIdentity identity);
        void SetImpersonationIdentity(IntPtr hToken);

        bool SetIdentity(MapplesLogonInformation token);

        IntegrityLevel GetIntegrityLevel();

        bool IsOriginalIdentity();
    }
}
