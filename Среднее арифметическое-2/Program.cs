using System;

namespace Среднее_арифметическое_2
{
    internal class Program
    {
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num) ; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
           double N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            double sum = 0;
            double count = 0;
            for (int i = 0; i < N; i++)
            {
                if (IsPrime(Math.Abs(arr[i])) && Math.Abs(arr[i]) != 1)
                {
                    sum += arr[i];
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
