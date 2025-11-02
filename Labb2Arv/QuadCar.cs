using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Arv
{
    internal class QuadCar : Vehicle
    {
        public bool isCarStolen { get; set; } = false;
        public QuadCar(string vehicleType, int vehicleWindows, string vehicleBrand, int vehicleAge, int vehicleDoors, string vehicleEngineSound, bool isCarStolen) : base ( vehicleType,  vehicleWindows,  vehicleBrand,  vehicleAge,  vehicleDoors,  vehicleEngineSound ) 
        {
            this.isCarStolen = isCarStolen;
        }
       
        public void IsItStolen()
        {
            if (!isCarStolen)
            {
                Random rnd = new Random();
                if (rnd.Next(0, 10) < 5)
                {
                    Console.WriteLine("The QuadCar is Not Stolen :D ");
                }
                else
                {
                    isCarStolen = true;
                    Console.WriteLine("The QuadCar is Stolen :(");
                }
            }
            else
            {
                Console.WriteLine("The QuadCar is Stolen :(");
            }

        }



    }
}
