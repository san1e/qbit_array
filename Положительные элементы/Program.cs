using System;

namespace Положительные_элементы
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > 0 )
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
