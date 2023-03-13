namespace PlainFieldSimulator.Equipments.Armors
{
    public abstract class LightArmor : Armor
    {
        public LightArmor(int def, double phyDmgRatio, int sdef, double mgcDmgRatio, int dex, int tech, int move, double criticalRateAdjustRate, int level) 
            : base(def, phyDmgRatio, sdef, mgcDmgRatio, dex, tech, move, criticalRateAdjustRate, level)
        {
            ArmorType = "LightArmor";
            FormalName = "LightArmor";
        }
    }

    public class TrainingLightArmor : LightArmor
    {
        public TrainingLightArmor() 
            : base(2, 1, 2, 1, -1, -1, 0, 1, 1)
        {
            FormalName = "Training Light Armor";
        }
    }
}
