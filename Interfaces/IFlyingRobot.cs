﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork16.Interfaces
{
    internal interface IFlyingRobot: IRobot
    {
        public string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
