using System;

namespace Массив_в_число
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string digitsStr = string.Join("", arr).TrimStart('0');
            int number = int.Parse(digitsStr) + 42;

            Console.WriteLine(number);
        }
    }
}
