using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ArraySize;
            double big=0;
            Console.WriteLine("Enter Size of array");
            ArraySize = Convert.ToInt32(Console.ReadLine());
            double[] marks = new double[ArraySize];
            Console.WriteLine("Please enter the Marks in the array");
            for (int i = 0; i < ArraySize; i++)
            {
                marks[i] =Convert.ToDouble(Console.ReadLine());
            }
            for(int i = 0; i < ArraySize; i++)
            {
                if (marks[i] >= big)
                    big=marks[i];
            }
            Console.WriteLine("\nMost number of marks achived are : " + big);

        }
    }
}
