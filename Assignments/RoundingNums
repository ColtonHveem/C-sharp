using System;

namespace Ex_6._2
{
    class Program
    {
        
        static void Original(string[] args)
        {
            double count = 0.0;
            while (count != 1)
            {
                count = count + 0.1;
                Console.Write("{0:R}",count);
                Console.ReadLine(); 
            }
        }
        /* The reason this does not stop when count reaches 1.0 is because the double of count does not ever equal 1.0 exactly. 
        Instead, it equals an extended decimal point that is very close to 1.0. Since it never equals 1.0, the while loop just continues printing.
        */
        static void Main(string[] args)
        {
            Counting();
        }
        static void Counting()
        {
            double count = 0.0;
            while (count != 1)
            {
                count = count + 0.1;
                count = Math.Round(count, 1);
                Console.Write("{0:R}", count);
                Console.ReadLine();
            }
        }
        /* The reason why this works is that I set count equal to count rounded to the first decimal place before running the while loop again.
        Eventually, the rounded count will equal 1, discountinuing the loop.
        */
    }
}
