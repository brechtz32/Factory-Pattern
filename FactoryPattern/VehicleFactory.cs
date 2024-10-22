using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            if (numberOfTires == 2)
            {
                return new Motorcycle();
            }
            else if (numberOfTires == 4)
            {
                return new Car();
            }
            else
            {
                return new Car();
            }
        }
    }
}
