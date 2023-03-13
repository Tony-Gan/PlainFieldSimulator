namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Stave : Weapon
    {
        public Stave(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
            : base(type, dmg, range, hit, healingRate, weight, criticalRate, criticalDmg, level)
        {
            WeaponType = "Stave";
            FormalName = "Stave";
        }
    }

    public class TrainingStave : Stave
    {
        public TrainingStave()
            : base(3, 5, 1, 1, 0.3, 4, 1, 1.2, 1)
        {
            FormalName = "Training Stave";
        }
    }
}

