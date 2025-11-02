namespace Labb2Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuadCar QuadcarClass = new QuadCar("QuadCar", 1, "Aosom", 1, 0, "Vrum Vrom Vram Vrim", false);
            Excevator ExcevatorClass = new Excevator("Excevator", 4, "BobCat", 5, 2, "VRUM VRUM VRUM", 0);
            Helicopter HelicopterClass = new Helicopter("Helicopter", 6, "Airbus", 8, 4, "vrooooooooooooom", 0, false);
            AverageBoringCar BoringCarClass = new AverageBoringCar("Personal Car", 6, "Volvo240", 20, 4, "Vrom... vrom... vrom...", false, 0);
            DecentlyBoringCar DecentlyBoringCarClass = new DecentlyBoringCar("Personal Car", 6, "Volvo780", 20, 4, "Vrim...Vram..Vrom", false, 0, 2);
            SlightlyLessBoringCar SlightlyLessBoringCarClass = new SlightlyLessBoringCar("Personal Car", 6, "Volvo440", 20, 4, "Vrem.... Vrem... Vrem...", false, 0, 0);

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

            Console.WriteLine();
            Console.WriteLine("--- DecentlyBoringCar(Volvo) ---");
            Console.WriteLine();

            DecentlyBoringCarClass.vehicleInfo();
            DecentlyBoringCarClass.startEngine();
            DecentlyBoringCarClass.CleanCar();
            DecentlyBoringCarClass.CleanCar();
            DecentlyBoringCarClass.CleanCar();
            DecentlyBoringCarClass.DriveCar();
            DecentlyBoringCarClass.StopEngine();
            DecentlyBoringCarClass.SellCar();

            Console.WriteLine();
            Console.WriteLine("--- SlightlyLessBoringCar(Volvo) ---");
            Console.WriteLine();

            SlightlyLessBoringCarClass.vehicleInfo();
            SlightlyLessBoringCarClass.startEngine();
            SlightlyLessBoringCarClass.LookCool();
            SlightlyLessBoringCarClass.LookCool();
            SlightlyLessBoringCarClass.LookCool();
            SlightlyLessBoringCarClass.DriveCar();
            SlightlyLessBoringCarClass.StopEngine();
            SlightlyLessBoringCarClass.SellCar();

        }
    }
}
