using System;
namespace ThinkSharp
{
    public class Program
    {
        public static void NewLine()
        {
            Console.WriteLine("");
        }

        public static void ThreeLine()
        {
            NewLine(); NewLine(); NewLine();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("First line.");
            ThreeLine();
            Console.WriteLine("Second line.");
            string s = "hello";
            WriteTwice(s);
            string w = "Return";
            WriteReturn(w);
            int x, y;
            Console.WriteLine("Enter the first integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of {x} and {y} is {Sum(x, y)}"); //$tells console to execute sum
        }
        public static void WriteTwice(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine(str);
        }
        public static string WriteReturn(string ws)
        {
            return ws + " " + ws;
        }
        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}

