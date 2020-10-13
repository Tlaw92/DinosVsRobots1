using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Battlefield
    {
        //variables
        public Fleet fleet1;
        public Herd herd1;

        //Constructor
        public Battlefield()
        {
            fleet1 = new Fleet();
            herd1 = new Herd();
        }

        //Member methods (Can Do)
        public void StartBattle()
        {

            //robot to attack dino
            fleet1.robotList[0].AttackDino(herd1.dinoList[0]);
            if (herd1.dinoList[0].health <= 0) //dinosaur runs out of health
            {
                // remove from list
                herd1.dinoList.RemoveAt(0);
            }
            //dino to attack robot
            herd1.dinoList[0].AttackBot(fleet1.robotList[0]);
        }
    }
}
