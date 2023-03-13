using System.Collections.Generic;
using PlainFieldSimulator.BattleField;

namespace PlainFieldSimulator.Equipments.Weapons
{
    public abstract class Weapon
    {
        // 类型，1物理，2魔法，3治疗
        private readonly int type;

        // 伤害加值
        private readonly int dmg;

        // 范围
        private readonly int range;

        // 命中系数
        private readonly double hit;

        // 治疗系数
        private readonly double healingRate;

        // 重量加值
        private readonly int weight;

        // 暴击系数
        private readonly double criticalRate;

        // 暴击伤害系数
        private readonly double criticalDmg;

        // 装备单位职业等级
        private readonly int level;

        // 武器类型
        private string weaponType = "NoWeapon";

        // 额外对重甲特效
        private bool effectiveToHeavyarmor = false;

        // 额外对飞行特效
        private bool effectiveToFlying = false;

        // 额外对骑兵特效
        private bool effectiveToRider = false;

        // 额外对魔法特效
        private bool effectiveToMagic = false;

        // 标准名
        private string formalName = "No Weapon";

        // 是否上弹/是否吟唱完毕 (弩类/法术专属)
        private bool? isReady;

        // 全武器克制概率 (爪类专属)
        private double? weaponResistRate;

        // 武器克制加成 (爪类专属)
#nullable enable
        Dictionary<string, double>? weaponResistFix;

        // 最大使用次数（法术专用）
        private int? maxCount;

        // 当前使用次数（法术专用）
        private int? currCount;

        // 吟唱时间 (法术专用)
        private int? castRound;

        // 当前吟唱回合 (法术专用)
        private int? currCastRound;

        // 环境改变能力
        private CellSpell weaponCellSpell = new NoSpell();

        // 环境改变范围
        private int cellSpellRange = 0;

        // 环境改变时间
        private int cellSpellRound = 0;

        protected Weapon(int type, int dmg, int range, double hit, double healingRate, int weight, double criticalRate, double criticalDmg, int level)
        {
            this.type = type;
            this.dmg = dmg;
            this.range = range;
            this.weight = weight;
            this.hit = hit;
            this.healingRate = healingRate;
            this.criticalRate = criticalRate;
            this.criticalDmg = criticalDmg;
            this.level = level;
        }

        public override bool Equals(object obj)
        {
            if (obj is Weapon w)
            {
                return FormalName == w.FormalName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int Type { get { return type; } }
        public int Dmg { get {  return dmg; } }
        public int Range { get { return range; } }
        public double Hit { get { return hit; } }
        public double HealingRate { get { return healingRate; } }
        public int Weight { get {  return weight; } }
        public double CriticalRate { get { return criticalRate; } }
        public double CriticalDmg { get { return criticalDmg; } }
        public int Level { get { return level; } }
        public string WeaponType { get { return weaponType; } set { weaponType = value; } }
        public bool EffectiveToHeavyarmor { get { return effectiveToHeavyarmor; } set { effectiveToHeavyarmor = value; } }
        public bool EffectiveToFlying { get { return effectiveToFlying; } set { effectiveToFlying = value; } }
        public bool EffectiveToRider { get { return effectiveToRider; } set { effectiveToRider = value; } }
        public bool EffectiveToMagic { get { return effectiveToMagic; } set { effectiveToMagic = value; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }
        public bool? IsReady { get { return isReady; } set { isReady = value; } }
        public double? WeaponResistRate { get { return weaponResistRate; } set { weaponResistRate = value; } }
#nullable enable
        public Dictionary<string, double>? WeaponResistFix { get { return weaponResistFix; } set { weaponResistFix = value; } }
        public int? MaxCount { get { return maxCount; } set {  maxCount = value; } }
        public int? CurrCount { get { return currCount; } set { currCount = value; } }
        public int? CastRound { get { return castRound; } set {  castRound = value; } }
        public int? CurrCastRound { get { return currCastRound; } set { currCastRound = value; } }
        public CellSpell WeaponCellSpell { get { return weaponCellSpell; } set { weaponCellSpell = value; } }
        public int CellSpellRange { get { return cellSpellRange; } set { cellSpellRange = value; } }
        public int CellSpellRound { get { return cellSpellRound; } set { cellSpellRound = value; } }

        public void PutCellSpell(Cell cell)
        {
            cell.CellSpell = WeaponCellSpell;
            cell.SpellRound = CellSpellRound;
        }
    }

    public class NoWeapon : Weapon
    {
        public NoWeapon()
            : base(1, 0, 0, 1, 0, 0, 1, 1, 0)
        {
            WeaponType = "NoWeapon";
            FormalName = "No Weapon";
        }
    }
}
