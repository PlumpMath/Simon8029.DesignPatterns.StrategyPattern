using System;

namespace Simon8029.DesignPatterns.StrategyPattern.Weapons
{
    public class MachineGun : IWeapon
    {
        public  void Attack(int x, int y)
        {
            Console.WriteLine("machine gun attack ({0}, {1})", x, y);
        }
    }
}