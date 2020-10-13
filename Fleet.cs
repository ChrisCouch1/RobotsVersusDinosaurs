using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Fleet
    {
        public List<Robot> RobotFleet = new List<Robot>();

        public Fleet()
        {
            RobotFleet.Add(new Robot("Robo-Bob", 30, 30));
            RobotFleet.Add(new Robot("C3poo", 40, 30));
            RobotFleet.Add(new Robot("Jim Bo", 50, 30));

        }

        
            
        
        
         
        
            

    }
}
