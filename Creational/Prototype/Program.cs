using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Pattern:");

            var firstBook = new Book()
            {
                Author = new Author()
                {
                    Name = "Martin",
                    Surname = "Fowler",
                },
                Title = "Patterns of Enterprise Application Architecture",
                ISBN = "ISBN 0-321-12742-0​​"
            };

            var secondBook = firstBook.DeepClone();

            Console.WriteLine($"First book: {firstBook}");
            Console.WriteLine($"Second book: {secondBook}");
        }
    }
}
