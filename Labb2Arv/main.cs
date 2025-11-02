using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labb2Arv
{
    class menu
    {
        static QuadCar QuadcarClass;
        static Excevator ExcevatorClass;
        static Helicopter HelicopterClass;
        static AverageBoringCar BoringCarClass;
        public void InitClasses()
        {
            QuadcarClass = new QuadCar("QuadCar", 1, "Aosom", 1, 0, "Vrum Vrom Vram Vrim", false);
            ExcevatorClass = new Excevator("Excevator", 4, "BobCat", 5, 2, "VRUM VRUM VRUM", 0);
            HelicopterClass = new Helicopter("Helicopter", 6, "Airbus", 8, 4, "vrooooooooooooom", 0, false);
            BoringCarClass = new AverageBoringCar("Personal Car", 6, "Volvo", 20, 4, "Vrom... vrom... vrom...", false, 0);

        }
        public void PickVehicle()
        {
            DoesEverythingWork();
            // Console.WriteLine("What Vehicle do you want to try");
            // Console.WriteLine("[1]:Excevator \n[2]:Helicopter\n[3]:QuadCar\n[4]:Volvo\n[5]:Pick this if you just wanna see if everything works");

            //int answer = 0;
            //answer = Convert.ToInt32(Console.ReadLine());

            ////GetAnswer(answer, 0, 5);

            //switch (answer)
            //{
            //    case 1:

            //        break;
            //    case 2:

            //        break;
            //    case 3:

            //        break;
            //    case 4:

            //        break;
            //    case 5:
            //        DoesEverythingWork();
            //        break;
            //}
        }

        public void ExcevatorFunction()
        {

        }

        public void HelicopterFunction()
        {

        }

        public void QuadCarFunction()
        {

        }

        public void VolvoFunction()
        {

        }

        public void DoesEverythingWork()
        {
            //This will show the basic 5 variables and start the engine then run the custom function for all the 4 vehicles and after that stop engine and sell vehicle
            Console.WriteLine();
            Console.WriteLine("--- QuadCar ---");
            Console.WriteLine();
            QuadcarClass.vehicleInfo();
            QuadcarClass.startEngine();          
            QuadcarClass.IsItStolen();
            QuadcarClass.IsItStolen();
            QuadcarClass.IsItStolen();
            QuadcarClass.StopEngine();
            QuadcarClass.SellCar();

            Console.WriteLine();
            Console.WriteLine("--- Excevator ---");
            Console.WriteLine();

            ExcevatorClass.vehicleInfo();
            ExcevatorClass.startEngine();
            ExcevatorClass.DigDirt();
            ExcevatorClass.DigDirt();
            ExcevatorClass.DigDirt();
            ExcevatorClass.StopEngine();
            ExcevatorClass.SellCar();

            Console.WriteLine();
            Console.WriteLine("--- Helicopter ---");
            Console.WriteLine();

            HelicopterClass.vehicleInfo();
            HelicopterClass.startEngine();
            HelicopterClass.GetPassenger();
            HelicopterClass.GetPassenger();
            HelicopterClass.DropOffPassenger();
            HelicopterClass.StopEngine();
            HelicopterClass.SellCar();

            Console.WriteLine();
            Console.WriteLine("--- BoringCar(Volvo) ---");
            Console.WriteLine();

            BoringCarClass.vehicleInfo();
            BoringCarClass.startEngine();
            BoringCarClass.DriveCar();
            BoringCarClass.StopEngine();
            BoringCarClass.SellCar();
        }


        static void GetAnswer(int answer, int minSize, int maxSize)
        {
            while (!int.TryParse(Console.ReadLine(), out answer) || answer < minSize || answer > maxSize)
            {

                Console.WriteLine($"Answer must be a number between {minSize} - {maxSize}");

            }
        }
    }
}
