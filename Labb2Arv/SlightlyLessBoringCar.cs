using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Arv
{
    internal class SlightlyLessBoringCar : AverageBoringCar
    {
        public int coolScore { get; set; }
        public SlightlyLessBoringCar(string vehicleType, int vehicleWindows, string vehicleBrand, int vehicleAge, int vehicleDoors, string vehicleEngineSound, bool carIsBroken, int distanceTraveled, int coolScore) : base(vehicleType, vehicleWindows, vehicleBrand, vehicleAge, vehicleDoors, vehicleEngineSound, carIsBroken, distanceTraveled) 
        {
            this.coolScore = coolScore;
        }

        public void LookCool()
        {
            coolScore += 1;
            Console.WriteLine($"The {vehicleBrand} Begins To Look Cool | Cool Score:{coolScore}");
        }
    }
}
