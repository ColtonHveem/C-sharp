using System;
using System.Collections.Generic;
using System.Linq;

namespace EX9._3
{
    public class Rational
    {
        public int Numerator, Denominator;
        public Rational()
        {
            // Default Constructor
            this.Numerator = 0;
            this.Denominator = 1;
        }
        public Rational(int x, int y)
        {
            //Parametric Constructor
            this.Numerator = x;
            this.Denominator = y;
        }
        public static void WriteRational(Rational a)
        {
            Console.WriteLine(($"{a.Numerator} / {a.Denominator}"));
        }
        public static void Negate(Rational b)
        {
            Console.WriteLine(($"-{b.Numerator} / {b.Denominator}"));
        }
        public static void Invert(Rational c)
        {
            Console.WriteLine(($"{c.Denominator} / {c.Numerator}"));
        }
        public static double ToDouble(Rational d)
        {
            double a = d.Numerator;
            double b = d.Denominator;
            double x = (a / b);
            return x;
        }
        public static Rational Reduce(Rational e)
        {
            int a = e.Numerator;
            int b = e.Denominator;

            List<int> x = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if (Math.Abs(a) % i == 0)
                {
                    
                    x.Add(i);
                }
            }

            /*foreach (int i in x)
            {
                Console.WriteLine(i);
            }*/

            List<int> y = new List<int>();
            for (int i = 1; i <= b; i++)
            {
                if (Math.Abs(b) % i == 0)
                {

                    y.Add(i);
                }
            }

            /*foreach (int i in y)
            {
                Console.WriteLine(i);
            }*/

            List<int> z = new List<int>();
            foreach (int i in x)
            {
                if (y.Contains(i))
                    {
                    z.Add(i);
                    }
            }
            /*foreach (int i in z)
            {
                Console.WriteLine(i);
            }*/

            int GCD = z[z.Count - 1];

            //Console.WriteLine("GCD: " + GCD);
            //return GCD2;
            //Console.WriteLine($"Simplified Fraction: {a / GCD} / {b / GCD}");
            
            Rational SimpleFract = new Rational(a/GCD, b/GCD);
            return SimpleFract;
        }
        public static Rational Add(Rational f, Rational g)
        {

            int a = f.Numerator;
            int b = f.Denominator;
            int c = g.Numerator;
            int d = g.Denominator;

            int x = b * d;
            int y = a * (x / b);
            int z = c * (x / d);

            //string sum = $"{y + z} / {x}";
            //Console.WriteLine(sum);

            Rational sum = new Rational((y + z), x);
            return Reduce(sum);
        }
        static void Main(String[] args)
        {
            Rational num1 = new Rational();
            num1.Numerator = 27;
            num1.Denominator = 12;
            Console.WriteLine("Rational Number 1:");
            WriteRational(num1);
            Console.WriteLine();

            Rational num2 = new Rational(12, 9);
            Console.WriteLine("Rational Number 2:");
            WriteRational(num2);
            Console.WriteLine();

            Console.WriteLine("Negation of Num1:");
            Negate(num1);
            Console.WriteLine();

            Console.WriteLine("Negation of Num2:");
            Negate(num2);
            Console.WriteLine();

            Console.WriteLine("Inversion of num1:");
            Invert(num1);
            Console.WriteLine();

            Console.WriteLine("Inversion of num1:");
            Invert(num2);
            Console.WriteLine();

            Console.WriteLine("Double of num1:");
            Console.WriteLine(ToDouble(num1));
            Console.WriteLine();

            Console.WriteLine("Double of num2:");
            Console.WriteLine(ToDouble(num2));
            Console.WriteLine();

            Console.WriteLine("Simplified Fraction of num1:");
            WriteRational(Reduce(num1));
            Console.WriteLine();

            Console.WriteLine("Simplified Fraction of num2:");
            WriteRational(Reduce(num2));
            Console.WriteLine();

            Console.WriteLine("Simplifed Sum of Fractions num1 and num2:");
            WriteRational(Add(num1, num2));
        }
    }
}
