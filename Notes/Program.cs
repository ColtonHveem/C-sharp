using System;

namespace Recurse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(First("Colton Hveem"));
            Console.WriteLine(Rest("Hello"));
            Console.WriteLine(Length("My name"));
            ReverseString("Today is Friday");
        }
        // first: returns the first character of the given string
        public static char First(string s)
        {
            return s[0];
        }
        // rest: returns a new string that contains all but the
        // first letter of the given string
        public static string Rest(string s)
        {
            return s.Substring(1);
        }
        // length: returns the length of the given string
        public static int Length(string s)
        {
            return s.Length;
        }
        public static void WriteString(string s)
        {
            foreach (char x in s)
                {
                Console.WriteLine(x);
                }
        }
        public static void ReverseString(string s)
        {
            string sreverse = string.Empty;
            for (int i = s.Length -1; i >=0; i = i - 1)
            {
                sreverse = sreverse + s[i];
            }
            foreach (char x in sreverse)
            {
                Console.WriteLine(x);
            }
        }
    }
}
