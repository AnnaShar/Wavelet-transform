using System;
using System.IO;
using System.Drawing;

namespace DigitalWatermarking
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Bitmap image = new Bitmap("QRcode.png")) {
                DoubleImage dImage = new DoubleImage(image);
                Watermark watermark = new Watermark(dImage);
            }
            Console.Read();
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
    }
}
