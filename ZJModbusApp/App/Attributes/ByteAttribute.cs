using System;

namespace ZJModbus.App.Attributes
{
    public class ByteAttribute :Attribute
    {
        public int ByteIndex { get; set; }
    }
}
