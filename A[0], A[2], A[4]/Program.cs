using System;
using System.Text;

namespace A_0___A_2___A_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < arr.Length; i += 2)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
