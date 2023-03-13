using System.Collections.Generic;

namespace PlainFieldSimulator.BattleField
{
    public abstract class CellSpell
    {
        // 方格特效补正
        // 物理伤害倍率，魔法伤害倍率，命中倍率，闪避倍率，移动加值
        private Dictionary<string, double> cellSpellFix;

        // 持续回合
        private readonly int roundCount;

        // 标准名
        private string formalName = "Undefined";

        public CellSpell(Dictionary<string, double> cellSpellFix, int roundCount)
        {
            this.cellSpellFix = cellSpellFix;
            this.roundCount = roundCount;
        }

        public Dictionary<string, double> CellSpellFix { get { return cellSpellFix; } set { cellSpellFix = value; } }
        public int RoundCount { get { return roundCount; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }
        public double GetPhyDmgRate() { return CellSpellFix["phyDmgRate"]; }
        public double GetMgcDmgRate() { return CellSpellFix["mgcDmgRate"]; }
        public double GetAccuracyRate() { return CellSpellFix["accuracyRate"]; }
        public double GetDodgeRate() { return CellSpellFix["dodgeRate"]; }
        public double GetMoveFix() { return CellSpellFix["moveFix"]; }
    }

    public class NoSpell : CellSpell
    {
        public NoSpell()
            : base(new Dictionary<string, double> { }, 99)
        {
            CellSpellFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "No Cell Spell";
        }
    }
}
