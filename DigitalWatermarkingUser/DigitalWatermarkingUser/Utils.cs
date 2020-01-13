using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWatermarkingUser
{
    class Utils
    {
        public static int MaxSquaredNumber(int number)
        {
            double root = Math.Sqrt(number);
            return (int)root;
        }
    }
}
