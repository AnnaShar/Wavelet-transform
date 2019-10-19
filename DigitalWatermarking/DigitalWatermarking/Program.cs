using System;
using System.IO;

namespace DigitalWatermarking
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader str = new StreamReader("test1.txt"))
            {
                string parameters = str.ReadLine();

                string[] parameterNumbers = parameters.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int height = Convert.ToInt32(parameterNumbers[0]);
                int width = Convert.ToInt32(parameterNumbers[1]);

                double[,] matrix = new double[height, width];
                for (int i = 0; i < height; i++)
                {
                    var line = str.ReadLine();
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < numbers.Length; j++)
                        matrix[i, j] = Convert.ToInt32(numbers[j]);
                }

                PrintMatrix(matrix);
                Console.WriteLine();
                PrintMatrix(Haar.Transform(matrix, width, height));
                Console.WriteLine();

                PrintMatrix(Wavelet.Transform(matrix, 2));
                Console.WriteLine();

                //PrintMatrix(Wavelet.Transform(matrix, 3));
                Console.WriteLine();

                //PrintMatrix(Wavelet.GetCoefficient(Haar.Transform(matrix, width, height), Wavelet.Coefficients.Approximation, 1));
                //Console.WriteLine();

                //PrintMatrix(Wavelet.GetCoefficient(Haar.Transform(matrix, width, height), Wavelet.Coefficients.Horizontal, 1));
                //Console.WriteLine();

                //PrintMatrix(Wavelet.GetCoefficient(Haar.Transform(matrix, width, height), Wavelet.Coefficients.Diagonal, 1));
                //Console.WriteLine();
                Console.ReadLine();
            }
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
