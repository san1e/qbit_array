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
            int max = num.Max();
            int MaxIndex = Array.LastIndexOf(num, max)+1;
            int[] MaxNum = {max, MaxIndex};
            string str = string.Join(" ", MaxNum);
            return str;

        }
        static string Min(int[] num)
        {
           int min = num.Min();
            int MinIndex = Array.IndexOf(num, min)+1;
            int[] MinNum = {min, MinIndex};
            string str = string.Join(" ", MinNum);
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
