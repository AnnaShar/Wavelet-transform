using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;

namespace waveletTransformer
{
    public class DoubleImage
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

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
            _pixels = new DoublePixel[Width, Height];
            for (int i = 0 ; i < Width; i++)
                for (int j = 0; j < Height; j++)
                {
                    Color c = BMImage.GetPixel(i,j);
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

        public Bitmap ToBitmap(double colorMult, double colorShift) 
        {
            Bitmap BMImage = new Bitmap(Width, Height);
            for (int i = 0; i < BMImage.Width; i++)
                for (int j = 0; j < BMImage.Height; j++)
                {
                    DoublePixel P = new DoublePixel(_pixels[i, j]);
                    P.Red = P.Red * colorMult + colorShift;
                    P.Green = P.Green * colorMult + colorShift;
                    P.Blue = P.Blue * colorMult + colorShift;
                    BMImage.SetPixel(i, j, P.ToNormalColor());
                }
            return BMImage;
        }

        //TODO move to another class
        public void Save(string filename)
        {
            if (File.Exists(filename))
                File.Delete(filename);
            FileStream fs = File.Create(filename);   
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(Width);
            sw.Write(" ");
            sw.WriteLine(Height);
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                {
                    sw.Write(_pixels[i,j].Red);
                    sw.Write(" ");
                    sw.Write(_pixels[i,j].Green);
                    sw.Write(" ");
                    sw.WriteLine(_pixels[i,j].Blue);
                }
            sw.Close();
            fs.Close();
        }
    }
}