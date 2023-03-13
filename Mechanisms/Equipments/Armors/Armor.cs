namespace PlainFieldSimulator.Equipments.Armors
{
    public abstract class Armor
    {
        // 物防加值
        private readonly int def;

        // 物伤倍率
        private readonly double phyDmgRatio;

        // 魔防加值
        private readonly int sdef;

        // 魔伤倍率
        private readonly double mgcDmgRatio;

        // 敏捷加值
        private readonly int dex;

        // 技术加值
        private readonly int tech;

        // 移动加值
        private readonly int move;

        // 被暴击率修正系数
        private readonly double criticalRateAdjustRate;

        // 自身类型
        private string armorType = "NoArmor";

        // 装备单位职业等级
        private int level;

        // 标准名
        private string formalName = "No Armor";

        protected Armor(int def, double phyDmgRatio, int sdef, double mgcDmgRatio, int dex, int tech, int move, double criticalRateAdjustRate, int level)
        {
            this.def = def;
            this.phyDmgRatio = phyDmgRatio;
            this.sdef = sdef;
            this.mgcDmgRatio = mgcDmgRatio;
            this.dex = dex;
            this.tech = tech;
            this.move = move;
            this.criticalRateAdjustRate = criticalRateAdjustRate;
            this.level = level;
        }

        public int Def { get { return def; } }
        public double PhyDmgRatio { get { return phyDmgRatio; } }
        public int Sdef { get {  return sdef; } }
        public double MgcDmgRatio { get { return mgcDmgRatio; } }
        public int Dex { get { return dex; } }
        public int Tech { get {  return tech; } }
        public int Move { get { return move; } }
        public double CriticalRateAdjustRate { get { return criticalRateAdjustRate; } }
        public string ArmorType { get { return armorType; } set { armorType = value; } }
        public int Level { get { return level; } set { level = value; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }

    }

    public class NoArmor : Armor
    {
        // 自身类型
        public NoArmor()
            : base(0, 1, 0, 1, 0, 0, 0, 1, 1)
        {
            ArmorType = "NoArmor";
            FormalName = "No Armor";
            Level = 1;
        }
    }
}
