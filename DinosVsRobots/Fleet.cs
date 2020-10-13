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

            Robot bot1 = new Robot("Eve", "Plasma Cannon");
            Robot bot2 = new Robot("Wall-E", "Fire Extinguisher");
            Robot bot3 = new Robot("Baymax","Rocket Punch");

            robotList.Add(bot1);
            robotList.Add(bot2);
            robotList.Add(bot3);
        }

        //Member methods


    }
}
