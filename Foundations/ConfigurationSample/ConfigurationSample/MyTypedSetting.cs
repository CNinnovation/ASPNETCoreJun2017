using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigurationSample
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class MyTypedSetting
    {
        public Point TopLeft { get; set; }
        public string Title { get; set; }
    }
}
