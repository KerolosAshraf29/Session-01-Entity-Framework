using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace Session_01__Entity_Framework
{
    public class Book
    {
        public int BookId { get; set; } // Primarykey and identityy
        public string Title { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearPublished { get; set; }
        public bool IsInStock { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
