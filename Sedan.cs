using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Sedan: GenericCar
    {
        private int maxPass;
        public Sedan()
        { 

            maxPass = 5;
        }


        public override int MaxPassengers
        {
            get
            {
                return maxPass;
            }
        }


        public override string VehicleType
        {
            get
            {
                return "Sedan";
            }
        }
    }
}
