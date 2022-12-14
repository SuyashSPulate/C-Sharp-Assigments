using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._6
{
    internal class Program
    {
         public struct Book
        {
            public int bookId; public string title; public double price;
            public enum bookType
            {
                Magazine=1,
                Novel,
                ReferenceBook,
                Miscellaneous
            };
        }
             
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number of books");
            n=Convert.ToInt32(Console.ReadLine());

            Book[] book = new Book[n];
            Console.WriteLine("\nEnter book details");
            for (int i = 0; i < n; i++)
            {
                
                Console.Write("Book ID= ");
                book[i].bookId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Book title= ");
                book[i].title = Console.ReadLine();
                Console.Write("Book price= ");
                book[i].price = Convert.ToDouble(Console.ReadLine());
                Console.Write("Book Type (1 for Magazine\nSelect 2 for Novel\nSelect 3 for ReferenceBook,\nSelect 4 for Miscellaneous) = ");
                //book[i].bookType=Convert.ToDouble()

            }
            Console.WriteLine("\nDetails of books are as follows");
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("\nBook ID is "+ book[i].bookId);
                Console.WriteLine("Book title is "+book[i].title);
                Console.WriteLine("Book price is " + book[i].price+"\n");
            }
        }
    }
}
