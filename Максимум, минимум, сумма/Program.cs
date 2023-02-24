using System;
using System.Linq;

namespace Максимум__минимум__сумма
{
    internal class Program
    {
        static int Sum (int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum+= num[i];
            }
            return sum; 
        }
        static string Max(int[] num)
        {
            int maxNumber = num[0];
            int maxIndex = 0;
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] >= maxNumber)
                {
                    maxNumber = num[i];
                    maxIndex = i+1;
                }
            }
            int[] max = {maxNumber, maxIndex };
            string str = string.Join(" ", max);
            return str;
        }
        static string Min(int[] num)
        {
            int minNumber = num[0];
            int minIndex = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < minNumber)
                {
                    minNumber = num[i];
                    minIndex = i+1;
                }
            }
            int[] min = {minNumber, minIndex};
            string str = string.Join(" ", min);
            return str;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(Sum(arr));
            Console.WriteLine(Max(arr));
            Console.WriteLine(Min(arr));
        }
    }
}
