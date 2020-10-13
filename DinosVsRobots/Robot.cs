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
        public Robot(string name, string weaponType)
        {
            this.name = name;
            health = 100;
            powerLevel = 50;
            weapon = new Weapon(weaponType);
        }

        //Member methods
        public void AttackDino(Dinosaur dinoBeingAttacked)
        {
            dinoBeingAttacked.health -= weapon.attackPower;
        }


    }
}
