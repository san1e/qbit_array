using System;
using System.Runtime.Serialization.Formatters;

namespace Элементы_с_одинаковыми_знаками
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            string[] results = new string[k];
            for (int i = 0; i < k; i++)
            {
                int n = int.Parse(Console.ReadLine()); 
                bool found = false;
                string[] input = Console.ReadLine().Split(' ');
                for (int j = 2; j <= n; j++)
                {
                    if (Math.Sign(int.Parse(input[j - 2])) == Math.Sign(int.Parse(input[j - 1])))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    results[i] = "YES";
                }
                else
                {
                    results[i] = "NO";
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(results[i]);
            }
        }
    }
}
