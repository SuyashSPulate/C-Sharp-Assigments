using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_1._4
{
    internal class Program
    {
         public void FuncSwap(ref int num1,ref int num2)
        {
            int ThirdVar = num1;
            num1 = num2;
            num2 = ThirdVar;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter two numbers to be swapped");
            Console.Write("num1= ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("num2= ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Program p=new Program();
            p.FuncSwap(ref num1,ref num2);
            
            Console.WriteLine("After Swapping num1= "+num1+"  num2= "+num2);
        }
    }
}
