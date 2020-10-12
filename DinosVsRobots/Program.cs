using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon1 = new Weapon("Machine gun", 50);
            Robot bot5 = new Robot("Wall-E", weapon1);


            
            Robot bot2 = new Robot("Wall-E", new Weapon("Machine gun", 50));

        }
    }
}
