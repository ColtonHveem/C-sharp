using System;
class Program
{
    public static int[] Make(int n)
    {
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = i + 1;
        }
        return a;
    }
    public static void Dub(int[] jub)
    {
        for (int i = 0; i < jub.Length; i++)
        {
            jub[i] *= 2;
        }
    }
    public static int Mus(int[] zoo)
    {
        int fus = 0;
        foreach (int z in zoo)
        {
            fus += z;
        }
        return fus;
    }
    public static void Main(string[] args)
    {
        int[] bob = Make(5);
        Dub(bob);
        Console.WriteLine(Mus(bob));
        Console.WriteLine(30);
    }
}

/*
 1. Stack Below:
- Main
- int[] bob = Make(5)
- int[] a = new int[5]
- a[0] = 1
- a[1] = 2
- a[2] = 3
- a[3] = 4
- a[4] = 5
- return {1,2,3,4,5}
- bob = {1,2,3,4,5} 
- Dub(bob)
- bob[0] = 2
- bob[1] = 4
- bob[2] = 6
- bob[3] = 8
- bob[4] = 10
- Mus(bob)
- int fus = 0;
- fus = 2
- fus = 6
- fus = 12
- fus = 20
- fus = 30
- return 30
- Console.WriteLine(30)
*/