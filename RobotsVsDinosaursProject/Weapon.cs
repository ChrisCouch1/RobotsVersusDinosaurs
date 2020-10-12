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


    }

}
