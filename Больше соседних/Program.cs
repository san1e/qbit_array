using System;

namespace Больше_соседних
{
    internal class Program
    {
        static int Bigger(int[] num)
        {
            int count = 0;
            for (int i = 1; i < num.Length-1; i++)
            {
                if (num[i] > num[i - 1] && num[i] > num[i + 1])
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(Bigger(arr));

        }
    }
}
