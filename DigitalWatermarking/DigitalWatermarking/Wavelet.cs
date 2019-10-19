using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWatermarking
{
    public static class Wavelet
    {
        public enum Coefficients
        {
            Approximation,
            Horizontal,
            Vertical,
            Diagonal
        }
        public static double[,] Transform(double[,] matrix, int decompositionLevel)
        {
            int width = matrix.GetLength(1);
            int height = matrix.GetLength(0);

            CheckDecompositionLevel(decompositionLevel, width, height);

            double[,] resultMatrix = matrix;
            for (int i = 1; i <= decompositionLevel; i++)
            {
                int variableWidth = width / i;
                int variableHeight = height / i;
                resultMatrix = Haar.Transform(resultMatrix, variableWidth, variableHeight);
            }

            return resultMatrix;
        }

        public static double[,] GetCoefficient(double[,] matrix, Coefficients typeOfCoef, int decompositionLevel)
        {
            int width = matrix.GetLength(1);
            int height = matrix.GetLength(0);

            CheckDecompositionLevel(decompositionLevel, width, height);

            int decompositionCoef = Convert.ToInt32(Math.Pow(2, decompositionLevel));
            Range range = GetRange(typeOfCoef, decompositionLevel, width, height);
            double[,] resultCoef = new double[height / decompositionCoef, width / decompositionCoef];

            for(int i=0; i<resultCoef.GetLength(0); i++)
            {
                for (int j = 0;  j < resultCoef.GetLength(1); j++)
                    resultCoef[i, j] = matrix[i+ range.Height.StartIndex, j + range.Width.StartIndex];
            }
            return resultCoef;
        }

        private static Range GetRange(Coefficients typeOfCoef, int decompositionLevel, int width, int height)
        {
            int decompositionCoef = Convert.ToInt32(Math.Pow(2, decompositionLevel));
            Range range = new Range();

            switch (typeOfCoef)
            {
                case Coefficients.Approximation:
                    range.Width.StartIndex = 0;
                    //range.Width.EndIndex = width / decompositionCoef;
                    range.Height.StartIndex = 0;
                    //range.Height.EndIndex = height / decompositionCoef;
                    break;

                case Coefficients.Horizontal:
                    range.Width.StartIndex = width / decompositionCoef;
                    range.Width.EndIndex = 2 * width / decompositionCoef;
                    range.Height.StartIndex = 0;
                    range.Height.EndIndex = height / decompositionCoef;
                    break;

                case Coefficients.Vertical:
                    range.Width.StartIndex = 0;
                    range.Width.EndIndex = width / decompositionCoef;
                    range.Height.StartIndex = height / decompositionCoef;
                    range.Height.EndIndex = 2 * height / decompositionCoef;
                    break;

                case Coefficients.Diagonal:
                    range.Width.StartIndex = width / decompositionCoef;
                    range.Width.EndIndex = 2 * width / decompositionCoef;
                    range.Height.StartIndex = height / decompositionCoef;
                    range.Height.EndIndex = 2 * height / decompositionCoef;
                    break;

                default:
                    range.Width.StartIndex = 0;
                    range.Width.EndIndex = width;
                    range.Height.StartIndex = 0;
                    range.Height.EndIndex = height;
                    break;
            }

            return range;
        }

        private static void CheckDecompositionLevel(int decompositionLevel, int width, int height)
        {
            int decompositionCoef = Convert.ToInt32(Math.Pow(2, decompositionLevel));
            if (width % decompositionCoef != 0 || height % decompositionCoef != 0)
                throw new Exception("Width and height should be divided by 2^decompositionLevel.");

        }

    }
}
