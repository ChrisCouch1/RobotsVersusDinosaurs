using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Weapon

    {
        public string typeWeapon;
        public int attackPower;       // member variables

        public Weapon (string typeWeapon, int attackPower)
        {
            this.typeWeapon = typeWeapon;            // constructor
            this.attackPower = attackPower;
        }

        public List<Weapon> weaponsList = new List<Weapon>();
        
        public Weapon(Dinosaur enemy)               
        {
            weaponsList.Add(new Weapon("tazer", 10));
            weaponsList.Add(new Weapon("chainsaw", 20));
            weaponsList.Add(new Weapon("dino-shredder", enemy.healthDinosaur));

        }        

    }
}