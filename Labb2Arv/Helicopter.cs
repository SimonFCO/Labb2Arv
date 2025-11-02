using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Arv
{
    internal class Helicopter : Vehicle
    {
       public int passengerAmmount {  get; set; }
        public bool hasPassager { get; set; }
        public Helicopter(string vehicleType, int vehicleWindows, string vehicleBrand, int vehicleAge, int vehicleDoors, string vehicleEngineSound, int passengerAmmount, bool hasPassager) : base(vehicleType, vehicleWindows, vehicleBrand, vehicleAge, vehicleDoors, vehicleEngineSound)
        {
            this.passengerAmmount = passengerAmmount;
            this.hasPassager = hasPassager;
        }

        public void GetPassenger()
        {
            if(passengerAmmount <= 4)
            {
                passengerAmmount += 1;
                Console.WriteLine($"Picked up 1 passenger Current Passenger Count = {passengerAmmount}");
                
            }
            else
            {
                Console.WriteLine("You need to drop off a passenger before picking up more");
            }
        }

        public void DropOffPassenger()
        {
            if(passengerAmmount > 0)
            {
                passengerAmmount -= 1;
                Console.WriteLine($"Dropped of one passenger Current Passenger count = {passengerAmmount}");
               
            }
            else
            {
                Console.WriteLine("You have no passengers to drop off");
            }
            
            
        }
    }
}
