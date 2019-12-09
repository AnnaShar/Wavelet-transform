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
        //private DoubleImage.ColorComponent mainColorComponent = DoubleImage.ColorComponent.Red;
        private int p = 0;

        public DoubleImage KIMembed(DoubleImage image, Watermark initialWatermark)
        {
            DoubleImage result = KIMembedComponent(image, initialWatermark, DoubleImage.ColorComponent.Blue);
            if (p< initialWatermark.Length)
                result = KIMembedComponent(result, initialWatermark, DoubleImage.ColorComponent.Red);
            if (p < initialWatermark.Length)
                result = KIMembedComponent(result, initialWatermark, DoubleImage.ColorComponent.Green);
            p = 0;
            return result;
        }

        private DoubleImage KIMembedComponent(DoubleImage image, Watermark initialWatermark, DoubleImage.ColorComponent colorComponent)
        { 
            // Get blue component from image
            double[,] blueComponent = image.GetColorComponent(colorComponent); 

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

            // Get thresholds
            double threshold1 = Threshold.GetThreshold(detailHor1, detailVert1, detailDiag1);
            double threshold2 = Threshold.GetThreshold(detailHor2, detailVert2, detailDiag2);
            double threshold3 = Threshold.GetThreshold(detailHor3, detailVert3, detailDiag3, approx3);

            Watermark watermark = TransformWatermark(initialWatermark);

            // Embed watermark into coefficients
            //int p = 0;
            p = EmbedInCoef(coefApprox, ref approx3, threshold3, watermark, p);
            p = EmbedInCoef(coef3Level, ref detailHor3, threshold3, watermark, p);
            p = EmbedInCoef(coef3Level, ref detailVert3, threshold3, watermark, p);
            p = EmbedInCoef(coef3Level, ref detailDiag3, threshold3, watermark, p);

            p = EmbedInCoef(coef2Level, ref detailHor2, threshold2, watermark, p);
            p = EmbedInCoef(coef2Level, ref detailVert2, threshold2, watermark, p);
            p = EmbedInCoef(coef2Level, ref detailDiag2, threshold2, watermark, p);

            p = EmbedInCoef(coef1Level, ref detailHor1, threshold1, watermark, p);
            p = EmbedInCoef(coef1Level, ref detailVert1, threshold1, watermark, p);
            p = EmbedInCoef(coef1Level, ref detailDiag1, threshold1, watermark, p);

            Console.WriteLine("watermark length {0}", watermark.Length);
            Console.WriteLine("p {0}", p);

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

            double[,] untrasformedComponent = Wavelet.Untransfrom(componentWithWatermark, 3);

            // Embed blue component into initial image
            image = image.UpdateColorComponent(colorComponent, untrasformedComponent); 

            return image;
        }

        private int EmbedInCoef(double constCoefficient,ref double[,] coefficients,  double treshold, Watermark watermark, int p)
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
                        double coefficien = coefficients[i, j];
                        coefficients[i, j] = coefficients[i, j] + constCoefficient * coefficients[i, j] * watermark[p];
                        p++;
                    }                    
                }
            }
            return p;
        }

        public DoubleImage KIMextract(DoubleImage initialImage, DoubleImage changedImage, int widthWatermark, int heigthWatermark)
        {
            Watermark watermark = KIMextractComponent(initialImage, changedImage, widthWatermark, heigthWatermark, DoubleImage.ColorComponent.Blue);
            if (p < widthWatermark * heigthWatermark)
            {
                int startIndex = p;
                watermark = watermark.Append(KIMextractComponent(initialImage, changedImage, widthWatermark, heigthWatermark, DoubleImage.ColorComponent.Red), startIndex);
                //watermark = KIMextractComponent(initialImage, changedImage, widthWatermark, heigthWatermark, DoubleImage.ColorComponent.Red);
            }                
            if (p < widthWatermark * heigthWatermark)
            {
                int startIndex = p;
                watermark = watermark.Append(KIMextractComponent(initialImage, changedImage, widthWatermark, heigthWatermark, DoubleImage.ColorComponent.Green), startIndex);
            }
            p = 0;
            return watermark.ToDoubleImage(widthWatermark, heigthWatermark);
        }
        private Watermark KIMextractComponent(DoubleImage initialImage, DoubleImage changedImage, int widthWatermark, int heigthWatermark, DoubleImage.ColorComponent colorComponent)
        {
            // Get blue component from changed image
            double[,] blueComponentChanged = changedImage.GetColorComponent(colorComponent); 

            // Transfrom blue component of changed image with wavelet transformation
            double[,] waveletTransformedChangedComponent = Wavelet.Transform(blueComponentChanged, 3);

            // Get coefficients of transformation
            double[,] approx3 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Approximation, 3);
            double[,] detailHor3 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Horizontal, 3);
            double[,] detailVert3 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Vertical, 3);
            double[,] detailDiag3 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Diagonal, 3);

            double[,] detailHor2 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Horizontal, 2);
            double[,] detailVert2 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Vertical, 2);
            double[,] detailDiag2 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Diagonal, 2);

            double[,] detailHor1 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Horizontal, 1);
            double[,] detailVert1 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Vertical, 1);
            double[,] detailDiag1 = Wavelet.GetCoefficient(waveletTransformedChangedComponent, Wavelet.Coefficients.Diagonal, 1);


            // Get blue component from initial image
            double[,] blueComponentInitial = initialImage.GetColorComponent(colorComponent); 

            // Transfrom blue component of initial image with wavelet transformation
            double[,] waveletTransformedComponent = Wavelet.Transform(blueComponentInitial, 3);

            // Get coefficients of transformation
            double[,] approx3Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Approximation, 3);
            double[,] detailHor3Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Horizontal, 3);
            double[,] detailVert3Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Vertical, 3);
            double[,] detailDiag3Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Diagonal, 3);

            double[,] detailHor2Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Horizontal, 2);
            double[,] detailVert2Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Vertical, 2);
            double[,] detailDiag2Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Diagonal, 2);

            double[,] detailHor1Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Horizontal, 1);
            double[,] detailVert1Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Vertical, 1);
            double[,] detailDiag1Initial = Wavelet.GetCoefficient(waveletTransformedComponent, Wavelet.Coefficients.Diagonal, 1);

            // Get thresholds from initial image
            double threshold1 = Threshold.GetThreshold(detailHor1Initial, detailVert1Initial, detailDiag1Initial);
            double threshold2 = Threshold.GetThreshold(detailHor2Initial, detailVert2Initial, detailDiag2Initial);
            double threshold3 = Threshold.GetThreshold(detailHor3Initial, detailVert3Initial, detailDiag3Initial, approx3Initial);

            int watermarkSize = widthWatermark * heigthWatermark;
            Watermark watermark = new Watermark(watermarkSize);

            // Extract watermark from coefficients
            //int p = 0;
            p = ExtractFromCoef(coefApprox, approx3Initial, approx3, threshold3, p, watermarkSize, ref watermark);
            p = ExtractFromCoef(coef3Level, detailHor3Initial, detailHor3, threshold3, p, watermarkSize, ref watermark);
            p = ExtractFromCoef(coef3Level, detailVert3Initial, detailVert3, threshold3, p, watermarkSize, ref watermark);
            p = ExtractFromCoef(coef3Level, detailDiag3Initial, detailDiag3, threshold3, p, watermarkSize, ref watermark);

            p = ExtractFromCoef(coef2Level, detailHor2Initial, detailHor2, threshold2, p, watermarkSize, ref watermark);
            p = ExtractFromCoef(coef2Level, detailVert2Initial, detailVert2, threshold2, p, watermarkSize, ref watermark);
            p = ExtractFromCoef(coef2Level, detailDiag2Initial, detailDiag2, threshold2, p, watermarkSize, ref watermark);

            p = ExtractFromCoef(coef1Level, detailHor1Initial, detailHor1, threshold1, p, watermarkSize, ref watermark);
            p = ExtractFromCoef(coef1Level, detailVert1Initial, detailVert1, threshold1, p, watermarkSize, ref watermark);
            p = ExtractFromCoef(coef1Level, detailDiag1Initial, detailDiag1, threshold1, p, watermarkSize, ref watermark);

            watermark = UnTransformWatermark(watermark);
            return watermark;
            //DoubleImage watermarkImage = watermark.ToDoubleImage(widthWatermark, heigthWatermark);
            //return watermarkImage;
        }

        private int ExtractFromCoef(double constCoefficient, double[,] initialCoefficients, double[,] changedCoefficients, double treshold, int p, int watermarkSize, ref Watermark watermark)
        {
            
            for (int i = 0; i < initialCoefficients.GetLength(0); i++)
            {
                if (p >= watermarkSize)
                    break;
                for (int j = 0; j < initialCoefficients.GetLength(1); j++)
                {
                    if (p >= watermarkSize)
                        break;
                    if (initialCoefficients[i, j] > treshold)
                    {
                        double initial = initialCoefficients[i, j];
                        double changed = changedCoefficients[i, j];
                        int watermarkBit = Convert.ToInt32(Math.Round((changed - initial) / (constCoefficient * initial)));
                        watermark[p] = watermarkBit;
                        p++;
                    }
                }
            }
            return p;
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

        private Watermark UnTransformWatermark(Watermark watermark)
        {
            Watermark newWatermark = new Watermark(watermark.Length);
            for (int i = 0; i < watermark.Length; i++)
            {
                if (watermark[i] == -1)
                    newWatermark[i] = 0;
                else newWatermark[i] = 1;
            }
            return newWatermark;
        }
    }

}
