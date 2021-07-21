using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Truck: GenericCar
    {
        private int maxpass;
        public Truck()
        {

            maxpass = 3;
        }
        public override int MaxPassengers
        {
            get
            {
                return maxpass;
            }
        }
        public override string VehicleType
        {
            get
            {
                return "Truck";
            }
        }
    }
}
