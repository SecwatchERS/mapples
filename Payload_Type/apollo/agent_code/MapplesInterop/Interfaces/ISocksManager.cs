using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapplesInterop.Structs.MythicStructs;

namespace MapplesInterop.Interfaces
{
    public interface ISocksManager
    {
        bool Route(SocksDatagram dg);

        bool Remove(int id);
    }
}
