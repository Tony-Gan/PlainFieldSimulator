namespace PlainFieldSimulator.Equipments.Weapons
{
    // 有概率克制全武器
    public abstract class Claw : Weapon
    {
        public Claw(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Claw";
            FormalName = "Claw";
        }
    }

    public class BluntClaw : Claw
    {
        public BluntClaw()
            : base(1, 1, 1, 1.2, 0, 2, 1.05, 1.6, 1)
        {
            FormalName = "Blunt Claw";
            WeaponResistRate = 0.2;
            WeaponResistFix = new()
            {
                { "atk", 1.1 },
                { "accuracy", 1.1 },
                { "criticalRate", 1.05 },
                { "criticalDmgRate", 1.05 },
            };
        }
    }

    public class EthrealClaw : Claw
    {
        public EthrealClaw()
            : base(2, 3, 1, 1.2, 0, 2, 0.7, 1.6, 1)
        {
            FormalName = "Ethreal Claw";
            WeaponResistRate = 0.2;
            WeaponResistFix = new()
            {
                { "atk", 1.1 },
                { "accuracy", 1.1 },
                { "criticalRate", 1.05 },
                { "criticalDmgRate", 1.05 },
            };
        }
    }
}
