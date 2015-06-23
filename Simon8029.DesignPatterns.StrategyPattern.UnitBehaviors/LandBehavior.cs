using System;

namespace Simon8029.DesignPatterns.StrategyPattern.Units
{
    public class LandBehavior:IBehavior
    {
        public void Move(int x, int y)
        {
            Console.WriteLine("Move to ({0}, {1})", x, y);

        }
    }
}