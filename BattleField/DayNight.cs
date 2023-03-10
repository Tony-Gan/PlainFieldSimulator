using System.Collections.Generic;

namespace PlainFieldSimulator.BattleField
{
    public abstract class DayNight
    {
        // 方格特效补正
        // 物理伤害倍率，魔法伤害倍率，命中倍率，闪避倍率，移动加值
        private Dictionary<string, double> dayNightFix;

        // 持续回合
        private readonly int roundCount;

        // 标准名
        private string formalName = "Undefined";

        public DayNight(Dictionary<string, double> dayNightFix, int roundCount)
        {
            this.dayNightFix = dayNightFix;
            this.roundCount = roundCount;
        }

        public Dictionary<string, double> DayNightFix { get { return dayNightFix; } set { dayNightFix = value; } }
        public int RoundCount { get { return roundCount; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }
        public double GetPhyDmgRate() { return DayNightFix["phyDmgRate"]; }
        public double GetMgcDmgRate() { return DayNightFix["mgcDmgRate"]; }
        public double GetAccuracyRate() { return DayNightFix["accuracyRate"]; }
        public double GetDodgeRate() { return DayNightFix["dodgeRate"]; }
    }

    public class Daytime : DayNight
    {
        public Daytime()
            : base(new Dictionary<string, double> { }, 99)
        {
            DayNightFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
            };
            FormalName = "Daytime";
        }
    }

    public class Night : DayNight
    {
        public Night()
            : base(new Dictionary<string, double> { }, 99)
        {
            DayNightFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 0.9 },
                { "dodgeRate", 1.1 },
            };
            FormalName = "Night";
        }
    }
}
