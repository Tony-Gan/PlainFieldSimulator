namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Tome : Weapon
    {
        public Tome(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Tome";
            FormalName = "Tome";
        }
    }

    public class Fire : Tome
    {
        public Fire()
            : base(2, 4, 2, 1, 0, 2, 0.8, 1.2, 1)
        {
            FormalName = "Fire";
        }
    }

    public class Thunder : Tome
    {
        public Thunder()
            : base(2, 3, 3, 1, 0, 2, 0.6, 1.2, 1)
        {
            FormalName = "Thunder";
        }
    }

    public class Surge : Tome
    {
        public Surge()
            : base(1, 3, 3, 1.5, 0, 4, 0.8, 1.5, 1)
        {
            FormalName = "Surge";
        }
    }
}
