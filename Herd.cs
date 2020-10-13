using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaursProject
{
    class Herd
    {
        public List<Dinosaur> dinosaurHerd = new List<Dinosaur>();
        public Herd()
        {
            dinosaurHerd.Add(new Dinosaur("Thad", 40, 30));
            dinosaurHerd.Add(new Dinosaur("Brad", 40, 30));
            dinosaurHerd.Add(new Dinosaur("Chad", 40, 30));


        }


    }
}
