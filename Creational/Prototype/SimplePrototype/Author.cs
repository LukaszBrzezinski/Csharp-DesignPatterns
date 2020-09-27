namespace Prototype.SimplePrototype
{
    public class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return $"hashCode: {this.GetHashCode()}, {nameof(Name)}: {Name}, {nameof(Surname)}: {Surname}";
        }
    }
}