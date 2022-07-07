using System;

namespace Week6NotesArrays
{
    class Program
    {
        static void Main()
        {
            ArrayDuplicateModify();
        }
        static void Array()
        {
            // Declare a single-dimensional array of 5 integers.
            int[] array1 = new int[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
        }
        static void ArrayAssign()
        {
            int[] count = new int[4];
            count[0] = 7;
            count[1] = count[0] * 2;
            count[2]++;
            count[3] -= 60;
            foreach (var item in count)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int[] arr = new int[4];
            arr = count;

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void ArrayDuplicateModify()
        {
            int[] count = new int[4];
            count[0] = 7;
            count[1] = count[0] * 2;
            count[2]++;
            count[3] -= 60;
            foreach (var item in count)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int[] arr = new int[count.Length];
            for (int i = 0; i < count.Length; i++)
            {
                arr[i] = count[i];
            }
            arr[0] = 1;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in count)
            {
                Console.WriteLine(item);
            }
        }
        static void RandomDouble() //Week6 Slides
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                double x = random.NextDouble();
                Console.WriteLine(x);
            }

        }
        public static void Main(string[] args)
        {
            WriteArray(RandomArray(10));
        }
        public static int[] RandomArray(int size)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }
        public static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }


    }
}
