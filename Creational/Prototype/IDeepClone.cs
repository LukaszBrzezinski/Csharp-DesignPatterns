namespace Prototype
{
    public interface IDeepClone<out T> where T : class
    {
        /// <summary>
        /// Creates deep copy of en object.
        /// </summary>
        T DeepClone ();
    }
}