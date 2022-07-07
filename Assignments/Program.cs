using System;
using System.Collections.Generic;

namespace Ex_7._4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Count("((3 + 7) * 2)"));
            Console.WriteLine(Count("((((((((((3 + 7) * 2)"));
            Console.WriteLine(Count("((3 + 7) * 2)))))))"));
            CountAllBracketTypes("{{{[[(())]}");
        }
        static int Count(string s)
        {
            int len = s.Length;
            int i = 0;
            int count = 0;
            while (i < len)
            {
                char c = s[i];
                if (c == '(')
                {
                    count = count + 1;
                }
                else if (c == ')')
                {
                    count = count - 1;
                }
                i = i + 1;
            }
            return count;
        }
        static void CountAllBracketTypes(string s)
        {
            int len = s.Length;
            int i = 0;
            int countparenthesis = 0;
            int countbrackets = 0;
            int countcurly = 0;
            while (i < len)
            {
                char c = s[i];
                if (c == '(')
                {
                    countparenthesis = countparenthesis + 1;
                }
                if (c == ')')
                {
                    countparenthesis = countparenthesis - 1;
                }
                if (c == '[')
                {
                    countbrackets = countbrackets + 1;
                }
                if (c == ']')
                {
                    countbrackets = countbrackets - 1;
                }
                if (c == '{')
                {
                    countcurly = countcurly + 1;
                }
                if (c == '}')
                {
                    countcurly = countcurly - 1;
                }
                i = i + 1;
            }
           //List<int> ListofBracketTypes = new List<int> { countparenthesis, countbrackets, countcurly };
            Console.WriteLine("Parenthesis Difference: " + countparenthesis);
            Console.WriteLine("Bracket Difference: " + countbrackets);
            Console.WriteLine("Curly Bracket Differnece: " + countcurly);
        }
    }
}

/*
 1. The code above uses the method count, taking any string and returning the value of count.

 2. The code produces the difference of open parentheses "("  versus closed parentheses ")" within string s.
    If the total number of "(" is equal to the total number of ")", then the difference returned is 0.
    If there are more "(" than ")", the difference returned is a postivie number which is total "(" minus total ")".
    If there are less "(" than ")", the difference returned is a negative number which is total "(" minus total ")".

 3. The method "CountAllBracketTypes" checks to make sure there is equal amount of all bracket types.
*/
