using System;
using System.Text;

namespace Чётные_элементы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sb.Append(arr[i] + " ");
                }
            }

            string result = sb.ToString().TrimEnd();
            Console.WriteLine(result);

        }
    }
}
