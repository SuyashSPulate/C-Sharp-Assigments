﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int q;
            double num1, num2, result ;

            do
            {
                Console.WriteLine("Select the operation you want to perform\n1)Addition" +
                 "\n2)Subtraction\n3)Multiplication\n4)Division\n5)Exit\n");
                q = Convert.ToInt32(Console.ReadLine());
                
                
                switch (q)
                {
                    case 1:
                        Console.WriteLine("\nEnter Two Numbers");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 + num2;
                        Console.WriteLine("Your answer is : " + result+"\n");
                        break;

                    case 2:
                        Console.WriteLine("\nEnter Two Numbers");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 - num2;
                        Console.WriteLine("Your answer is : " + result + "\n");
                        break;

                    case 3:
                        Console.WriteLine("\nEnter Two Numbers");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 * num2;
                        Console.WriteLine("Your answer is : " + result + "\n");
                        break;

                    case 4:
                        Console.WriteLine("\nEnter Two Numbers");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        num2 = Convert.ToDouble(Console.ReadLine());
                        result = num1 / num2;
                        Console.WriteLine("Your answer is : " + result + "\n");
                        break;

                    case 5:
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (q != 5);
        }
    }
}
