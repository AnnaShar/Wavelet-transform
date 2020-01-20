using System;
using System.IO;
using System.Drawing;

namespace DigitalWatermarking
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWord = "lena";
            var inPicture = keyWord+ ".jpg";
            var changedPicture = keyWord + "_changed.jpg";
            var qr = "QRcode_phone.png";
            var qr_extracted = keyWord + "_QR.jpg";




            DoubleImage initialImage, changedImage;

            using (Bitmap imageBitmap = new Bitmap("landscape.jpg")) //lena_changed.jpg
            {
                initialImage = new DoubleImage(imageBitmap);
            }

            using (Bitmap imageBitmap = new Bitmap("landscape_changed_cr.png"))
            {
                changedImage = new DoubleImage(imageBitmap);
            }

            DoubleImage full = DoubleImage.FillWithSmallerImage(initialImage, changedImage);
            Bitmap result = full.ToBitmap(1,0);
            result.Save("full.jpg");
            

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static Color getDominantColor(Bitmap bmp)
        {
            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color clr = bmp.GetPixel(x, y);

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    total++;
                }
            }

            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            return Color.FromArgb(r, g, b);
        }
        static string LongestCommonSubstring(string a, string b)
        {
            var n = a.Length;
            var m = b.Length;
            var array = new int[n, m];
            var maxValue = 0;
            var maxI = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (a[i] == b[j])
                    {
                        array[i, j] = (i == 0 || j == 0)
                            ? 1
                            : array[i - 1, j - 1] + 1;
                        if (array[i, j] > maxValue)
                        {
                            maxValue = array[i, j];
                            maxI = i;
                        }
                    }
                }
            }

            return a.Substring(maxI + 1 - maxValue, maxValue);
        }
        private static int MaxSquaredNumber(int number)
        {
            double root = Math.Sqrt(number);
            return (int)root;
        }
    }
}
