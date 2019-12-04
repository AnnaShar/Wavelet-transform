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


        public void KIMembed()
        {

        }
        private int[] TransformWatermark(int[] watermark)
        {
            int[] newWatermark = new int[watermark.Length];
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
