using System;
using System.Collections.Generic;

namespace Session_01__Entity_Framework
{
    public class Author
    {
        public int AuthorId { get; set; } // Primarykey and identityy
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
