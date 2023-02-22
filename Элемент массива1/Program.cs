using System;

namespace Элемент_массива1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] num = Console.ReadLine().Trim().Split(' ');
            int f = int.Parse(num[0]);
            int k = int.Parse(num[1]);
            int index = k - f;
            if (index >= 0 && index < arr.Length)
            {
                Console.WriteLine(arr[index]);
            }
            else
            {
                Console.WriteLine("Error");
            }


        }
    }
}

