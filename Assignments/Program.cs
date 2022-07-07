using System;
namespace ThinkSharp
{
    public class MysteryClass
    {
        public static string Mystery(string s)
        {
            int i = s.Length - 1;
            string total = "";
            while (i >= 0)
            {
                char ch = s[i];
                Console.WriteLine(i + " " + ch);
                total = total + ch;
                i--;
            }
            return total;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Mystery("Allen"));
        }
    }
}

/*
The output of this program is:
4 n
3 e
2 l
1 l
0 A
nellA

Mystrey indexs the letters of string s, adds each index item backwards to a new string total, so that total will be the reverse of s. 