using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWatermarking
{
    class JRKimAlgorithm
    {
        private double coefApprox = 0.02;
        private double coef3Level = 0.1;
        private double coef2Level = 0.2;
        private double coef1Level = 0.4;


        public void KIMembed(DoubleImage image, Watermark initialWatermark)
        { 
            // Get blue component from image
            double[,] blueComponent = image.GetColorComponent(DoubleImage.ColorComponent.Blue);

            // Transfrom blue component with wavelet transformation
            double[,] waveletTransformedComponent = Wavelet.Transform(blueComponent, 3);

            // Get coefficients of transformation
            double[,] approx3 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Approximation, 3);
            double[,] detailHor3 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Horizontal, 3);
            double[,] detailVert3 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Vertical, 3);
            double[,] detailDiag3 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Diagonal, 3);

            double[,] detailHor2 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Horizontal, 2);
            double[,] detailVert2 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Vertical, 2);
            double[,] detailDiag2 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Diagonal, 2);

            double[,] detailHor1 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Horizontal, 1);
            double[,] detailVert1 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Vertical, 1);
            double[,] detailDiag1 = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Diagonal, 1);

            // Get tresholds
            double treshold1 = Treshold.GetTreshold(detailHor1, detailVert1, detailDiag1);
            double treshold2 = Treshold.GetTreshold(detailHor2, detailVert2, detailDiag2);
            double treshold3 = Treshold.GetTreshold(detailHor3, detailVert3, detailDiag3, approx3);

            Watermark watermark = TransformWatermark(initialWatermark);

            // Embed watermark into coefficients
            int p = 0;
            p = EmbedInCoef(coefApprox, approx3, treshold3, watermark, p);
            p = EmbedInCoef(coef3Level, detailHor3, treshold3, watermark, p);
            p = EmbedInCoef(coef3Level, detailVert3, treshold3, watermark, p);
            p = EmbedInCoef(coef3Level, detailDiag3, treshold3, watermark, p);

            p = EmbedInCoef(coef2Level, detailHor2, treshold2, watermark, p);
            p = EmbedInCoef(coef2Level, detailVert2, treshold2, watermark, p);
            p = EmbedInCoef(coef2Level, detailDiag2, treshold2, watermark, p);

            p = EmbedInCoef(coef1Level, detailHor1, treshold1, watermark, p);
            p = EmbedInCoef(coef1Level, detailVert1, treshold1, watermark, p);
            p = EmbedInCoef(coef1Level, detailDiag1, treshold1, watermark, p);

            // Restore blue component from coefficients
            double[,] componentWithWatermark = new double[blueComponent.GetLength(0), blueComponent.GetLength(1)];
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Approximation, 3, approx3);
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Horizontal, 3, detailHor3);
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Vertical, 3, detailVert3);
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Diagonal, 3, detailDiag3);

            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Horizontal, 2, detailHor2);
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Vertical, 2, detailVert2);
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Diagonal, 2, detailDiag2);

            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Horizontal, 1, detailHor1);
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Vertical, 1, detailVert1);
            componentWithWatermark = Wavelet.SetCoefficient(componentWithWatermark, Wavelet.Coefficients.Diagonal, 1, detailDiag1);

        }

        private int EmbedInCoef(double constCoefficient, double[,] coefficients,  double treshold, Watermark watermark, int p)
        {
            for (int i = 0; i < coefficients.GetLength(0); i++)
            {
                if (p >= watermark.Length)
                    break;
                for (int j = 0; j < coefficients.GetLength(1); j++)
                {
                    if (p >= watermark.Length)
                        break;
                    if (coefficients[i, j] > treshold)
                    {
                        coefficients[i, j] = coefficients[i, j] + constCoefficient * coefficients[i, j] * watermark[p];
                        p++;
                    }                    
                }
            }
            return p;
        }

        public void KIMextract(DoubleImage initialImage, DoubleImage imageWithWatermark)
        {

        }

        private double[,] restoreMatrixFromCoef(double[,] approx3, double[,] detailHor3, double[,] detailVert3, double[,] detailDiag3,
                                                double[,] detailHor2, double[,] detailVert2, double[,] detailDiag2,
                                                double[,] detailHor1, double[,] detailVert1, double[,] detailDiag1,
                                                int width, int height)
        {
            double[,] resultMatrix = new double[height, width];

        }

        private Watermark TransformWatermark(Watermark watermark)
        {
            Watermark newWatermark = new Watermark(watermark.Length);
            for(int i=0; i<watermark.Length; i++)
            {
                if (watermark[i] == 0)
                    newWatermark[i] = -1;
                else newWatermark[i] = 1;
            }
            return newWatermark;
        }

    }

}
