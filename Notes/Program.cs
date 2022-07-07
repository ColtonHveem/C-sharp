using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadWrite

{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();

            using (StreamWriter sw = new StreamWriter("target.txt"))
            {
                int lineN = 0;
                foreach (DirectoryInfo dir in cDirs)
                {
                    lineN++;
                    sw.WriteLine($"Line {lineN} : {dir.Name}");
                }
            }

            int linek = 0;
            string lines = "";
            using (StreamReader sr = new StreamReader("source.txt"))
            {
                while ((lines = sr.ReadLine()) != null)
                {
                    linek++;
                    Console.WriteLine($"Line {linek} : {lines}");
                }
            }
        }
    }
}