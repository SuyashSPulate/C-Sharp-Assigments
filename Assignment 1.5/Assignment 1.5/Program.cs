using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._5
{
    
    internal class Program
    {
        public void circle(double radius,ref double area, ref double circumference)
        {
             area =3.14* radius * radius;
             circumference = 2 * 3.14 * radius;
        }
        static void Main(string[] args)
        {
            double radius, area=0 , circumference=0;
            Console.WriteLine("Enter radius of circle");
            radius=Convert.ToDouble(Console.ReadLine());
            Program p=new Program();
            p.circle(radius,ref area,ref circumference);
            Console.WriteLine("\nArea of Circle is ={0}\ncircumference of Circle is = {1}\n ", area, circumference);

        }
    }
}
