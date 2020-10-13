using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Dinosaur
    {
        public string nameDinosaur;
        public int healthDinosaur;                 // member variables
        public int energyLevel;
        public int attackDamage = 10;
        public string attackName;
        
        public Dinosaur(string nameDinosaur, int healthDinosaur, int energyLevel)
        {
            this.nameDinosaur = nameDinosaur;
            this.healthDinosaur = healthDinosaur;      // constructor
            this.energyLevel = energyLevel;

        }

        //member methods
        public int RemoveHealth(Robot enemy)                      // A method to cause damage to the Dinosaur
        {
            healthDinosaur -= enemy.robotWeapon.attackPower;
            return healthDinosaur;

        }
        public int RemoveEnergy()                  // Using Energy function to add to attack action
        {
            energyLevel -= 10;
            return energyLevel;

        }
        public int Rest()                          // A Rest action to replenish Energy Level
        {
            energyLevel += 15;
            return energyLevel;
        }

        public List<string> attackList = new List<string>();    // Attack List for Dinosaurs

         public Dinosaur()
         {
            attackList.Add("claw");
            attackList.Add("bite");
            attackList.Add("tail");
         }

        public void Attacking(Robot enemy)                      // Attacks will be all 3 types per round, includes Energy loss.
        {
            int damageTotal = attackList.Count * attackDamage;
            enemy.healthRobot -= damageTotal;
            RemoveEnergy();

        } 
        
    }
}

