using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    abstract class GenericCar: Vehicle
    {
        private int wheels=4;

        public override int Wheels
        {
            get
            {
                return wheels;
            }
        }

        
    }
}
