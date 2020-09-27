namespace Prototype.ExtendedPrototype
{
    public class Sensor : IDeepClone<Sensor>
    {
        private readonly int _maxValue;
        private readonly int _minValue;
        public int CurrentValue { get; private set; }
        public string Name { get; }

        public Sensor(int maxValue, int minValue, string name)
        {
            _maxValue = maxValue;
            _minValue = minValue;
            CurrentValue = default;
            Name = name;
        }

        public void SetValue(int value)
        {
            CurrentValue = value;
        }

        public Sensor DeepClone()
        {
            return new Sensor(this._maxValue, this._minValue, this.Name);
        }

        public override string ToString()
        {
            return $"HashCode: {this.GetHashCode()}, {nameof(_maxValue)}: {_maxValue}, {nameof(_minValue)}: {_minValue}, {nameof(CurrentValue)}: {CurrentValue}, {nameof(Name)}: {Name}";
        }
    }
}
