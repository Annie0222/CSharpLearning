using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Oven
{
    class Oven
    {
        private int temperature = 37;
        private int threshold;
        private bool isClosed = false;
        public delegate void OverHeatHandler(int temperature);
        public event OverHeatHandler OverHeat; 

        public Oven(int threshold)
        {
            this.threshold = threshold;
        }

        public void Start()
        {
            while (!isClosed)
            {
                Console.WriteLine($"Temperature of oven is {temperature}.");
                Thread.Sleep(1000);
                if (temperature > threshold) OverHeat(temperature);
                temperature++;
            }
        }

        public void Close()
        {
            isClosed = true;
        }
    }
}
