using System;

namespace Ex_7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello ";
            char c = 'A';
            Console.WriteLine(s + c);
            Console.WriteLine((s + c).GetType());
            Console.WriteLine();
            Type();
        }
        static void Type()
        { 
            bool a = false;
            char b = 'b';
            int c = 4;
            string d = " String ";
            Console.WriteLine("\t\t\tIntersection Type Table");
            Console.WriteLine();
            Console.WriteLine("\t" + "bool\t\t\t" + "char\t\t\t" + "int\t\t\t" + "string");
            Console.WriteLine("bool\t" + "N.O\t\t\t" + "N.O\t\t\t" + "N.O\t\t\t" + "Concat-" + (a + d).GetType());
            Console.WriteLine("char\t" + "N.O\t\t\t" + "Add-" + (b + b).GetType() + "\t" + "Add-" + (b + c).GetType() +"\t" + "Concat-" + (b + d).GetType());
            Console.WriteLine("int\t" + "N.O\t\t\t" + "Add-" + (c + b).GetType() + "\t" + "Add-" + (c + c).GetType() + "\t" + "Concat-" + (c + d).GetType());
            Console.WriteLine("string\t" + "Concat-" + (d+a).GetType() + "\t" + "Concat-" + (d + b).GetType() + "\t" + "Concat-" + (d + c).GetType() + "\t" + "Concat-" + (d + d).GetType());
            Console.WriteLine();
            Console.WriteLine("N.O = Not Operable");
        }
    }
}
/*
 1. Adding a string and a char performs a concatenation. 
    In the above example, it produces "Hello A". 
    You can determine the type by GetType of the concatenation. 
    Then GetType of the var.

 2. Table included in method "Type"

 3. Concatenating a string with anything seems unavoidable for the result to be type string.
    Concatenating a char with char and the result being type int makes sense when we think back to the table converter for chars, but it is not entirely intuitive. I think it would also be reasonable to turn it into a string.
    Concatenating a bool with anything other than string is not operable. I would think it should not be operable for string too. The fact that it turns into a string seems problematic, because it loses the intention of the bool value.
    Concatenating a int with a char and it being an int makes sense with the same logic of char + char being an int.
 
 4. Whenever you try x = x + 1, it trys to convert an int to a char and fails. x++ works becuase it adds one char value.
    
*/