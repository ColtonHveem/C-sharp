using System;
class CSC205Quiz03
{
    static void Distance(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        double d = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
        Console.WriteLine(d);

    }
    public static void Main()
    {
        Distance(1,2,3,4,5,6);
    }
}