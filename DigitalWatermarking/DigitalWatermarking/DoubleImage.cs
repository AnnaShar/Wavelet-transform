using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace DigitalWatermarking
{
    public class DoubleImage
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public enum ColorComponent 
        {
            Red,
            Green,
            Blue
        }

        private DoublePixel[,] _pixels; 

        public DoubleImage(int width, int height) 
        {
            Width = width;
            Height = height;
            _pixels = new DoublePixel[Width, Height];
            for (int i = 0; i < Width; i++)
                for (int j = 0; j < Height; j++)
                    _pixels[i, j] = new DoublePixel();
        }

        public DoubleImage(Bitmap BMImage) 
        {
            Width = BMImage.Width;
            Height = BMImage.Height;
            _pixels = new DoublePixel[Height, Width];
            for (int i = 0 ; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    Color c = BMImage.GetPixel(j, i);
                    _pixels[i, j] = new DoublePixel(c.R, c.G, c.B);
                }
        }

        public DoublePixel GetPixel (int i, int j) 
        {
            return _pixels[i,j];
        }

        public void SetPixel(int i, int j, double r, double g, double b) 
        {
            _pixels[i, j].SetColor(r, g, b);
        }

        public double[,] GetColorComponent(ColorComponent component) 
        {
            double[,] colorComponent = new double[this.Height, this.Width];
            switch (component)
            {
                case ColorComponent.Red:
                    for (int i = 0; i < this.Height; i++)
                        for (int j = 0; j < this.Width; j++)
                            colorComponent[i, j] = this._pixels[i, j].Red;
                    break;

                case ColorComponent.Green:
                    for (int i = 0; i < this.Height; i++)
                        for (int j = 0; j < this.Width; j++)
                            colorComponent[i, j] = this._pixels[i, j].Green;
                    break;

                case ColorComponent.Blue:
                    for (int i = 0; i < this.Height; i++)
                        for (int j = 0; j < this.Width; j++)
                            colorComponent[i, j] = this._pixels[i, j].Blue;
                    break;
            }
            return colorComponent;
        }

        public DoubleImage UpdateColorComponent(ColorComponent component, double[,] colorComponent)
        {
            DoubleImage updatedImage = this;
            switch (component)
            {
                case ColorComponent.Red:
                    for (int i = 0; i < this.Height; i++)
                    {
                        for (int j = 0; j < this.Width; j++)
                        {
                            DoublePixel initialPixel = this.GetPixel(i, j);
                            updatedImage.SetPixel(i, j, colorComponent[i, j], initialPixel.Green, initialPixel.Blue);
                        }
                    }
                    break;

                case ColorComponent.Green:
                    for (int i = 0; i < this.Height; i++)
                    {
                        for (int j = 0; j < this.Width; j++)
                        {
                            DoublePixel initialPixel = this.GetPixel(i, j);
                            updatedImage.SetPixel(i, j, initialPixel.Red, colorComponent[i, j], initialPixel.Blue);
                        }
                    }
                    break;

                case ColorComponent.Blue:
                    for (int i = 0; i < this.Height; i++)
                    {
                        for (int j = 0; j < this.Width; j++)
                        {
                            DoublePixel initialPixel = this.GetPixel(i, j);
                            updatedImage.SetPixel(i, j, initialPixel.Red, initialPixel.Green, colorComponent[i, j]);
                        }
                    }
                    break;
            }
            return updatedImage;
        }

        public Bitmap ToBitmap(double colorMult, double colorShift) 
        {
            Bitmap BMImage = new Bitmap(Width, Height);
            for (int i = 0; i < BMImage.Width; i++)
                for (int j = 0; j < BMImage.Height; j++)
                {
                    DoublePixel P = new DoublePixel(_pixels[j, i]);
                    P.Red = P.Red * colorMult + colorShift;
                    P.Green = P.Green * colorMult + colorShift;
                    P.Blue = P.Blue * colorMult + colorShift;
                    BMImage.SetPixel(i, j, P.ToNormalColor());
                }
            return BMImage;
        }

    }
}