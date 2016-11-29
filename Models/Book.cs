using System.ComponentModel.DataAnnotations;

namespace mvc_library.Models
{
    public class Book
    {
    
        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public Book(string title, string author, string description)
        {
            Title = title;
            Author = author;
            Description = description;
        }
    }
}