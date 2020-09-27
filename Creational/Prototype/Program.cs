using System;
using Prototype.ExtendedPrototype;
using Prototype.SimplePrototype;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype Pattern:");

            RunSimplePrototypeExample();
            RunExtendedExample();
        }

        private static void RunExtendedExample()
        {
            Console.WriteLine("Extended example:");
            var sensorOne = new Sensor(10, 5, "Sensor with mixed properties");
            var sensorTwo = sensorOne.DeepClone();

            Console.WriteLine(sensorOne);
            Console.WriteLine(sensorTwo);
        }

        private static void RunSimplePrototypeExample()
        {
            Console.WriteLine("Simple example:");
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
