using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Robot
    {
        //variables (Has A)
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

       

        //public Weapon weapon;

        //Constructor
        public Robot(string name, Weapon weapon)
        {
            this.name = name;
            health = 100;
            powerLevel = 50;
            this.weapon = weapon;
        }

        //Member methods
        public void AttackDino(Dinosaur dinoBeingAttacked)
        {
            dinoBeingAttacked.health = dinoBeingAttacked.health - weapon.attackPower;

            //take the first robot in list(index 0) 
            //and attack the first dino in dino list(index 0)
            // robot attack power negates dino health
           
        }


    }
}
