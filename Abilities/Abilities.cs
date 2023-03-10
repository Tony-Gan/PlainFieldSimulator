using System.Collections.Generic;

namespace PlainFieldSimulator.Abilities
{
    public abstract class Ability
    {
        // 七维加成
        // HP，攻击，物防，魔防，敏捷，技术，移动
        private Dictionary<string, int> abilityAddOn = new()
        {
            { "extraMaxHp", 0 },
            { "extraAtk", 0 },
            { "extraSatk", 0 },
            { "extraDef", 0 },
            { "extraSdef", 0 },
            { "extraDex", 0 },
            { "extraTech", 0 },
            { "extraMove", 0 },
        };

        // 其他修正率
        // 物理伤害系数，魔法伤害系数，闪避系数，暴击系数，命中系数，经验获取系数
        private Dictionary<string, double> abilityRate = new()
        {
            { "phyDmgRate", 1 },
            { "mgcDmgRate", 1 },
            { "dodgeRate", 1 },
            { "criticalRate", 1 },
            { "accuracyRate", 1 },
            { "expRate", 1 },
        };

        // 特殊修正
        private Dictionary<string, double> abilitySpecialFix = new()
        {
            { "hpGrowthAddOn", 0 },
            { "atkGrowthAddOn", 0 },
            { "satkGrowthAddOn", 0 },
            { "defGrowthAddOn", 0 },
            { "sdefGrowthAddOn", 0 },
            { "dexGrowthAddOn", 0 },
            { "techGrowthAddOn", 0 },
        };

        // 战场修正类型 1攻击 2反击 3防御
        private bool[] effectType = new bool[3] { false, false, false };

        // 战斗修正
        private Dictionary<string, double> abilityBattleFix = new();

        // 标准名
        private string formalName = "Ability";

        // 特性描述
        private string abilityDescription = "";

        // 效果描述
        private string effectsDescription = "";

        public Ability()
        {
        }

        public override string ToString()
        {
            return FormalName;
        }

        public bool Equals(Ability a)
        {
            return a.FormalName == FormalName;
        }

        public Dictionary<string, int> AbilityAddOn { get { return abilityAddOn; } set { abilityAddOn = value; } }
        public Dictionary<string, double> AbilityRate { get { return abilityRate; } set { abilityRate = value; } }
        public Dictionary<string, double> AbilitySpecialFix { get { return abilitySpecialFix; } set { abilitySpecialFix = value; } }
        public bool[] EffectType { get { return effectType; } set { effectType = value; } }
        public Dictionary<string, double> AbilityBattleFix { get { return abilityBattleFix; } set { abilityBattleFix = value; } }
        public string AbilityDescription { get { return abilityDescription; } set { abilityDescription = value; } }
        public string EffectsDescription { get { return effectsDescription; } set { effectsDescription = value; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }
    }

    public class Robust : Ability
    {
        public Robust()
            : base()
        {
            AbilityAddOn["extraMaxHp"] += 5;
            FormalName = "Robust";
            AbilityDescription = "体格强壮，皮糙肉厚";
            EffectsDescription = "HP上限+5";
        }
    }

    public class Fast : Ability
    {
        public Fast()
            : base()
        {
            AbilityAddOn["extraDex"] += 2;
            FormalName = "Fast";
            AbilityDescription = "行动灵敏";
            EffectsDescription = "DEX+3";
        }
    }

    public class Strong : Ability
    {
        public Strong()
            : base()
        {
            AbilityAddOn["extraAtk"] += 2;
            FormalName = "Strong";
            AbilityDescription = "强壮，打人很疼";
            EffectsDescription = "ATK+2";
        }
    }

    public class Clever : Ability
    {
        public Clever()
            : base()
        {
            AbilityAddOn["extraSatk"] += 2;
            FormalName = "Clever";
            AbilityDescription = "比一般人要聪明";
            EffectsDescription = "SATK+2";
        }
    }

    public class Tough : Ability
    {
        public Tough()
            : base()
        {
            AbilityAddOn["extraDef"] += 1;
            AbilityAddOn["extraSdef"] += 1;
            FormalName = "Tough";
            AbilityDescription = "坚实的肌肉看起来很耐打";
            EffectsDescription = "DEF+1, SDEF+1";
        }
    }

    public class Endurable : Ability
    {
        public Endurable()
            : base()
        {
            AbilityAddOn["extraMove"] += 1;
            FormalName = "Endurable";
            AbilityDescription = "耐力强，适合长途跋涉";
            EffectsDescription = "MOVE+1";
        }
    }

