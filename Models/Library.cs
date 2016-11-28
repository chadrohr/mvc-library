using System.Collections.Generic;

namespace mvc_library.Models
{
    public class Library
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public List<Book> Books { get; set; } 

        public Library(string name, string address)
        {
            Name = name;
            Address = address;
            Books = new List<Book>();
        }

        public void AddBook(Book bookToAddToList)
        {
            Books.Add(bookToAddToList);
        }

        public List<Book> GetAllBooks()
        {
            return Books;
        }
    }
}