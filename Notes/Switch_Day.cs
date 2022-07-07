using System;

namespace Week3Notes
{
    class Program
    {
        public static void A(string[] args)
        {
            int day = 2;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        /*
        Chapter 5 - Value Method
        */
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(5));
            Console.WriteLine(Fibonacci2(5));
        }
        static double DiskArea(double r)
        {
            double area;
            area = Math.PI * r * r;
            return area;
        }
        public static double AbsoluteValue(double x)
        {
            if (x < 0)
            {
                return -x;
            }
            else if (x > 0)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }
        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            double dsquared = dx * dx + dy * dy;
            double result = Math.Sqrt(dsquared);
            return result;
        }
        public static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public static double Sum(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        public static double Sum(int a, double b)
        {
            return a + b;
        }
        public static bool IsSingleDigit(int x)
        {
            if (x >= 0 && x < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }
        public static double Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        public static double Fibonacci2(int n)
        {
            double n1, n2, x;
            int i;

            n1 = 1;
            n2 = 1;
            i = 0;
            
            while (i < n - 1)
            {
                x = n1 + n2;
                n1 = n2;
                n2 = x;
                i = i + 1;

            }
            return n2;
        }
    }
}
