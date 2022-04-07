using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Book
    {
        public Book()
        {
            _id++;
            Id = _id;
        }

        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - AuthorName: {AuthorName} - Price: {Price}");
        }
    }
}
