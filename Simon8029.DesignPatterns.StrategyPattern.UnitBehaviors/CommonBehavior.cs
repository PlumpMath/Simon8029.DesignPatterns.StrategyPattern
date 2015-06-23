namespace Simon8029.DesignPatterns.StrategyPattern.Units
{
    public abstract class CommonBehavior : IBehavior

    {
        public abstract void Move(int x, int y);
    }
}