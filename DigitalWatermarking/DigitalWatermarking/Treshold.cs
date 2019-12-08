using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWatermarking
{
    public static class Threshold
    {
        public static double GetThreshold(double[,] horizontal, double[,] vertical, double[,] diagonal)
        {
            double horMax = MaxMatrix(horizontal);
            double vertMax = MaxMatrix(vertical);
            double diagMax = MaxMatrix(diagonal);
            double max = MaxArray(new double[] { horMax, vertMax, diagMax });

            double treshold = Math.Pow(2, (Math.Log(max, 2) - 1));
            return treshold;
        }

        public static double GetThreshold(double[,] horizontal, double[,] vertical, double[,] diagonal, double[,] approximation)
        {
            double horMax = MaxMatrix(horizontal);
            double vertMax = MaxMatrix(vertical);
            double diagMax = MaxMatrix(diagonal);
            double approxMax = MaxMatrix(approximation);
            double max = MaxArray(new double[] { horMax, vertMax, diagMax, approxMax });

            double treshold = Math.Pow(2, (Math.Log(max, 2) - 1));
            return treshold;
        }
        private static double MaxMatrix(double[,] matrix)
        {
            double max = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var absNumber = Math.Abs(matrix[i, j]);
                    if (absNumber > max)
                        max = absNumber;
                }
            }
            return max;
        }
        private static double MaxArray(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];
            return max;
        }

        private static double MinArray(double[] array)
        {
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
                if (array[i] < max)
                    max = array[i];
            return max;
        }
    }
}
