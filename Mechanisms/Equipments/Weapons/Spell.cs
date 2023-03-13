namespace PlainFieldSimulator.Equipments.Weapons
{
    // 需要吟唱
    public abstract class Spell : Weapon
    {
        public Spell(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            IsReady = false;
            CurrCastRound = 0;
            WeaponType = "Spell";
            FormalName = "Spell";
        }
    }

    public class IceSpike : Spell
    {
        public IceSpike()
            : base(2, 5, 2, 1, 0, 0, 1.2, 1.2, 1)
        {
            FormalName = "Ice Spike";
            MaxCount = 2;
            CurrCount = 2;
            CastRound = 2;
        }
    }

    public class FireBall : Spell
    {
        public FireBall()
            : base(2, 8, 2, 0.7, 0, 0, 0.7, 1.8, 1)
        {
            FormalName = "Fire Ball";
            MaxCount = 2;
            CurrCount = 2;
            CastRound = 2;
        }
    }

    public class StarLight : Spell
    {
        public StarLight()
            : base(3, 8, 1, 1, 0.5, 0, 1, 1.4, 1)
        {
            FormalName = "Star Light";
            MaxCount = 2;
            CurrCount = 2;
            CastRound = 2;
        }
    }
}

