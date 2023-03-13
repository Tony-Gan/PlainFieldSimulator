namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Sword : Weapon
    {
        public Sword(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Sword";
            FormalName = "Sword";
        }
    }

    public class SlimSword : Sword
    {
        public SlimSword()
            : base(1, 2, 1, 1.1, 0, 3, 1, 1.5, 1)
        {
            FormalName = "Slim Sword";
        }
    }

    public class IronSword : Sword
    {
        public IronSword()
            : base(1, 5, 1, 0.95, 0, 3, 1, 1.5, 1)
        {
            FormalName = "Iron Sword";
        }
    }

    public class AirBlade : Sword
    {
        public AirBlade()
            : base(2, 1, 1, 1.1, 0, 1, 1, 1.5, 1)
        {
            FormalName = "Air Blade";
        }
    }
}
