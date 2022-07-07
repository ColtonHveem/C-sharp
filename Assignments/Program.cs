using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Multadd(1.0, 2.0, 3.0, Math.Sin(Math.PI / 4), Math.Cos((Math.PI / 4) / 2), Math.Log(10), Math.Log(20));
            Yikes(1, 1);
        }
        static void Multadd(double a, double b, double c, double d, double e, double f, double g)
        {
            double x;
            x = a * b + c;
            if (x != 0)
            {
                Console.WriteLine(x);
            }
            if (d != 0 && e != 0) 
            {
                Console.WriteLine(d + e);
            }
            if (f != 0 && g != 0)
            {
                Console.WriteLine(f + g);
            }
        }
        static void Yikes(double e, double x)
        {
            Multadd(0.0, 0.0, 0.0, 0.0, 0.0, x * Math.Exp(-x), Math.Sqrt(1 - Math.Exp(-x)));
        }
    }
}