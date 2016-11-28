using System.Collections.Generic;

namespace mvc_library.Models
{
    public class Library
    {
        private string Name { get; set; }

        private string Address { get; set; }

        private List<Book> Books { get; set; } 

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