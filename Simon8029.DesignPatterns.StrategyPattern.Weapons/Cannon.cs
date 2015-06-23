using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon8029.DesignPatterns.StrategyPattern.Weapons
{
    public class Cannon:IWeapon
    {
        public string Name
        {
            get { return "Cannon";}
        }

        public void Attack(int x, int y)
        {
            Console.WriteLine("{0} attack ({1},{2})",Name,x,y);
        }
    }
}
