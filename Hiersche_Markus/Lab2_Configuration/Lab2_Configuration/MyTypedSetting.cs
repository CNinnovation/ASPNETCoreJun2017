using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2_Configuration
{
    public struct Zahl
    {
        public int b { get; set; }
    }

    class MyTypedSetting
    {
        public Zahl zahl { get; set; }
        public string title { get; set; }
    }
}
