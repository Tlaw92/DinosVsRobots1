using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Weapon
    {
        //variables
        public string type;
        public int attackPower;

        //Constructor
        public Weapon(string type)
        {
            this.type = type;

            Random rnd = new Random();
            attackPower = rnd.Next(1, 51);
        }

        //Member methods

    }
}
