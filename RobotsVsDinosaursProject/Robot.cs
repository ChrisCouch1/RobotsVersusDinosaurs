using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Robot
    {
        public string nameRobot;
        public int healthRobot;                     // member variables
        public int powerLevel;
        
        public Robot(string nameRobot, int healthRobot, int powerLevel)
        {
            this.nameRobot = nameRobot;
            this.healthRobot = healthRobot;         // constructor
            this.powerLevel = powerLevel;
        }

        //member methods
    }
}
