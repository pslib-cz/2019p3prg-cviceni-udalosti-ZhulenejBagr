using System;
using System.Collections.Generic;
using System.Text;

namespace WaterDetector
{
    class ExampleEvent
    {
        public delegate void ExampleEventHandler(object sender, ExampleEventArgs e);

        public class ExampleEventArgs
        {
            public ExampleEventArgs(int value)
            {
                Value = value;
            }

            public int Value { get; set; }
        }
    }
}
