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

        public DoubleImage ToDoubleImage(int width, int height)
        {
            DoubleImage image = new DoubleImage(width, height);
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    //black
                    if (this[i * image.Width + j] == 0)
                        image.SetPixel(i, j, 0, 0, 0);

                    //white
                    if (this[i * image.Width + j] == 1)
                        image.SetPixel(i, j, 255, 255, 255);
                }
            }
            return image;
        }
    }
}
