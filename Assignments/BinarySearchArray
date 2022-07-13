using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 2, 5, 8, 11, 13, 20 }; // a sorted array
        System.Console.WriteLine(Apple(arr, 6));
        System.Console.WriteLine(Apple(arr, 13));
        
    }
    static int Apple(int[] arr, int num)
    {
        int left = 0;
        int right = arr.Length - 1;
        int middle;
        while (left <= right)
        {
            middle = (left + right) / 2;
            if (num == arr[middle])
            {
                return ++middle;
            }
            else if (num < arr[middle])
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
}
