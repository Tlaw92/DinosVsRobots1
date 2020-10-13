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

            Random rnd = new Random();
            attackPower = rnd.Next(1, 51);
        }

        //Member methods
        public void AttackBot(Robot robotBeingAttacked)
        {
            robotBeingAttacked.health -= attackPower;
        }

    }
}
