using System;

namespace Quiz5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsDoubloon("Abba"));
            Console.WriteLine(IsDoubloon("abBa"));
            Console.WriteLine(IsDoubloon("Caucasus"));
            Console.WriteLine(IsDoubloon("Emmett"));
            Console.WriteLine(IsDoubloon("arraigning"));
        }
        static bool IsDoubloon(string s)
        {
            s = s.ToLower();
            int count = 0;
            foreach (char c in s)
            {
                foreach(char d in s)
                {  
                    if (c == d)
                    {
                        count = count + 1;
                    }
                    
                }
                if (count != 2)
                {
                    return false;
                }
                count = 0;
            }
            return true;
        }
    }
}
