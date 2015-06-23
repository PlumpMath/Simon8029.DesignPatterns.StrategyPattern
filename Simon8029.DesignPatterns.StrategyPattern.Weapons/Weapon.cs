namespace Simon8029.DesignPatterns.StrategyPattern.Weapons
{
    public abstract class Weapon:IWeapon
    {


        public abstract void Attack(Unit unit, int x, int y);
    }
}