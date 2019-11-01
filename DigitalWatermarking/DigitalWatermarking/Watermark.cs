using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWatermarking
{
    public class Watermark
    {
        public int Length { get; private set; }

        private int[] _bits;

        public int this[int index]
        {
            get { return _bits[index]; }
            set { _bits[index] = value; }
        }

    }
}
