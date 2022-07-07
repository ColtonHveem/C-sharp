using System;

namespace Week3_Homework_4._5Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckFermat(2,3,4,5);
        }
        static void CheckFermat(int a, int b, int c, int n)
        {
            if (n > 2 && (Math.Pow(a,n) + Math.Pow(b,n) == Math.Pow(c,n))) 
                {
                Console.WriteLine("Holy smokes, Fermat was wrong");
                }
            else
            {
                Console.WriteLine("No that doesn't work.");
            }
        }
    }
}
