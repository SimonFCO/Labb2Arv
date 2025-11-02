using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Arv
{
    internal class Excevator : Vehicle
    {
        public int dirtDigged { get; set; }
        public Excevator(string vehicleType, int vehicleWindows, string vehicleBrand, int vehicleAge, int vehicleDoors, string vehicleEngineSound, int dirtDigged) : base(vehicleType, vehicleWindows, vehicleBrand, vehicleAge, vehicleDoors, vehicleEngineSound)
        {
            this.dirtDigged = dirtDigged;
        }

        public void DigDirt()
        {
            dirtDigged++;
            Console.WriteLine($"You succesfully digged some dirt \n You know have {dirtDigged}");
            
        }
    }
}
