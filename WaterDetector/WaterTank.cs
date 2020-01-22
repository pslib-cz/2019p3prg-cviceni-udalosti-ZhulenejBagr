using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static WaterDetector.ExampleEvent;

namespace WaterDetector
{
    class WaterTank
    {
        private int _value = 0;


        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;

            }
        }
        public WaterTank(int capacity, string name)
        {
            Capacity = capacity;
            Name = name;
            Reset();
        }

        public int Capacity { get; }
        public string Name { get; }
        public int CurrentValue { get { return _value; } }
        public void Reset()
        {
            _value = 0;
        }

        public void Add(int value)
        {
            _value += value;

            if (_value >= Capacity)
            {
                _value = Capacity;
                ValueHasChanged?.Invoke(this, new ExampleEventArgs(_value));
                IsFull?.Invoke(this, new ExampleEventArgs(_value));
            }
            else
            {
                ValueHasChanged?.Invoke(this, new ExampleEventArgs(_value));
            }
        }

        public event ExampleEventHandler ValueHasChanged;
        public event ExampleEventHandler IsFull;
    }
}
