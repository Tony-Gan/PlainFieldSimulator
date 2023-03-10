namespace PlainFieldSimulator.Equipments.Armors
{
    public abstract class HeavyArmor : Armor
    {
        public HeavyArmor(int def, double phyDmgRatio, int sdef, double mgcDmgRatio, int dex, int tech, int move, double criticalRateAdjustRate, int level)
            : base(def, phyDmgRatio, sdef, mgcDmgRatio, dex, tech, move, criticalRateAdjustRate, level)
        {
            ArmorType = "HeavyArmor";
            FormalName = "HeavyArmor";
        }
    }

    public class TrainingHeavyArmor : HeavyArmor
    {
        public TrainingHeavyArmor()
            : base(5, 0.9, 0, 1, -3, -3, 0, 1, 1)
        {
            FormalName = "Training Heavy Armor";
        }
    }

    public class PlateArmor : HeavyArmor
    {
        public PlateArmor()
            : base(9, 0.85, -1, 1, -5, -4, 0, 0.95, 1)
        {
            FormalName = "Plate Armor";
        }
    }
}
