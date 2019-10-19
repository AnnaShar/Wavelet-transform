using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWatermarking
{
    public class Range
    {
        public Width Width { get; set; }
        public Height Height { get; set; }

        public Range()
        {
            Width = new Width();
            Height = new Height();
        }
    }

    public class Width
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

    }

    public class Height
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }

    }
}

