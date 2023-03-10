namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Spike : Weapon
    {
        public Spike(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Spike";
            FormalName = "Spile";
        }
    }

    public class SlimSpike : Spike
    {
        public SlimSpike()
            : base(1, 5, 1, 1, 0, 5, 1, 1.5, 1)
        {
            FormalName = "Slim Spike";
        }
    }

    public class IronSpike : Spike
    {
        public IronSpike()
            : base(1, 7, 1, 1, 0.9, 7, 1, 1.5, 1)
        {
            FormalName = "Iron Spike";
        }
    }

    public class Ridersbane : Spike
    {
        public Ridersbane()
            : base(1, 7, 1, 1, 0.7, 7, 1, 1.5, 1)
        {
            EffectiveToRider = true;
            FormalName = "Ridersbane";
        }
    }
}
