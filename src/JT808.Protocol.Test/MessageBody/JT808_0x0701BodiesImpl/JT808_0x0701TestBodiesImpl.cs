﻿using JT808.Protocol.Attributes;
using JT808.Protocol.MessageBody;
using JT808.Protocol.Test.MessageBody.JT808Formatters;
using System;
using System.Collections.Generic;
using System.Text;

namespace JT808.Protocol.Test.MessageBody.JT808_0x0701BodiesImpl
{
    [JT808Formatter(typeof(JT808_0x0701TestBodiesImplFormatter))]
    public class JT808_0x0701TestBodiesImpl: JT808_0x0701.JT808_0x0701Body
    {
        public uint Id { get; set; }

        public ushort UserNameLength { get; set; }

        public string UserName { get; set; }
    }
}
