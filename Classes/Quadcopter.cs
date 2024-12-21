using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork16.Interfaces;

namespace HomeWork16.Classes
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new List<string>() { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents()
        {
            return _components;
        }

        public string GetInfo()
        {
            return (this as IFlyingRobot).GetRobotType();
        }

        void IChargeable.Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
    }

}
