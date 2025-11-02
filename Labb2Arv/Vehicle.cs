using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2Arv
{
    public class Vehicle
    {
        //Just all the variables it needs and uses
        public string vehicleType { get; set; }
        public int vehicleWindows {  get; set; }
        public string vehicleBrand { get; set; }
        public int vehicleAge { get; set; }
        public int vehicleDoors { get; set; }
        public string vehicleEngineSound { get; set; } = "VROM VROM VROM";

        //The main constructor
        public Vehicle(string vehicleType, int vehicleWindows, string vehicleBrand, int vehicleAge, int vehicleDoors, string vehicleEngineSound)
        {
            this.vehicleType = vehicleType;
            this.vehicleWindows = vehicleWindows;
            this.vehicleBrand = vehicleBrand;
            this.vehicleAge = vehicleAge;
            this.vehicleDoors = vehicleDoors;
            this.vehicleEngineSound = vehicleEngineSound;
        }

        //This will just write to console how the engine sounds
        public void startEngine()
        {
            Console.WriteLine($"You Start The Engine:{vehicleEngineSound}");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine Stopped..."); 
        }

        public void SellCar()
        {
            Console.WriteLine($"You sold the {vehicleType} for {vehicleAge}");
        }

        //This will give the basic information about the car
        public void vehicleInfo()
        {
            Console.WriteLine($"Type:{ vehicleType}"); 
            Console.WriteLine($"Window Ammount:{vehicleWindows}");
            Console.WriteLine($"Brand:{vehicleBrand}");
            Console.WriteLine($"Age (years):{vehicleAge}");
            Console.WriteLine($"Door Ammount:{vehicleDoors}");
        }


    }
}
