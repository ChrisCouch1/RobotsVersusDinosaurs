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
            dinosaurHerd.Add(new Dinosaur("T-rex1", 40, 30));
            dinosaurHerd.Add(new Dinosaur("T-rex2", 40, 30));
            dinosaurHerd.Add(new Dinosaur("T-rex3", 40, 30));


        }


    }
}
