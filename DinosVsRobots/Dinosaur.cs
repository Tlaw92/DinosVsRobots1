using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Dinosaur
    {
        //variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //Constructor
        public Dinosaur(string type)
        {
            this.type = type;
            health = 100;
            attackPower = 50;
        }

        //Member methods
        public void AttackBot(Robot robotBeingAttacked)
        {
            //use dino in dinoList at 0 index
            //attack robot in botList at 0 index
            //dino attack power should take away robot health

            robotBeingAttacked.health -= attackPower;
        }


    }
}
