using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Arv
{
    internal class AverageBoringCar : Vehicle
    {
        public int distanceTraveled { get; set; }
        public bool carIsBroken { get; set; } = false;
        public AverageBoringCar(string vehicleType, int vehicleWindows, string vehicleBrand, int vehicleAge, int vehicleDoors, string vehicleEngineSound, bool carIsBroken, int distanceTraveled) : base(vehicleType, vehicleWindows, vehicleBrand, vehicleAge, vehicleDoors, vehicleEngineSound)
        {
            this.distanceTraveled = distanceTraveled;
            this.carIsBroken = carIsBroken;
        }

        public void DriveCar()
        {
            if (!carIsBroken)
            {
                Console.WriteLine($"The {vehicleBrand} has started Driving!");
            }
            else
            {
                Console.WriteLine("Cant drive the {vehicleBrand} is broken");
            }
            while (!carIsBroken) 
            {
                Random rnd = new Random();
                if(rnd.Next(0, 50) < 45)
                {
                    distanceTraveled += 1;
                }
                else
                {
                    carIsBroken = true;
                }
               // Console.Clear();

                Console.WriteLine($"The {vehicleBrand} has traveled {distanceTraveled}km");
                
            }
            
        }
    }
}