using System;
using System.IO;
using System.Drawing;

namespace DigitalWatermarking
{
    class Program
    {
        static void Main(string[] args)
        {
            /* using (Bitmap image = new Bitmap("QRcode.png")) {
                 DoubleImage dImage = new DoubleImage(image);
                 Watermark watermark = new Watermark(dImage);
             }
             Console.Read();*/
            double[,] matrix;
            using (StreamReader str = new StreamReader("test.txt"))
            {
                string parameters = str.ReadLine();

                string[] parameterNumbers = parameters.Split(' ');
                int height = Convert.ToInt32(parameterNumbers[0]);
                int width = Convert.ToInt32(parameterNumbers[1]);

                matrix = new double[height, width];
                for (int i = 0; i < height; i++)
                {
                    var line = str.ReadLine();
                    string[] numbers = line.Split(' ');
                    for (int j = 0; j < numbers.Length; j++)
                        matrix[i, j] = Convert.ToInt32(numbers[j]);
                }

                PrintMatrix(matrix);
                Console.WriteLine();
               
                var transfromedMatrix = Wavelet.Transform(matrix, 3);
                PrintMatrix(transfromedMatrix);
                Console.WriteLine();

                var initialMatrix = Wavelet.Untransfrom(transfromedMatrix, 3);
                PrintMatrix(initialMatrix);
                Console.WriteLine();
            }
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
    }
}
