using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Prototype
{
    public class Book : IDeepClone<Book>
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public string ISBN { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Book DeepClone(Book obj)
        {
            var serializedBook = JsonSerializer.Serialize(obj);
            return JsonSerializer.Deserialize<Book>(serializedBook);
        }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Author)}: {Author}, {nameof(ISBN)}: {ISBN}, {nameof(ReleaseDate)}: {ReleaseDate}";
        }
    }

    public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Surname)}: {Surname}, {nameof(BirthDate)}: {BirthDate}";
        }
    }


    public interface IDeepClone<T> where T : class
    {
        /// <summary>
        /// Creates deep copy of en object.
        /// </summary>
        T DeepClone (T obj);
    }
}