    public class Genious : Ability
    {
        public Genious()
            : base()
        {
            AbilitySpecialFix["hpGrowthAddOn"] += 0.15;
            AbilitySpecialFix["atkGrowthAddOn"] += 0.15;
            AbilitySpecialFix["satkGrowthAddOn"] += 0.15;
            AbilitySpecialFix["defGrowthAddOn"] += 0.15;
            AbilitySpecialFix["sdefGrowthAddOn"] += 0.15;
            AbilitySpecialFix["dexGrowthAddOn"] += 0.15;
            AbilitySpecialFix["techGrowthAddOn"] += 0.15;
            FormalName = "Genious";
            AbilityDescription = "难得一遇的天才";
            EffectsDescription = "全属性成长+0.15";
        }
    }

    public class Talented : Ability
    {
        public Talented()
            : base()
        {
            AbilitySpecialFix["hpGrowthAddOn"] += 0.05;
            AbilitySpecialFix["atkGrowthAddOn"] += 0.05;
            AbilitySpecialFix["satkGrowthAddOn"] += 0.05;
            AbilitySpecialFix["defGrowthAddOn"] += 0.05;
            AbilitySpecialFix["sdefGrowthAddOn"] += 0.05;
            AbilitySpecialFix["dexGrowthAddOn"] += 0.05;
            AbilitySpecialFix["techGrowthAddOn"] += 0.05;
            FormalName = "Talented";
            AbilityDescription = "是一个难得的聪明人";
            EffectsDescription = "全属性成长+0.05";
        }
    }

    public class DifficultyModifier1 : Ability
    {
        public DifficultyModifier1()
            : base()
        {
            AbilitySpecialFix["hpGrowthAddOn"] += 0.1;
            AbilitySpecialFix["atkGrowthAddOn"] += 0.1;
            AbilitySpecialFix["satkGrowthAddOn"] += 0.1;
            AbilitySpecialFix["defGrowthAddOn"] += 0.1;
            AbilitySpecialFix["sdefGrowthAddOn"] += 0.1;
            AbilitySpecialFix["dexGrowthAddOn"] += 0.1;
            AbilitySpecialFix["techGrowthAddOn"] += 0.1;
            FormalName = "Difficulty: ExtraHard";
            AbilityDescription = "难度调整：极难";
            EffectsDescription = "全属性成长+0.1";
        }
    }

    public class ExtraDifficultyModifier1 : Ability
    {
        public ExtraDifficultyModifier1()
            : base()
        {
            EffectType[0] = true;
            EffectType[1] = true;
            EffectType[2] = true;
            AbilityBattleFix["phyDmgRate"] = 1.05;
            AbilityBattleFix["mgcDmgRate"] = 1.05;
            AbilityBattleFix["phyDmgReduceRate"] = 1.05;
            AbilityBattleFix["mgcDmgReduceRate"] = 1.05;
            FormalName = "Difficulty: Hard";
            AbilityDescription = "难度调整：极难";
            EffectsDescription = "伤害率+5%，减伤率+5%";
        }
    }


    public class DifficultyModifier2 : Ability
    {
        public DifficultyModifier2()
            : base()
        {
            AbilitySpecialFix["hpGrowthAddOn"] += 0.05;
            AbilitySpecialFix["atkGrowthAddOn"] += 0.05;
            AbilitySpecialFix["satkGrowthAddOn"] += 0.05;
            AbilitySpecialFix["defGrowthAddOn"] += 0.05;
            AbilitySpecialFix["sdefGrowthAddOn"] += 0.05;
            AbilitySpecialFix["dexGrowthAddOn"] += 0.05;
            AbilitySpecialFix["techGrowthAddOn"] += 0.05;
            FormalName = "Difficulty: Hard";
            AbilityDescription = "难度调整：困难";
            EffectsDescription = "全属性成长+0.05";
        }
    }

    public class DifficultyModifier3 : Ability
    {
        public DifficultyModifier3()
            : base()
        {
            AbilitySpecialFix["hpGrowthAddOn"] -= 0.05;
            AbilitySpecialFix["atkGrowthAddOn"] -= 0.05;
            AbilitySpecialFix["satkGrowthAddOn"] -= 0.05;
            AbilitySpecialFix["defGrowthAddOn"] -= 0.05;
            AbilitySpecialFix["sdefGrowthAddOn"] -= 0.05;
            AbilitySpecialFix["dexGrowthAddOn"] -= 0.05;
            AbilitySpecialFix["techGrowthAddOn"] -= 0.05;
            FormalName = "Difficulty: Easy";
            AbilityDescription = "难度调整：简单";
            EffectsDescription = "全属性成长-0.05";
        }
    }
    
}
