using System.Text.Json;

namespace Prototype.SimplePrototype
{
    public class Book : IDeepClone<Book>
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public string ISBN { get; set; }
        public Book DeepClone()
        {
            var serializedBook = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<Book>(serializedBook);
        }

        public override string ToString()
        {
            return $"hashCode: {this.GetHashCode()}, {nameof(Title)}: {Title}, {nameof(Author)}: {Author}, {nameof(ISBN)}: {ISBN}";
        }
    }
}
