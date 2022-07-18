using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapplesInterop.Classes.P2P;
using MapplesInterop.Structs.MythicStructs;
namespace MapplesInterop.Interfaces
{
    public interface IPeerManager
    {
        Peer AddPeer(PeerInformation info);
        bool Remove(string uuid);
        bool Remove(IPeer peer);
        bool Route(DelegateMessage msg);
    }
}
