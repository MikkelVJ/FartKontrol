using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace FartKontrol
{
    class SpeedMeasurementCatalog
    {
        private string address { get; set; }
        private string zone { get; set; }
        private int SpeedLimit { get; set; }
        private List<SpeedMeasurement> speedList { get; set; }
        

        public SpeedMeasurementCatalog(string address, string zone, int speedLimit)
        {
            this.address = address;
            this.zone = zone;
            SpeedLimit = speedLimit;
            speedList = new List<SpeedMeasurement>();
        }

        public void AddSpeedMeasurement(int speed, int regno)
        {
            if (speed > 0 && speed < 300)
            {
                SpeedMeasurement temp = new SpeedMeasurement(speed, DateTime.Now);
                speedList.Add(temp);
            }
            else
            {
                throw new ArgumentException("ERROR: Invalid Speed");
            }
        }

        //public void FindVehicle()
        //{
        //    foreach (Vehicle v in vehicles)
        //    {

        //    }
        //}
        // Vi nåede ikke at afslutte denne del af opgaven, så det er bare blevet kommenteret ud for at undgå crashes/freezes

        public double AverageSpeed()
        {
            double average = 0;
            foreach (var sp in speedList)
            {
                average = average + sp.speed;
            }

            average = average / speedList.Count;
            return average;
        }

        public int NoOfOverSpeedLimit()
        {
            int counter = 0;
            foreach (var v in speedList)
            {
                if (v.speed > SpeedLimit)
                {
                    counter++;
                }
            }

            return counter;
        }

        public int NoOfCutInLicense()
        {
            int counter = 0;
            for (int i = 0; i < speedList.Count; i++)
            {
                if (speedList[i].speed > SpeedLimit * 1.30)
                {
                    counter++;
                }

            }

            return counter;
        }

        public string PrintAll()
        {
            string temp = null;
            foreach (var v in speedList)
            {
                Console.WriteLine(v);
            }

            return temp;
        }

        public override string ToString()
        {
            return $"the adress is {address}, the zone is {zone} and the speedlimit is {SpeedLimit}" + PrintAll();
        }
    }
}
