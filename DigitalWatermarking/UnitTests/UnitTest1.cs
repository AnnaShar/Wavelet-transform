using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using DigitalWatermarking;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void ReadFromFile() {
            
            double[,] matrix;

            using (StreamReader str = new StreamReader("test1.txt"))
            {
                string parameters = str.ReadLine();

                string[] parameterNumbers = parameters.Split(' ');
                int height = Convert.ToInt32(parameterNumbers[0]);
                int width = Convert.ToInt32(parameterNumbers[1]);

                matrix = new double[height, width];
                for (int i = 0; i < height; i++)
                {
                    var line = str.ReadLine();
                    string[] numbers = line.Split(' ');
                    for (int j = 0; j < numbers.Length; j++)
                        matrix[i, j] = Convert.ToInt32(numbers[j]);
                }

            }
        }
        [TestMethod]
        public void TestMethod1()
        {
            
        }
    }
}
