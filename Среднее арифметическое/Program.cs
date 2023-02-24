using System;

namespace Среднее_арифметическое
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = new int[N];
            double sum = 0;
            double count = 0;
            for (int i = 0; i < N; i++)
            {
                arr[i] = input[i];
                if ((i+1) % 2 == 0 && arr[i] % 2 != 0)
                {
                    sum+= arr[i];
                    count++;
                }
            }
            if (count > 0)
            {
                double aver = sum / count;

                Console.WriteLine($"{aver:f4}");
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
