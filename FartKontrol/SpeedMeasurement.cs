using System;
using System.Collections.Generic;
using System.Text;

namespace FartKontrol
{
    class SpeedMeasurement
    {
        private int _id;
        public int speed { get; set; }

        public int id
        {
            get { return _id; }
        }
        public static int counter;
        public DateTime timestamp { get; set; }

        public SpeedMeasurement(int speed, DateTime timestamp)
        {
            this.speed = speed;
            counter++;
            _id = counter;
            timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Car is moving at {speed} and it's ID is {id}. Picture is taken at {timestamp}.";
        }
    }
}
