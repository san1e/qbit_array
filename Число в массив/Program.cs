using System;
using System.Linq;

namespace Число_в_массив
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string numberString = number.ToString(); 
            int[] arr = new int[numberString.Length]; 

            for (int i = 0; i < numberString.Length; i++)
            {
                arr[i] = (int)char.GetNumericValue(numberString[i]); 
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
