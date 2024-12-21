using HomeWork16.Classes;
using HomeWork16.Interfaces;

namespace HomeWork16
{
    internal class Program
    {
        private static Quadcopter _Quadcopter = new Quadcopter();


        public static void Main(string[] args)
        {
            IFlyingRobot Fly_Quadcopter = _Quadcopter;
            IChargeable  Ch_Quadcopter  = _Quadcopter;

            Console.WriteLine("Hello, World!");
            Console.WriteLine(Fly_Quadcopter.GetInfo());

            Console.WriteLine(String.Join("\n", Fly_Quadcopter.GetComponents()));

            Ch_Quadcopter.Charge();
        }
    }
}
