using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWatermarking
{
    public static class Haar
    {
        private static double[] c_low = new double[2] { 0.70710678118, 0.70710678118 };
        private static double[] c_high = new double[2] { 0.70710678118, -0.70710678118 };
        private static int waveletOrder = 2;

        public static double[,] Transform(double[,] matrix, int variableWidth, int variableHeight)
        {
            int actualWidth = matrix.GetLength(1);
            int actualHeight = matrix.GetLength(0);


            double[,] intermediateMatrix = new double[variableHeight, variableWidth];
            double[,] resultMatrix = new double[variableHeight, variableWidth];

            //Rows transformation
            for (int i = 0; i < variableHeight; i++) 
            {
                for (int j = 0; j < variableWidth / 2; j++)
                {
                    double transformNumberLow = 0, transformNumberHigh = 0;

                    for (int d = 0; d < waveletOrder; d++)
                    {
                        transformNumberLow += c_low[d] * matrix[i, (j * 2 + d)];
                        transformNumberHigh += c_high[d] * matrix[i, (j * 2 + d)];
                    }

                    intermediateMatrix[i, j] = transformNumberLow; //Low frequency component
                    intermediateMatrix[i, variableWidth / 2 + j] = transformNumberHigh; //High frequency component
                }
            }
           
            //Column transformation
            for (int i = 0; i < variableWidth; i++)
            {
                for (int j = 0; j < variableHeight / 2; j++)
                {
                    double transformNumberLow = 0, transformNumberHigh = 0;

                    for (int d = 0; d < waveletOrder; d++)
                    {
                        transformNumberLow += c_low[d] * intermediateMatrix[(j * 2 + d), i];
                        transformNumberHigh += c_high[d] * intermediateMatrix[(j * 2 + d), i];
                    }

                    resultMatrix[j, i] = transformNumberLow; //Low frequency component
                    resultMatrix[variableHeight / 2 + j, i] = transformNumberHigh; //High frequency component
                }
            }

            if(variableWidth!= actualWidth)
                resultMatrix = FillRestMatrix(matrix, resultMatrix, variableWidth, variableHeight);
            
            return resultMatrix;
        }

        public static double[,] Untransform(double[,] matrix, int variableWidth, int variableHeight)
        {
            double[,] intermediateMatrix = new double[variableHeight, variableWidth];
            double[,] resultMatrix = new double[variableHeight, variableWidth];

            //Column transformation
            for (int i = 0; i < variableWidth; i++)
            {
                for (int j = 0; j < variableHeight / 2; j++)
                {
                    double transformedNumberLow = matrix[j, i];
                    double transformedNumberHigh = matrix[variableHeight / 2 + j, i];

                    double initialNumberLow = (transformedNumberLow + transformedNumberHigh) * c_low[0];
                    double initialNumberHigh = (transformedNumberLow - transformedNumberHigh) * c_high[0];

                    intermediateMatrix[j * 2 , i] = initialNumberLow; //Low frequency component
                    intermediateMatrix[j * 2 + 1, i] = initialNumberHigh; //High frequency component
                }
            }

            //Rows transformation
            for (int i = 0; i < variableHeight; i++)
            {
                for (int j = 0; j < variableWidth / 2; j++)
                {
                    double transformedNumberLow = intermediateMatrix[i, j];
                    double transformedNumberHigh = intermediateMatrix[i, variableWidth / 2 + j];

                    double initialNumberLow = (transformedNumberLow + transformedNumberHigh) * c_low[0];
                    double initialNumberHigh = (transformedNumberLow - transformedNumberHigh) * c_high[0];

                    resultMatrix[i, j * 2] = initialNumberLow; //Low frequency component
                    resultMatrix[i, j * 2 + 1] = initialNumberHigh; //High frequency component
                }
            }
            int actualWidth = matrix.GetLength(1);
            if (variableWidth != actualWidth)
                resultMatrix = FillRestMatrix(matrix, resultMatrix, variableWidth, variableHeight);

            return resultMatrix;
        }

        private static double[,] FillRestMatrix(double[,] originalMatrix, double[,] transfromMatrix, int variableWidth, int variableHeight)
        {
            double[,] resultMatrix = new double[originalMatrix.GetLength(0), originalMatrix.GetLength(1)];
            for (int i = 0; i < variableHeight; i++)
            {
                for (int j = 0; j < variableWidth; j++)
                    resultMatrix[i, j] = transfromMatrix[i, j];
                for (int j = variableWidth; j < originalMatrix.GetLength(1); j++)
                    resultMatrix[i, j] = originalMatrix[i, j];
            }
            for (int i = variableHeight; i < originalMatrix.GetLength(0); i++)
                for (int j = 0; j < originalMatrix.GetLength(1); j++)
                    resultMatrix[i, j] = originalMatrix[i, j];
            return resultMatrix;
        }

    }
}
