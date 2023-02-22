using System;

namespace Количество_различных_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 1;
            Array.Sort(arr);
            for (int i = 1; i < N; i++)
            {
                if (arr[i] != arr[i-1])
                {
                    count++;
                }
            }
           
            Console.WriteLine(count);
        }
    }
}
