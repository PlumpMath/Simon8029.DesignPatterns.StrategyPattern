


using Simon8029.DesignPatterns.StrategyPattern.Units;
using Simon8029.DesignPatterns.StrategyPattern.Weapons;

namespace Simon8029.DesignPatterns.StrategyPattern.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit ryan = new Unit("Ryan", new LandBehavior(), new MachineGun());
            ryan.Move(50, 50);
            ryan.Attack(100, 100);
        }
    }
}
