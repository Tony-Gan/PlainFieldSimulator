namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Axe : Weapon
    {
        public Axe(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Axe";
            FormalName = "Axe";
        }
    }

    public class IronAxe : Axe
    {
        public IronAxe()
            : base(1, 10, 1, 0.8, 0, 9, 1, 1.5, 1)
        {
            FormalName = "Iron Axe";
        }
    }

    public class HandAxe : Axe
    {
        public HandAxe()
            : base(1, 7, 2, 0.7, 0, 7, 1, 1.5, 1)
        {
            FormalName = "Hand Axe";
        }
    }
}
