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
        public Weapon robotWeapon;

        public Robot(string nameRobot, int healthRobot, int powerLevel)
        {
            this.nameRobot = nameRobot;
            this.healthRobot = healthRobot;         // constructor
            this.powerLevel = powerLevel;

        }

        //member methods
        public int RemoveHealth(Dinosaur enemy)           // Method for damaging the Robot
        {
            healthRobot -= enemy.attackDamage;
            return healthRobot;
        }
        
        public int RemovePower()                        // Method for using up Power during a round
        {
            powerLevel -= 10;
            return powerLevel;
        }
        public int AddPower()                          // Method for recovering Power
        {
            powerLevel += 15;
            return powerLevel;
        }
        public void Attacking(Dinosaur enemy)               // Attack method
        {
            enemy.healthDinosaur -= robotWeapon.attackPower;
            RemovePower();
            
        }

    }
}
