﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapplesInterop.Interfaces
{
    public interface ICryptographySerializer : ISerializer
    {
        bool UpdateUUID(string uuid);
        bool UpdateKey(string key);

        string GetUUID();
    }
}
