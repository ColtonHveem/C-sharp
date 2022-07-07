using System;
using System.Collections.Generic;
using System.Linq;

namespace EX_13._4
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
        public void WriteRational()
        {
            Console.WriteLine(($"{this.Numerator} / {this.Denominator}"));
        }
        public void Negate()
        {
            Console.WriteLine(($"-{this.Numerator} / {this.Denominator}"));
        }
        public void Invert()
        {
            Console.WriteLine(($"{this.Denominator} / {this.Numerator}"));
        }
        public double ToDouble()
        {
            double a = this.Numerator;
            double b = this.Denominator;
            double x = (a / b);
            return x;
        }
        public Rational Reduce()
        {
            int a = this.Numerator;
            int b = this.Denominator;

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

            Rational SimpleFract = new Rational(a / GCD, b / GCD);
            return SimpleFract;
        }
        public Rational Add(Rational f, Rational g)
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
            return sum.Reduce();
        }
        static void Main(String[] args)
        {
            Rational num1 = new Rational();
            num1.Numerator = 27;
            num1.Denominator = 12;
            Console.WriteLine("Rational Number 1:");
            num1.WriteRational();
            Console.WriteLine();

            Rational num2 = new Rational(12, 9);
            Console.WriteLine("Rational Number 2:");
            num2.WriteRational();
            Console.WriteLine();

            Console.WriteLine("Negation of Num1:");
            num1.Negate();
            Console.WriteLine();

            Console.WriteLine("Negation of Num2:");
            num2.Negate();
            Console.WriteLine();

            Console.WriteLine("Inversion of num1:");
            num1.Invert();
            Console.WriteLine();

            Console.WriteLine("Inversion of num1:");
            num2.Invert();
            Console.WriteLine();

            Console.WriteLine("Double of num1:");
            Console.WriteLine(num1.ToDouble());
            Console.WriteLine();

            Console.WriteLine("Double of num2:");
            Console.WriteLine(num2.ToDouble());
            Console.WriteLine();

            Console.WriteLine("Simplified Fraction of num1:");
            Rational Reducenum1 = new Rational();
            Reducenum1 = num1.Reduce();
            Reducenum1.WriteRational();
            Console.WriteLine();

            Console.WriteLine("Simplified Fraction of num2:");
            Rational Reducenum2 = new Rational();
            Reducenum2 = num2.Reduce();
            num2.WriteRational();
            Console.WriteLine();

            Console.WriteLine("Simplifed Sum of Fractions num1 and num2:");
            Rational Sum = new Rational();
            Sum = num1.Add(num1, num2);
            Sum.WriteRational();
        }
    }
}


/* Part 3:
 * Generally, I find instance methods to be more concise.
 * I find instance methods to generally by more efficient and cleaner to read for methods that require only one object to be passed through it.
 * However, if a method requires two objects (like my add method above) then calling the method doesn't look nearly as intuitive.
 * An instance method should be used if the object that invokes the method is not used to generate the output.
 */