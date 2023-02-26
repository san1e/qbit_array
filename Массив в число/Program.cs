using System;
using System.Linq;

namespace Массив_в_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string str = string.Join("", arr);
            int num = int.Parse(str) + 42;
            Console.WriteLine(num);
        }
    }
}
