using System;
using System.IO;
using System.Drawing;

namespace DigitalWatermarking
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWord = "roses";
            var inPicture = keyWord+ ".jpg";
            var changedPicture = keyWord + "_changed.jpg";
            var qr = "QRcode_phone.png";
            var qr_extracted = keyWord + "_QR.jpg";



            Watermark watermark;
            DoubleImage image;
            using (Bitmap watermarkBitmap = new Bitmap(qr))
            {
                DoubleImage dImage = new DoubleImage(watermarkBitmap);
                watermark = new Watermark(dImage);
            }

            using (Bitmap imageBitmap = new Bitmap(inPicture))
            {
                image = new DoubleImage(imageBitmap);
            }

            JRKimAlgorithm algorithm = new JRKimAlgorithm();
            DoubleImage result = algorithm.KIMembed(image, watermark);
            Bitmap bitResult = result.ToBitmap(1, 0);
            bitResult.Save(changedPicture);

            DoubleImage initialImage, changedImage;

            using (Bitmap imageBitmap = new Bitmap(inPicture))
            {
                initialImage = new DoubleImage(imageBitmap);
            }

            using (Bitmap imageBitmap = new Bitmap(changedPicture))
            {
                changedImage = new DoubleImage(imageBitmap);
            }

            JRKimAlgorithm algorithm1 = new JRKimAlgorithm();
            DoubleImage watermark1 = algorithm1.KIMextract(initialImage, changedImage, 100, 100);
            Bitmap bitResult1 = watermark1.ToBitmap(1, 0);
            bitResult1.Save(qr_extracted);
            
            using (Bitmap imageBitmap = new Bitmap(inPicture))
            {
                Console.WriteLine(getDominantColor(imageBitmap));
            }

            /*DoubleImage initialImage, white;
            using (Bitmap imageBitmap = new Bitmap("big_lena.png"))
            {
                initialImage = new DoubleImage(imageBitmap);
            }

            using (Bitmap imageBitmap = new Bitmap("black.jpg"))
            {
                white = new DoubleImage(imageBitmap);
            }

            double[,] blue = initialImage.GetColorComponent(DoubleImage.ColorComponent.Blue);

            blue = Wavelet.Transform(blue, 3);
            initialImage.UpdateColorComponent(DoubleImage.ColorComponent.Blue, blue);
            Bitmap bitResult1 = initialImage.ToBitmap(1, 0);
            bitResult1.Save("lena_wavelet3.jpg");
            */

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
    }
}
