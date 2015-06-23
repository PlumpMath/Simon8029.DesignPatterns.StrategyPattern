

namespace Simon8029.DesignPatterns.StrategyPattern.Units
{
    public class Unit : IUnit
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }


        public Unit(string name)
        {
            Name = name;

        }


    }
}