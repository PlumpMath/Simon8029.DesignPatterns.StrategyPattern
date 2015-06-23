using System;
using Simon8029.DesignPatterns.StrategyPattern.Units;
using Simon8029.DesignPatterns.StrategyPattern.Weapons;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon machineGun = new MachineGun();
            IBehavior landBehavior = new LandBehavior();
            Unit ryan = new Unit("Ryan",  machineGun,landBehavior);
            ryan.Move(50, 50);
            ryan.Attack(100, 100);

            Unit ben = new Unit("Ben",machineGun,landBehavior);
            ben.Move(1000, 1000);
            ben.Attack(50,50);

            ben.Weapon = new Cannon();
            Console.WriteLine("Ben changes weapon.");
            ben.Attack(50,50);
        }
    }
}
