namespace PlainFieldSimulator.Equipments.Armors
{
    public abstract class LeatherArmor : Armor
    {
        public LeatherArmor(int def, double phyDmgRatio, int sdef, double mgcDmgRatio, int dex, int tech, int move, double criticalRateAdjustRate, int level)
            : base(def, phyDmgRatio, sdef, mgcDmgRatio, dex, tech, move, criticalRateAdjustRate, level)
        {
            ArmorType = "LeatherArmor";
            FormalName = "LeatherArmor";
        }
    }

    public class TrainingLeatherArmor : LeatherArmor
    {
        public TrainingLeatherArmor()
            : base(1, 1, 2, 1, -1, 0, 0, 0.98, 1)
        {
            FormalName = "Training Leather Armor";
        }
    }
}
