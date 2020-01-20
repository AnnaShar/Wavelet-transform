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

        public static double[,] Untransfrom(double[,] matrix, int decompositionLevel)
        {
            int width = matrix.GetLength(1);
            int height = matrix.GetLength(0);

            CheckDecompositionLevel(decompositionLevel, width, height);

            double[,] resultMatrix = matrix;
            for (int i = decompositionLevel; i >= 1; i--)
            {
                int variableWidth = width / i;
                int variableHeight = height / i;
                resultMatrix = Haar.Untransform(resultMatrix, variableWidth, variableHeight);
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

        public static double[,] SetCoefficient(double[,] matrix, Coefficients typeOfCoef, int decompositionLevel, double[,] coefficients)
        {
            int width = matrix.GetLength(1);
            int height = matrix.GetLength(0);

            CheckDecompositionLevel(decompositionLevel, width, height);

            int decompositionCoef = Convert.ToInt32(Math.Pow(2, decompositionLevel));
            Range range = GetRange(typeOfCoef, decompositionLevel, width, height);

            int coefWidth = width / decompositionCoef;
            int coefHeight = height / decompositionCoef;

            for (int i = 0; i < coefHeight; i++)
            {
                for (int j = 0; j < coefWidth; j++)
                    matrix[i + range.Height.StartIndex, j + range.Width.StartIndex] = coefficients[i,j];
            }
            return matrix;
        }

        private static Range GetRange(Coefficients typeOfCoef, int decompositionLevel, int width, int height)
        {
            int decompositionCoef = Convert.ToInt32(Math.Pow(2, decompositionLevel));
            Range range = new Range();

            switch (typeOfCoef)
            {
                case Coefficients.Approximation:
                    range.Width.StartIndex = 0;
                    range.Height.StartIndex = 0;
                    break;

                case Coefficients.Horizontal:
                    range.Width.StartIndex = width / decompositionCoef;
                    range.Height.StartIndex = 0;
                    break;

                case Coefficients.Vertical:
                    range.Width.StartIndex = 0;
                    range.Height.StartIndex = height / decompositionCoef;
                    break;

                case Coefficients.Diagonal:
                    range.Width.StartIndex = width / decompositionCoef;
                    range.Height.StartIndex = height / decompositionCoef;
                    break;

                default:
                    range.Width.StartIndex = 0;
                    range.Height.StartIndex = 0;
                    break;
            }

            return range;
        }

        private static void CheckDecompositionLevel(int decompositionLevel, int width, int height)
        {
            int decompositionCoef = Convert.ToInt32(Math.Pow(2, decompositionLevel));
            if (width % decompositionCoef != 0 || height % decompositionCoef != 0)
                throw new Exception("Ширина и высота должны делиться на 2 степени номера уровня разложения.");

        }

    }
}
