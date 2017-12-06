using System;

namespace ZJModbus.App.Attributes
{
    public class DescriptionAttribute :Attribute
    {
        public string Name { get; set; }

        public string Unit { get; set; }
    }
}
