using System;

namespace Simon8029.DesignPatterns.StrategyPattern.Weapons
{
    public class MachineGun : IWeapon
    {
        public string Name
        {
            get { return "MachineGun"; }
        }

        public void Attack(int x, int y)
        {
            Console.WriteLine(" {0} attack ({1}, {2})", Name, x, y);
        }
    }
}