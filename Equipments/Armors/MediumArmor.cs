namespace PlainFieldSimulator.Equipments.Armors
{
    public abstract class MediumArmor : Armor
    {
        public MediumArmor(int def, double phyDmgRatio, int sdef, double mgcDmgRatio, int dex, int tech, int move, double criticalRateAdjustRate, int level)
            : base(def, phyDmgRatio, sdef, mgcDmgRatio, dex, tech, move, criticalRateAdjustRate, level)
        {
            ArmorType = "MediumArmor";
            FormalName = "MediumArmor";
        }
    }

    public class TrainingMediumArmor : MediumArmor
    {
        public TrainingMediumArmor()
            : base(3, 1, 2, 1, -2, -2, 0, 1, 1)
        {
            FormalName = "Training Medium Armor";
        }
    }

    public class Cuirass : MediumArmor
    {
        public Cuirass()
            : base(5, 1, 3, 1.05, -3, -3, 0, 1, 2)
        {
            FormalName = "Cuirass";
        }
    }

    public class ChainMail : MediumArmor
    {
        public ChainMail()
            : base(3, 1, 4, 1, -2, -2, 0, 1, 2)
        {
            FormalName = "Chain Mail";
        }
    }
}
