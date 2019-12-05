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
        public Watermark(int length)
        {
            Length = length;
            _bits = new int[length];
        }
        public Watermark(DoubleImage image) {
            _bits = new int[image.Width * image.Height];

            for(int i=0; i<image.Height; i++)
            {
                for(int j=0; j<image.Width; j++)
                {
                    //black
                    if (image.GetPixel(i, j).Blue == 0 && image.GetPixel(i, j).Red == 0 && image.GetPixel(i, j).Green == 0)
                        _bits[i * image.Width + j]=0;
                    //white
                    if (image.GetPixel(i, j).Blue == 255 && image.GetPixel(i, j).Red == 255 && image.GetPixel(i, j).Green == 255)
                        _bits[i * image.Width + j] = 1;
                }
            }
        }
    }
}
