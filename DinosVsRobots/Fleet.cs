using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Fleet
    {
        //variables
        public List<Robot> robotList;

        //Constructor
        public Fleet()
        {
            robotList = new List<Robot>();
            Weapon weapon1 = new Weapon("Machine gun", 50);
            Weapon weapon2 = new Weapon("love gun", 0);
            Weapon weapon3 = new Weapon("lazer gun", 100);

            Robot bot1 = new Robot("Eve", weapon1);
            Robot bot2 = new Robot("Wall-E", weapon2);
            Robot bot3 = new Robot("Baymax", weapon3);

            robotList.Add(bot1);
            robotList.Add(bot2);
            robotList.Add(bot3);
        }

        //Member methods


    }
}
