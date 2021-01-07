using System;
using System.Collections.Generic;
using System.Text;

namespace FartKontrol
{
    class Car : Vehicle
    {
        public int NoOfPersons;
        public Car(string manufacturer, string model) : base(manufacturer, model)
        {
            NoOfPersons = 5;
        }
    }
}
