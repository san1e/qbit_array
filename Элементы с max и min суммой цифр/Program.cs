using System;

namespace Элементы_с_max_и_min_суммой_цифр
{
    internal class Program
    {
        static int DigitSum(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int minIndex = 0;
            int maxIndex = 0;
            int minSum = DigitSum(arr[0]);
            int maxSum = minSum;

            for (int i = 1; i < n; i++)
            {
                int sum = DigitSum(arr[i]);
                if (sum < minSum)
                {
                    minSum = sum;
                    minIndex = i;
                }
                else if (sum == minSum && arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxIndex = i;
                }
                else if (sum == maxSum && arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine(arr[minIndex]);
            Console.WriteLine(arr[maxIndex]);
        }
    }
}
