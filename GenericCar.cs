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

        public override string ToString()
        {
            return  VehicleType+ ", with License Plate: " + LicensePlate + ", and VIN " + VIN;
        }

        public override string GetDescription()
        {
            return ToString()
                + ", and " + Wheels + " wheels. The Maximum number of Passengers are: "
                + MaxPassengers;
        }

    }
}
