﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._3
{
    internal class Program
    {
        public static void calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            Console.WriteLine("\nSum of array elements is : " + sum + "\n");
        }
        static void Main(string[] args)
        {
            int ArraySize;
            Console.WriteLine("Enter Size of array");
            ArraySize = Convert.ToInt32(Console.ReadLine());
            int[] integers = new int[ArraySize];
            Console.WriteLine("\nPlease enter the integers in the array");
            for (int i = 0; i < ArraySize; i++)
            {
                integers[i] = Convert.ToInt32(Console.ReadLine());
            }
            calculate(integers);

        }
    }
}
