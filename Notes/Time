using System;

namespace Week5Notes2
{
    class Program
    {
        static void Main()
        {
            AddConsecutive();
            estuff();
            Plus();
            Time t = new Time();
            t.hour = 11;
            t.minute = 45;
            t.second = 22;
            Console.WriteLine($"{t.hour}:{t.minute}:{t.second}");

            Book book1 = new Book();
            Console.WriteLine(book1.price);
        }
        static void AddConsecutive()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
        static void estuff()
        {
            int i = 0;
            double e = 0;
            while (i < 10)
            {
                e += 1.0 / F(i);
                i++;
            }
            Console.WriteLine(Math.E - e); // Eulers - 1 / factorial of e
        }
        public static long F(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            long product = 1;
            for (int i = 1; i <= n; i ++)
            {
                product *= i;
            }
            return product;
        }
        public static void Plus()
        {
            int i = 3;
            Console.WriteLine(i);
            Console.WriteLine(i++); //adding for the next iteration
            Console.WriteLine(i);
            double a = 1.5;
            Console.WriteLine(a);
            Console.WriteLine(++a); //adding for this iteration
            Console.WriteLine(a);
        }
    }
    public class Time
    {
        public int hour, minute;
        public double second;

        public Time()
        {
            this.hour = 0;
            this.minute = 0;
            this.second = 0.0;
        }
        public Time(int h, int m, double s)
        {
            h = 0;
            m = 0;
            s = 0; 
        }
    }
    public class Book
    {
        public string title;
        public string isbn;
        public double price;

        public Book()
        {
            title = ""; isbn =""; price = 9.0;
        }
    }
}
