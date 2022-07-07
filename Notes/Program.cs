using System;
class Program
{
    static void Main(string [] args) // always enter through Main first. Other lines are input into this code.
    {
        // arguments are decided in the black screen after the file name
        // pressing "tab, tab" after "cw" fills the rest of the function
        Console.WriteLine("Hello World!");
        ThreeLines();
        Console.Write("Hello World!\n");
    }
    static void NewLine()
    {
        Console.WriteLine("-------");
    }
    static void ThreeLines()
    {
        NewLine(); NewLine(); NewLine();
    }
}

