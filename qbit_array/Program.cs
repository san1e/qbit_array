﻿using System;
namespace qbit_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int NUM = Convert.ToInt32(arr);
            Console.WriteLine(NUM);
        }
    }
}
