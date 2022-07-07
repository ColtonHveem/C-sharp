using System;

namespace EX_7._10
{
    class Program
    {
        static void Main(string[] args)
        {
            IsAbecedarian("adipsy");
            IsAbecedarian("footballabcz");
            IsAbecedarian("z1");
        }
        static void IsAbecedarian(string s)
        {
            s = s.ToLower();
            char c = 'a';
            string result = $"{s} is an Abecedarian";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] < c)
                {
                    result = $"{s} is not an Abecedarian";
                    break;
                }
                c = s[i];
            }
            Console.WriteLine(result);
        }
    }
}

/*
 1. The process to check for an Abecedariam requires comparing each letter to its previous. 
    I used a for loop to check for each iteration in string s, comparing the new iteration to the previous char c, giving char c an orignal value of "a".
    If char c is ever greater than the next iteration of the string s[i], than string s is not an Abecedarian.
    If char c is always less than s[i] through the entire length of string s, then string s is an Abecedarian.

 2. The method IsAbecedarian is written above.
*/