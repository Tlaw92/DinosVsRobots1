using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Herd
    {
        //variables
        public List<Dinosaur> dinoList;

        //Constructor
        public Herd()
        {
            dinoList = new List<Dinosaur>();
            Dinosaur dino1 = new Dinosaur("T-Rex");
            Dinosaur dino2 = new Dinosaur("Stegosaurus");
            Dinosaur dino3 = new Dinosaur("Triceratops");
            dinoList.Add(dino1);
            dinoList.Add(dino2);
            dinoList.Add(dino3);
        }

        //Member methods

    }
}
