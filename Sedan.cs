using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Sedan: Vehicle
    {
        private int wheels = 4;
        private int maxPass = 5;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get { return maxPass; }
        }

    }
}
