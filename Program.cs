using HomeWork16.Classes;
using HomeWork16.Interfaces;

namespace HomeWork16
{
    internal class Program
    {
        private static IFlyingRobot _Fly_Quadcopter = new Quadcopter();


        public static void Main(string[] args)
        {
            IChargeable  _Ch_Quadcopter  = _Fly_Quadcopter as IChargeable;
            Quadcopter _quadcopter = _Ch_Quadcopter as Quadcopter;

            Console.WriteLine("Hello, World!");
            Console.WriteLine($"IFlyingRobot: {_Fly_Quadcopter.GetInfo()}");
            Console.WriteLine($"IChargeable: {_Ch_Quadcopter.GetInfo()}");
            Console.WriteLine($"Quadcopter: {_quadcopter.GetObjectTest()}");

            Console.WriteLine(String.Join("\n", _Fly_Quadcopter.GetComponents()));

            _Ch_Quadcopter.Charge();
        }
    }
}
