using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Arv
{
    internal class DecentlyBoringCar : AverageBoringCar
    {
        public int cleanliness {  get; set; }
        public DecentlyBoringCar(string vehicleType, int vehicleWindows, string vehicleBrand, int vehicleAge, int vehicleDoors, string vehicleEngineSound, bool carIsBroken, int distanceTraveled, int cleanliness) : base(vehicleType, vehicleWindows, vehicleBrand, vehicleAge, vehicleDoors, vehicleEngineSound, carIsBroken, distanceTraveled)
        {
            this.cleanliness = cleanliness;
        }

        public void CleanCar()
        {
            if(cleanliness > 0)
            {
                cleanliness -= 1;
                Console.WriteLine($"You have cleaned a bit of the {vehicleBrand} | cleanliness :{cleanliness}");
            }
            else
            {
                Console.WriteLine($"The {vehicleBrand} is already clean | cleanliness :{cleanliness}");
            }
        }
    }
}
