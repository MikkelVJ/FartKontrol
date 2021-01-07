using System;
using System.Collections.Generic;

namespace FartKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeedMeasurementCatalog SMC = new SpeedMeasurementCatalog("adresse 1", "zone 1", 60);
            Car c1 = new Car("Honda", "DaVinci");
            Truck t1 = new Truck("Volvo", "Hauler");
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(c1);
            vehicles.Add(t1);
            try
            {
                SMC.AddSpeedMeasurement(20, 0);
                SMC.AddSpeedMeasurement(40, 1 );
                SMC.AddSpeedMeasurement(80, 0);
                SMC.AddSpeedMeasurement(400, 0);
                SMC.AddSpeedMeasurement(-10, 1);
                SMC.AddSpeedMeasurement(0, 1);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine(SMC);
        }
    }
}
