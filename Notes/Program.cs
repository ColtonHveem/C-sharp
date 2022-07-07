using System;

namespace Week4Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteTable(6,12);
            Fact(5);
            Console.WriteLine(Factfor(5));
        }
        static void WriteTable(int length, int width)
        {
            int i = 1;
            while (i <= length)
            {
                int j = 1;
                while (j<= width)
                {
                    Console.Write(i * j + "\t");
                    j = j + 1;
                }
                Console.WriteLine("");
                i = i + 1;
            }
            Console.WriteLine(" ");
        }
        static void Fact(int n)
        {
            int total = 1;
            while (n>=1)
            {
                total = total * n;
                n = n - 1;
            }
            Console.WriteLine(total);
        }
        static int Factfor(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++) //for tab tab
            {
                factorial = factorial * i;
            }
            return factorial;
        }
        public static void Display()
        {
            string str = "abc";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
