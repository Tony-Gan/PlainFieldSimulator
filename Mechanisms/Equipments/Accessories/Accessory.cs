using System.Collections.Generic;

namespace PlainFieldSimulator.Equipments.Accessories
{
    public abstract class Accessory
    {
        // 物攻加值
        private readonly int atk;

        // 魔攻加值
        private readonly int satk;

        // 物防加值
        private readonly int def;

        // 魔防加值
        private readonly int sdef;

        // 敏捷加值
        private readonly int dex;

        // 技术加值
        private readonly int tech;

        // 移动力加值
        private readonly int move;

        // 最终伤害修正
        private readonly double dmgRate;

        // 命中修正
        private readonly double accuracy;

        // 闪避修正
        private readonly double dodge;

        // 暴击修正
        private readonly double critical;

        // 暴击伤害修正
        private readonly double criticalDmgRate;

        // 抗暴击修正
        private readonly double criticalRateAdjustRate;

        // 成长修正
        private Dictionary<string, double> growthFix;

        // 每回合回复量
        private readonly int recovory;

        // 标准名
        private string formalName = "No Accessory";

        protected Accessory(int atk, int satk, int def, int sdef, int dex, int tech, int move, double dmgRate, double accuracy, double dodge, double critical, double criticalDmgRate, double criticalRateAdjustRate, Dictionary<string, double> growthFix, int recovory)
        {
            this.atk = atk;
            this.satk = satk;
            this.def = def;
            this.sdef = sdef;
            this.dex = dex;
            this.tech = tech;
            this.move = move;
            this.dmgRate = dmgRate;
            this.accuracy = accuracy;
            this.dodge = dodge;
            this.critical = critical;
            this.criticalDmgRate = criticalDmgRate;
            this.criticalRateAdjustRate = criticalRateAdjustRate;
            this.growthFix = growthFix;
            this.recovory = recovory;
        }

        public int Atk { get { return atk; } }
        public int Satk { get { return satk; } }
        public int Def { get { return def; } }
        public int Sdef { get {  return sdef; } }
        public int Dex { get { return dex; } }
        public int Tech { get {  return tech; } }
        public int Move { get { return move; } }
        public double DmgRate { get { return dmgRate; } }
        public double Accuracy { get { return accuracy; } }
        public double Dodge { get {  return dodge; } }
        public double Critical { get { return critical; } }
        public double CriticalDmgRate { get { return criticalDmgRate; } }
        public double CriticalRateAdjustRate { get { return criticalRateAdjustRate; } }
        public Dictionary<string, double> GrowthFix { get { return growthFix; } set { growthFix = value; } }
        public int Recovery { get { return recovory; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }

        public override bool Equals(object obj)
        {
            if (obj is Accessory w)
            {
                return FormalName == w.FormalName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public class NoAccessory : Accessory
    {
        public NoAccessory()
            : base(0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, new Dictionary<string, double> { }, 0)
        {
            GrowthFix = new Dictionary<string, double>
            {
                { "hp", 0 },
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
            };
            FormalName = "No Accessory";
        }
    }
}
