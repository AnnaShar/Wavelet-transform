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
            Length = image.Width * image.Height;
            _bits = new int[Length];

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

        public Watermark Append(Watermark addWatermark, int p)
        {
            Watermark newWatermark = this;
            for (int i = p; i < this.Length; i++)
            {
                newWatermark[i] = addWatermark[i];
            }
            return newWatermark;
        }

        public DoubleImage ToDoubleImage(int width, int height)
        {
            DoubleImage image = new DoubleImage(width, height);
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    int index = i * image.Width + j;

                    //black
                    if (this[index] == 0)
                    {
                        image.SetPixel(i, j, 0, 0, 0);
                    }


                    //white
                    if (this[index] == 1)
                        image.SetPixel(i, j, 255, 255, 255);

                }
            }
            return image;
        }
        public override string ToString()
        {
            return string.Join("", _bits);
        }

        public int CompareBitToBit(Watermark watermark)
        {
            int equalBits = 0;
            int comparisonLength = Math.Min(this.Length, watermark.Length);
            for (int i = 0; i < comparisonLength; i++)
            {
                if (watermark._bits[i] == this._bits[i])
                    equalBits++;
            }
            return equalBits;
        }
    }
}
