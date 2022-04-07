using System;
using System.IO;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {
                bool check = true;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1.  Add book");
                Console.WriteLine("2.  Get book by id");
                Console.WriteLine("3.   Remove book");
                Console.WriteLine("0.  Quit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Book book = new Book();
                        book.Id
                        book.Name = Console.ReadLine();
                        book.AuthorName = Console.ReadLine();

                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "0":
                        check = false;
                        break;                   
                    default:
                        Console.WriteLine("Wrong choice!!");
                        break;
                }
            } while (check);
        }
    }
}
