using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr2 = Console.ReadLine().Trim().Split();
            int x = int.Parse(arr2[0]);
            int y = int.Parse(arr2[1]);
            int[] arr = new int[10];
            arr[0] = x;
            arr[1] = y;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }
            Array.Reverse(arr);
            string str = String.Join(" ", arr);
            Console.WriteLine(str);
        }
    }
}
