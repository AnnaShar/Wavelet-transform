﻿using System;
using System.IO;
using System.Drawing;

namespace DigitalWatermarking
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWord = "roses";
            var inPicture = keyWord + ".jpg";
            var changedPicture = keyWord + "_changed.jpg";
            var qr = "QRcode_phone.png";
            var qr_extracted = keyWord + "_QR.jpg";


            DoubleImage image;
            using (Bitmap imageBM = new Bitmap(inPicture)) //lena_changed.jpg
            {
                image = new DoubleImage(imageBM);
            }
            /*Watermark watermark;
            using (Bitmap imageBM = new Bitmap(qr)) //lena_changed.jpg
            {
                DoubleImage imageTemp = new DoubleImage(imageBM);
                watermark = new Watermark(imageTemp);
            }

            JRKimAlgorithm algorithm = new JRKimAlgorithm();
            DoubleImage changed = algorithm.KIMembed(image, watermark);
            Bitmap result = changed.ToBitmap(1, 0);
            result.Save(changedPicture); */

            DoubleImage black;
            using (Bitmap imageBM = new Bitmap("black_cr.jpg")) //lena_changed.jpg
            {
                black = new DoubleImage(imageBM);
            }
            double[,] blue = image.GetColorComponent(DoubleImage.ColorComponent.Blue);
            double[,] red = image.GetColorComponent(DoubleImage.ColorComponent.Red);
            double[,] green = image.GetColorComponent(DoubleImage.ColorComponent.Green);
            /*double[,] changed_blue = Wavelet.Transform(blue, 1);
            double[,] changed_green = Wavelet.Transform(green, 1);
            double[,] changed_red = Wavelet.Transform(red, 1);*/
            //black.UpdateColorComponent(DoubleImage.ColorComponent.Red, red);
            black.UpdateColorComponent(DoubleImage.ColorComponent.Red, red);
           // black.UpdateColorComponent(DoubleImage.ColorComponent.Green, green);
            Bitmap result = black.ToBitmap(1, 0);
            result.Save("roses_red.jpg");

            /*DoubleImage initialImage, changedImage;

            using (Bitmap imageBitmap = new Bitmap(inPicture)) //lena_changed.jpg
            {
                initialImage = new DoubleImage(imageBitmap);
            }

            using (Bitmap imageBitmap = new Bitmap(changedPicture))
            {
                changedImage = new DoubleImage(imageBitmap);
            }

            JRKimAlgorithm algorithm = new JRKimAlgorithm();
            DoubleImage watermark = algorithm.KIMextract(initialImage, changedImage, 100, 100);
            Bitmap result = watermark.ToBitmap(1,0);
            result.Save(qr_extracted);*/


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
