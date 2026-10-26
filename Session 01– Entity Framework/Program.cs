using Microsoft.EntityFrameworkCore.Migrations;

namespace Session_01__Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationDBcontext())
            {
                // 1. Create a Category
                var category = new Category
                {
                    Name = "fantasy",
                    Description = "Futuristic and space fiction",
                    IsActive = true
                };

                // 2. Create a Author
                var author = new Author
                {
                    FirstName = "Kerolos",
                    LastName = "Ashraf",
                    Email = "Karam.Kerolos222@gmail.com",
                    Biography = "FullStackDeveloper",
                    DateOfBirth = new DateTime(2000, 9, 29)
                };

                // 3. Create a Book linked to the Author and Category
                var book = new Book
                {
                    Title = "Harry-potter",
                    Isbn = "978-0441172719",
                    Price = 199.99m,
                    NumberOfPages = 688,
                    YearPublished = 2000,
                    IsInStock = true,
                    Author = author,
                    Category = category
                };

                // 4. Save to Database
                context.Books.Add(book);
                context.SaveChanges();
                Console.WriteLine("Book saved successfully!\n");

                // 5. Read the data back
                var savedBook = context.Books
                    .Select(b => new
                    {
                        b.Title,
                        b.Price,
                        AuthorName = b.Author.FirstName + " " + b.Author.LastName,
                        CategoryName = b.Category.Name
                    })
                    .FirstOrDefault();

                if (savedBook != null)
                {
                    Console.WriteLine("--- Retrieved from Database ---");
                    Console.WriteLine($"Title: {savedBook.Title}");
                    Console.WriteLine($"Price: ${savedBook.Price}");
                    Console.WriteLine($"Author: {savedBook.AuthorName}");
                    Console.WriteLine($"Category: {savedBook.CategoryName}");
                }
            }
        }
    }
}
