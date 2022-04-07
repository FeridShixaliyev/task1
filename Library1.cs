using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Library
    {
        public Library()
        {
            _id++;
            Id = _id;
        }
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        List<Book> books { get; set; } = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public Book GetBookById(int id)
        {
            return books.Find(b => b.Id == id);
        }

        public void RemoveBook(int id)
        {
            books.Remove(books.Find(b => b.Id == id));
        }
    }
}
