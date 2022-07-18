using MapplesInterop.Structs.MapplesStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MapplesInterop.Serializers
{
    public class MapplesSerializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            if (typeName == "MapplesInterop.Structs.MapplesStructs.PeerMessage")
            {
                return typeof(PeerMessage);
            }
            else
            {
                return typeof(Nullable);
            }
        }
    }
}
