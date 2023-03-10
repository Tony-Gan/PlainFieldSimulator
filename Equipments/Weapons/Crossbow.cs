namespace PlainFieldSimulator.Equipments.Weapons
{
    // 每次攻击完成后需要站立一回合上弹
    public abstract class Crossbow : Weapon
    {
        public Crossbow(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            IsReady = true;
            WeaponType = "Crossbow";
            FormalName = "Crossbow";
        }
    }

    public class MiniCrossbow : Crossbow
    {
        public MiniCrossbow()
            : base(1, 8, 1, 0.95, 0, 5, 1.1, 1.7, 1)
        {
            FormalName = "Mini Crossbow";
        }
    }

    public class WoodCrossbow : Crossbow
    {
        public WoodCrossbow()
            : base(1, 11, 2, 0.95, 0, 5, 1.2, 1.5, 1)
        {
            FormalName = "Wood Crossbow";
        }
    }
}
