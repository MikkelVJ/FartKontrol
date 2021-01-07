using System;
using System.Collections.Generic;
using System.Text;

namespace FartKontrol
{
    class Vehicle
    {
        public string manufacturer { get; set; }
        public string model { get; set; }
        public int regNo { get; set; }
        private readonly int counter = 0;

        public Vehicle(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.regNo = counter;
            counter++;
            
        }

        public override string ToString()
        {
            return $"The vehicle is a {model} from {manufacturer}. It's registration # is: {regNo}";
        }
    }
}
