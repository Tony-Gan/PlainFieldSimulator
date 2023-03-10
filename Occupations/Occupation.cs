using System.Collections.Generic;
using PlainFieldSimulator.Abilities;

namespace PlainFieldSimulator.Occupations
{
    // 职业类
    public abstract class Occupation
    {
        // 转职加成，等级1职业无法享受加成
        // HP，物攻，魔攻，物防，魔防，敏捷，技术，移速
        private readonly Dictionary<string, int> attrsAddOn;

        // 成长率修正
        // HP，物攻，魔攻，物防，魔防，敏捷，技术
        private readonly Dictionary<string, double> occupationGrowthFix;

        // 职业等级，决定了能够装备的武器和盔甲
        private readonly int occupationLevel;

        // 上级职业
        private readonly List<string> upperOccupation;

        // 下级职业
        private readonly List<string> lowerOccupation;

        // 可用武器类型
        private List<string> availableWeapons;

        // 可用防具类型
        private List<string> availableArmor;

        // 是否为空中单位
        private readonly bool isFlying;

        // 是否为骑乘单位
        private readonly bool isRiding;

        // 自身类名
        private readonly string className = "";

        // 职业技能
        private List<Ability> occupationAbility = new();

        // 性别限制 0无 1男 2女
        private int genderLimitation = 0;

        // 标准名
        private string formalName = "No Occupation";

        protected Occupation(Dictionary<string, int> attrsAddOn, Dictionary<string, double> occupationGrowthFix, int occupationLevel, List<string> upperOccupation, List<string> lowerOccupation, List<string> availableWeapons, List<string> availableArmor, bool isFlying, bool isRiding)
        {
            this.attrsAddOn = attrsAddOn;
            this.occupationGrowthFix = occupationGrowthFix;
            this.occupationLevel = occupationLevel;
            this.upperOccupation = upperOccupation;
            this.lowerOccupation = lowerOccupation;
            this.availableWeapons = availableWeapons;
            this.availableArmor = availableArmor;
            this.isFlying = isFlying;
            this.isRiding = isRiding;

        }

        public Dictionary<string, int> AttrsAddOn { get { return attrsAddOn; } }
        public int GetHpAddOn() { return AttrsAddOn["hp"]; }
        public int GetAtkAddOn() { return AttrsAddOn["atk"]; }
        public int GetSatkAddOn() { return AttrsAddOn["atk"]; }
        public int GetDefAddOn() { return AttrsAddOn["def"]; }
        public int GetSdefAddOn() { return AttrsAddOn["sdef"]; }
        public int GetDexAddOn() { return AttrsAddOn["dex"]; }
        public int GetTechAddOn() { return AttrsAddOn["tech"]; }
        public int GetMoveAddOn() { return AttrsAddOn["move"]; }
        public Dictionary<string, double> OccupationGrowthFix { get {  return occupationGrowthFix; } }
        public double GetOccupationAtkGrowth() { return this.OccupationGrowthFix["atk"]; }
        public double GetOccupationSatkGrowth() { return this.OccupationGrowthFix["satk"]; }
        public double GetOccupationDefGrowth() { return this.OccupationGrowthFix["def"]; }
        public double GetOccupationSdefGrowth() { return this.OccupationGrowthFix["sdef"]; }
        public double GetOccupationDexGrowth() { return this.OccupationGrowthFix["dex"]; }
        public double GetOccupationTechGrowth() { return this.OccupationGrowthFix["tech"]; }
        public double GetOccupationHpGrowth() { return this.OccupationGrowthFix["hp"]; }
        public int OccupationLevel { get { return occupationLevel; } }
        public List<string> UpperOccupation { get { return upperOccupation; } }
        public List<string> LowerOccupation { get { return lowerOccupation; } }
        public List<string> AvailableWeapons { get { return availableWeapons; } set { availableWeapons = value; } }
        public List<string> AvailableArmors { get { return availableArmor; } set { availableArmor = value; } }
        public bool IsFlying { get {  return isFlying; } }
        public bool IsRiding { get {  return isRiding; } }
        public string ClassName { get { return className; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }
        public List<Ability> OccupationAbility { get { return occupationAbility; } set { occupationAbility = value; } }
        public int GenderLimitation { get { return genderLimitation; } set {  genderLimitation = value; } }
    }
}
