using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace waveletTransformer
{
    public static class useWavelet
    {
        //Читаем коэффициенты вейвлета из файла
        public static double[] readWavelet(System.IO.FileStream fileS)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(fileS);
            double[] c_low;
            int waveletOrder = Convert.ToInt32(file.ReadLine());
            c_low = new double[waveletOrder];
            for (int i = 0; i < waveletOrder; i++)
                c_low[i] = Convert.ToDouble(file.ReadLine());
            return c_low;
        }

        //Применяем преобразование
        public static DoubleImage waveletTransform(DoubleImage initialImage, double[] c_low)
        {
            int waveletOrder = c_low.Length;
            double[] c_high = new double[waveletOrder];
            int W = initialImage.Width;
            int H = initialImage.Height;
            DoubleImage middleImage = new DoubleImage(W, H);
            DoubleImage resultImage = new DoubleImage(W, H);
            for (int i = 0; i < waveletOrder; i++)
            {
                c_high[i] = c_low[waveletOrder - 1 - i];
                if (i % 2 == 0) c_high[i] *= -1;
            }

            for (int i = 0; i < W / 2; i++) //По строкам
                for (int j = 0; j < H; j++)
                {
                    double R = 0, G = 0, B = 0;
                    //Умножение на столбец матрицы коэфициентов двух значений строки
                    for (int d = 0; d < waveletOrder; d++)
                    {
                        R += c_low[d] * initialImage.GetPixel((i * 2 + d) % W, j).Red;
                        G += c_low[d] * initialImage.GetPixel((i * 2 + d) % W, j).Green;
                        B += c_low[d] * initialImage.GetPixel((i * 2 + d) % W, j).Blue;
                    }
                    middleImage.SetPixel(i, j, R, G, B); //Низкочастотная компонента
                    R = 0;
                    G = 0;
                    B = 0;
                    for (int d = 0; d < waveletOrder; d++)
                    {
                        R += c_high[d] * initialImage.GetPixel((i * 2 + d) % W, j).Red;
                        G += c_high[d] * initialImage.GetPixel((i * 2 + d) % W, j).Green;
                        B += c_high[d] * initialImage.GetPixel((i * 2 + d) % W, j).Blue;
                    }
                    middleImage.SetPixel(W / 2 + i, j, R, G, B);  //Высокочастотная компонента
            }
            for (int i = 0; i < W; i++) //По столбцам
                for (int j = 0; j < H / 2; j++)
                {
                    double R = 0, G = 0, B = 0;
                    for (int d = 0; d < waveletOrder; d++)
                    {
                        R += c_low[d] * middleImage.GetPixel(i, (j * 2 + d) % H).Red;
                        G += c_low[d] * middleImage.GetPixel(i, (j * 2 + d) % H).Green;
                        B += c_low[d] * middleImage.GetPixel(i, (j * 2 + d) % H).Blue;
                    }
                    resultImage.SetPixel(i, j, R, G, B); //Низкочастотная компонента
                    R = 0;
                    G = 0;
                    B = 0;
                    for (int d = 0; d < waveletOrder; d++)
                    {
                        R += c_high[d] * middleImage.GetPixel(i, (j * 2 + d) % H).Red;
                        G += c_high[d] * middleImage.GetPixel(i, (j * 2 + d) % H).Green;
                        B += c_high[d] * middleImage.GetPixel(i, (j * 2 + d) % H).Blue;
                    }
                    resultImage.SetPixel(i, H / 2 + j, R, G, B); //Высокочастотная компонента
                }
            return resultImage;
        }
    }
}
