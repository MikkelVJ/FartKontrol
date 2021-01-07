using System;
using System.Collections.Generic;
using System.Text;

namespace FartKontrol
{
    class Truck : Vehicle
    {
        public int MaxLoad { get; set; }
        public Truck(string manufacturer, string model) : base(manufacturer, model)
        {
            MaxLoad = 8000;
        }
    }
}
