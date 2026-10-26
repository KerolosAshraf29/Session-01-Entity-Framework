using System;
using System.Collections.Generic;
using System.Text;

namespace Session_01__Entity_Framework
{
    public class Category
    {
        public int CategoryId { get; set; } // Primarykey and identityy
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
