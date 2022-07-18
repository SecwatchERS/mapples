using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapplesInterop.Structs.MythicStructs;
using MapplesInterop.Types.Delegates;
using MapplesInterop.Interfaces;
using MapplesInterop.Enums.MapplesEnums;

namespace MapplesInterop.Interfaces
{
    public interface IC2Profile
    {
        bool Connect(CheckinMessage checkinMessage, OnResponse<MessageResponse> onResp);

        void Start();

        bool Send<IMythicMessage>(IMythicMessage message);

        bool SendRecv<T, TResult>(T message, OnResponse<TResult> onResponse);

        bool Recv(MessageType mt, OnResponse<IMythicMessage> onResp);

        // Basically tells the caller that this C2 profile is stateful,
        // and as such it supports only the SendRecv operation.
        bool IsOneWay();

        bool IsConnected();
    }
}
