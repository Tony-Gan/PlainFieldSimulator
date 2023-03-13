namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Knife : Weapon
    {
        public Knife(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Knife";
            FormalName = "Knife";
        }
    }

    public class ShortKnife : Knife
    {
        public ShortKnife()
            : base(1, 1, 2, 1, 0, 1, 0.9, 1.6, 1)
        {
            FormalName = "Short Knife";
        }
    }

    public class IronDagger : Knife
    {
        public IronDagger()
            : base(1, 4, 1, 1, 0, 2, 0.9, 1.8, 1)
        {
            FormalName = "Iron Dagger";
        }
    }
}
