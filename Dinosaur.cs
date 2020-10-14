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

        public Weapon[] attackArray = new Weapon[3];    // Attack Array for Dinosaurs

         public Dinosaur()
         {
            attackArray[0] = new Weapon("claw", 10);
            attackArray[1] = new Weapon("bite", 20);
            attackArray[2] = new Weapon("tail", 15);
         }

        public void Attacking(Robot enemy)                      // Attacks will be from 3 types, includes Energy loss.
        {
            int damageTotal = 
            enemy.healthRobot -= damageTotal;
            RemoveEnergy();

        } 
        
    }
}

