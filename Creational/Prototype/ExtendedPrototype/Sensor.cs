using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Prototype.SimplePrototype;

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
            var serializedSensor = JsonSerializer.Serialize(this);
            return JsonSerializer.Deserialize<Sensor>(serializedSensor);
        }
    }
}
