using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DigitalWatermarking
{
    public class DoublePixel
    {
        public double Red { get; set; }
        public double Green { get; set; }
        public double Blue { get; set; }

        public DoublePixel()
        {
            Red = 0;
            Green = 0;
            Blue = 0;
        }

        public DoublePixel(DoublePixel p)
        {
            Red = p.Red;
            Green = p.Green;
            Blue = p.Blue;
        }

        public DoublePixel(double new_red, double new_green, double new_blue)
        {
            SetColor(new_red, new_green, new_blue);
        }

        public void SetColor (double new_red, double new_green, double new_blue)
        {
            Red = new_red;
            Green = new_green;
            Blue = new_blue;
        }

        public Color ToNormalColor()
        {
            int normalRed = (int)Red, normal_green = (int)Green, normal_blue = (int)Blue;
            if (normalRed > 255) normalRed = 255;
            if (normal_green > 255) normal_green = 255;
            if (normal_blue > 255) normal_blue = 255;
            if (normalRed < 0) normalRed = 0;
            if (normal_green < 0) normal_green = 0;
            if (normal_blue < 0) normal_blue = 0;
            return Color.FromArgb(normalRed, normal_green, normal_blue);
        }
    }
}