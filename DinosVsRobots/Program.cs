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
            Battlefield battle1 = new Battlefield();
            battle1.StartBattle();
            Console.ReadLine();
        }
    }
}
