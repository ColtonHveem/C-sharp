using System;
class Program
{
    static void Main(string[] args)
    {
        string str = "Abc-xyz";
        Console.WriteLine(str);
        Console.WriteLine(Fruit(str, 2));
    }
    public static string Fruit(string s, int n)
    {
        string str = "";
        for (int i = 0; i < s.Length; i++)
        {
            int a = (int)s[i];
            if (s[i] >= 'A' && s[i] <= 'Z')
            {
                a = (a + n - 65) % 26 + 65;
            }
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                a = (a + n - 97) % 26 + 97;
            }
            str += (char)a;
        }
        return str;
    }
}
