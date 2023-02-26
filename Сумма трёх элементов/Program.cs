using System;

namespace Сумма_трёх_элементов
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int x = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int p = int.Parse(input[0]);
            int q = int.Parse(input[1]);
            int r = int.Parse(input[2]);

           
            int[] a = new int[20];
            a[0] = x;
            for (int i = 1; i < a.Length; i++)
            {
                a[i] = a[i - 1] * (i+1 - 10) + x;
            }

            
            int sum = a[p - 1] + a[q - 1] + a[r - 1];

            Console.WriteLine(sum);
        }
    }
}
    