using System;

namespace Генерация_массива
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int[] arr = new int[10];
            arr[0] = x;
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = (arr[i - 1] * arr[i - 1] % 100) - (5 * arr[i - 1]) + 6;
            }
         
            Console.Write(string.Join(" ", arr));
        }
    }
}
