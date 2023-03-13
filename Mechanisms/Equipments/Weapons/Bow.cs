namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Bow : Weapon
    {
        public Bow(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Bow";
            FormalName = "Bow";
        }
    }

    public class MiniBow : Bow
    {
        public MiniBow()
            : base(1, 3, 1, 1.1, 0, 4, 1, 1.5, 1)
        {
            FormalName = "Mini Bow";
        }
    }

    public class IronBow : Bow
    {
        public IronBow()
            : base(1, 5, 2, 0.95, 0, 6, 1, 1.5, 1)
        {
            FormalName = "Iron Bow";
        }
    }
}
