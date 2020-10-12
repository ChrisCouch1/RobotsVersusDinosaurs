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

        public Dinosaur(string nameDinosaur, int healthDinosaur, int energyLevel)
        {
            this.nameDinosaur = nameDinosaur;
            this.healthDinosaur = healthDinosaur;      // constructor
            this.energyLevel = energyLevel;

        }

        // member methods
    }
}

