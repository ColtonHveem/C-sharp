using System;

namespace Week3Notes
{
    class Program
    {
        static double MedianNumber(double x, double y, double z)
        {
            if ((y > x && x > z) || (y < x && x < z))
                return x;
            else if ((x > y && y > z) || (x < y && y < z))
                return y;
            else
                return z;

        }
        public static void Main()
        {
            double x, y, z;
            x = 3.2;
            y = 5.8;
            z = 4.5;
            Console.WriteLine(MedianNumber(x, y, z));
        }
    }
}
