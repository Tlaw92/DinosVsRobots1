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

            while (fleet1.robotList.Count > 0 && herd1.dinoList.Count > 0) 
            {
                fleet1.robotList[0].AttackDino(herd1.dinoList[0]);
                if (herd1.dinoList[0].health <= 0)
                {

                    herd1.dinoList.RemoveAt(0);
                    if (herd1.dinoList.Count <= 0)
                    {
                        break;
                    }
                }

                herd1.dinoList[0].AttackBot(fleet1.robotList[0]);
                if (fleet1.robotList[0].health <= 0)
                {
                    fleet1.robotList.RemoveAt(0);
                }
            }

            if (fleet1.robotList.Count > 0)
            {
                Console.WriteLine("The awesome Disney robots won the battle!");
            }
            else
            {
                Console.WriteLine("Somehow the lame dinosaurs won the battle..");
            }

        }
    }
}
