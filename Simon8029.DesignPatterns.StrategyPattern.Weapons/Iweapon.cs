namespace Simon8029.DesignPatterns.StrategyPattern.Weapons
{
    public interface IWeapon
    {
        string Name { get; }
        void Attack(  int x, int y);
    }
}