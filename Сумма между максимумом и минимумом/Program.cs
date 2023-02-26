using System;
using System.Linq;

namespace Сумма_между_максимумом_и_минимумом
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int minIndex = Array.IndexOf(arr, arr.Min());
            int maxIndex = Array.LastIndexOf(arr, arr.Max());
            int sum = 0;
            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);
            for (int i = start; i <= end; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
