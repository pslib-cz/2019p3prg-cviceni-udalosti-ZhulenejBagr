using System;
using System.Collections.Generic;
using System.Text;
using static WaterDetector.ExampleEvent;

namespace WaterDetector
{
    class EventSubscriber
    {
        public void OnValueChanged(object sender, ExampleEventArgs e)
        {
            Console.WriteLine(sender.ToString() + " value is now " + e.Value);
        }

        public void OnIsFull(object sender, ExampleEventArgs e)
        {
            Console.WriteLine(sender.ToString() + " is full at capacity " + e.Value);
        }
    }
}
