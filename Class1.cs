using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book("Harry Porter", "JK Rowling", 400);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }

        }
    }
