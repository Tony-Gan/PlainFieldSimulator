using UnityEngine;
using System;
using System.Collections.Generic;
using PlainFieldSimulator.Equipments.Accessories;
using PlainFieldSimulator.Equipments.Armors;
using PlainFieldSimulator.Equipments.Items;
using PlainFieldSimulator.Equipments.Weapons;
using PlainFieldSimulator.Exceptions;
using PlainFieldSimulator.Occupations;
using PlainFieldSimulator.Abilities;
using PlainFieldSimulator.Missions;

namespace PlainFieldSimulator.Units
{
    /**
     * 游戏中的任意一个单位
     */
    public class Unit
    {
        // 单位名，相同名字的单位会被认为是同一个单位
        private string name;

        // 性别 1男 2女
        private readonly int gender;

        // 单位等级
        private int level;

        // 属性值：最大HP，当前HP，物攻，魔攻，物防，魔防，敏捷，技术，移动，经验
        private Dictionary<string, int> attrs;

        // 成长率：HP，物攻，魔攻，物防，魔防，敏捷，技术
        private Dictionary<string, double> growth;

        // 当前武器
        private Weapon weapon = new NoWeapon();

        // 武器列表
        private List<Weapon> weapons = new();

        // 防具
        private Armor armor = new NoArmor();

        // 配饰
        private Accessory accessory = new NoAccessory();

        // 道具
        private List<Item> inventory = new();

        // 位置
        private Position position = new(-1, -1);

        // 技能修正 - 七维加成及其他修正率
        // 攻击加值，防御加值，物防加值，魔防加值，敏捷加值，技术加值，移动加值
        // 物理伤害倍率，魔法伤害倍率，闪避倍率，暴击倍率，命中倍率，经验获取倍率
        private Dictionary<string, double> fix = new()
        {
            { "extraMaxHp", 0 },
            { "extraAtk", 0 },
            { "extraSatk", 0 },
            { "extraDef", 0 },
            { "extraSdef", 0 },
            { "extraDex", 0 },
            { "extraTech", 0 },
            { "extraMove", 0 },
            { "phyDmgRate", 1 },
            { "mgcDmgRate", 1 },
            { "dodgeRate", 1 },
            { "criticalRate", 1 },
            { "accuracyRate", 1 },
            { "expRate", 1 }
        };

        // 技能
        private List<Ability> abilities = new();

        // 技能修正 - 特殊修正
        private Dictionary<string, double> specialFix = new()
        {
            { "hpGrowthAddOn", 0 },
            { "atkGrowthAddOn", 0 },
            { "satkGrowthAddOn", 0 },
            { "defGrowthAddOn", 0 },
            { "sdefGrowthAddOn", 0 },
            { "dexGrowthAddOn", 0 },
            { "techGrowthAddOn", 0 },
            { "attackRange", 0 }
        };

        // 战场加成 - 攻击和被攻击时读取
        private Dictionary<string, Dictionary<string, double>> battleFix = new()
        {
            { "attack", new Dictionary<string, double>() {
                { "atkAddOn", 0 },
                { "atkRate", 1 },
                { "satkAddOn", 0 },
                { "satkRate", 1 },
                { "defAddOn", 0 },
                { "defRate", 1 },
                { "sdefAddOn", 0 },
                { "sdefRate", 1 },
                { "dexAddOn", 0 },
                { "dexRate", 1 },
                { "techAddOn", 0 },
                { "techRate", 1 },
                { "phyDmgAddOn", 0 },
                { "phyDmgRate", 1 },
                { "mgcDmgAddOn", 0 },
                { "mgcDmgRate", 1 },
                { "phyDmgReduceAddOn", 0 },
                { "phyDmgReduceRate", 1 },
                { "mgcDmgReduceAddOn", 0 },
                { "mgcDmgReduceRate", 1 },
                { "accuracyAddOn", 0 },
                { "accuracyRate", 1 },
                { "dodgeAddOn", 0 },
                { "dodgeRate", 1 },
                { "criticalAddOn", 0 },
                { "criticalRate", 1 },
                { "criticalReduceAddOn", 0 },
                { "criticalReduceRate", 1 },
                { "criticalDmgAddOn", 0 },
                { "criticalDmgRate", 1 },
                { "healingAddOn", 0 },
                { "healingRate", 1 },
                { "closedRangeAddOn", 0},
                { "rangedRangeAddOn", 0},
                { "swordRangeAddOn", 0},
                { "spikeRangeAddOn", 0},
                { "bowRangeAddOn", 0},
                { "crossbowRangeAddOn", 0},
                { "knifeRangeAddOn", 0},
                { "clawRangeAddOn", 0},
                { "tomeRangeAddOn", 0},
                { "staveRangeAddOn", 0},
                { "spellRangeAddOn", 0},
                } 
            },
            { "conterAttack", new Dictionary<string, double> {
                { "atkAddOn", 0 },
                { "atkRate", 1 },
                { "satkAddOn", 0 },
                { "satkRate", 1 },
                { "defAddOn", 0 },
                { "defRate", 1 },
                { "sdefAddOn", 0 },
                { "sdefRate", 1 },
                { "dexAddOn", 0 },
                { "dexRate", 1 },
                { "techAddOn", 0 },
                { "techRate", 1 },
                { "phyDmgAddOn", 0 },
                { "phyDmgRate", 1 },
                { "mgcDmgAddOn", 0 },
                { "mgcDmgRate", 1 },
                { "phyDmgReduceAddOn", 0 },
                { "phyDmgReduceRate", 1 },
                { "mgcDmgReduceAddOn", 0 },
                { "mgcDmgReduceRate", 1 },
                { "accuracyAddOn", 0 },
                { "accuracyRate", 1 },
                { "dodgeAddOn", 0 },
                { "dodgeRate", 1 },
                { "criticalAddOn", 0 },
                { "criticalRate", 1 },
                { "criticalReduceAddOn", 0 },
                { "criticalReduceRate", 1 },
                { "criticalDmgAddOn", 0 },
                { "criticalDmgRate", 1 },
                { "healingAddOn", 0 },
                { "healingRate", 1 },
                { "closedRangeAddOn", 0},
                { "rangedRangeAddOn", 0},
                { "swordRangeAddOn", 0},
                { "spikeRangeAddOn", 0},
                { "bowRangeAddOn", 0},
                { "crossbowRangeAddOn", 0},
                { "knifeRangeAddOn", 0},
                { "clawRangeAddOn", 0},
                { "tomeRangeAddOn", 0},
                { "staveRangeAddOn", 0},
                { "spellRangeAddOn", 0},
                
                } 
            },
            { "defend", new Dictionary<string, double>
            {
                { "atkAddOn", 0 },
                { "atkRate", 1 },
                { "satkAddOn", 0 },
                { "satkRate", 1 },
                { "defAddOn", 0 },
                { "defRate", 1 },
                { "sdefAddOn", 0 },
                { "sdefRate", 1 },
                { "dexAddOn", 0 },
                { "dexRate", 1 },
                { "techAddOn", 0 },
                { "techRate", 1 },
                { "phyDmgAddOn", 0 },
                { "phyDmgRate", 1 },
                { "mgcDmgAddOn", 0 },
                { "mgcDmgRate", 1 },
                { "phyDmgReduceAddOn", 0 },
                { "phyDmgReduceRate", 1 },
                { "mgcDmgReduceAddOn", 0 },
                { "mgcDmgReduceRate", 1 },
                { "accuracyAddOn", 0 },
                { "accuracyRate", 1 },
                { "dodgeAddOn", 0 },
                { "dodgeRate", 1 },
                { "criticalAddOn", 0 },
                { "criticalRate", 1 },
                { "criticalReduceAddOn", 0 },
                { "criticalReduceRate", 1 },
                { "criticalDmgAddOn", 0 },
                { "criticalDmgRate", 1 },
                { "healingAddOn", 0 },
                { "healingRate", 1 },
                { "closedRangeAddOn", 0},
                { "rangedRangeAddOn", 0},
                { "swordRangeAddOn", 0},
                { "spikeRangeAddOn", 0},
                { "bowRangeAddOn", 0},
                { "crossbowRangeAddOn", 0},
                { "knifeRangeAddOn", 0},
                { "clawRangeAddOn", 0},
                { "tomeRangeAddOn", 0},
                { "staveRangeAddOn", 0},
                { "spellRangeAddOn", 0},
            } }
        };

        // 阵营
        private int camp;

        // 仇恨标签，敌方用
        private char triggerLabel = '1';

        // 职业
        private Occupation occupation;

        // 进攻倾向（NPC用）0-100
        private int attackTendency = 0;

        // 撤退倾向（NPC用）0-100
        private int retreatTendency = 0;

        // 基础构造器
        public Unit(string name, int gender, int camp, Dictionary<string, int> attrs, Dictionary<string, double> growth, Occupation occupation) 
        {
            this.name = name;
            this.gender = gender;
            this.attrs = attrs;
            this.growth = growth;
            this.camp = camp;
            this.occupation = occupation;
            foreach (Ability a in occupation.OccupationAbility)
            {
                AddAbility(a);
            }
            Level = 1;
        }

        // 覆写通用方法
        public override string ToString()
        {
            return 
                $"Name: {Name}\n" +
                $"Gender: {(Gender == 1 ? "Male" : "Female")}\n" +
                $"Occupation: {Occupation.FormalName}\n" +
                $"Weapon: {Weapon.FormalName}\n" +
                $"Armor: {Armor.FormalName}\n" +
                $"Accessory: {Accessory.FormalName}\n" +
                $"Inventory: {Inventory}\n" +
                $"Skills: {Abilities}\n" +
                $"\n" +
                $"Attributes: \n" +
                $"\tLevel: {Level}\n" +
                $"\tMax HP: {GetMaxHp()}\n" +
                $"\tAttack: {GetAtk()}\n" +
                $"\tSpe. Attack: {GetSatk()}\n" +
                $"\tDefence: {GetDef()}\n" +
                $"\tSpe. Defence: {GetSdef()}\n" +
                $"\tDexterity: {GetDex()}\n" +
                $"\tTechnique: {GetTech()}\n" +
                $"\tMove: {GetMove()}\n" +
                $"\n" +
                $"Growth Rate:\n" +
                $"\n" +
                $"\tHP: {Math.Round(GetHpGrowthRate(), 2)}\n" +
                $"\tAttack: {Math.Round(GetAtkGrowthRate(), 2)}\n" +
                $"\tSpe. Attack: {Math.Round(GetSatkGrowthRate(), 2)}\n" +
                $"\tDefence: {Math.Round(GetDefGrowthRate(), 2)}\n" +
                $"\tSpe. Defence: {Math.Round(GetSdefGrowthRate(), 2)}\n" +
                $"\tDexterity: {Math.Round(GetDexGrowthRate(), 2)}\n" +
                $"\tTechnique: {Math.Round(GetTechGrowthRate(), 2)}\n" +
                $"";

        }

        public override bool Equals(object obj)
        {
            Unit unitObj = obj as Unit;
            return unitObj.Name == Name;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // 基础Setter和Getter
        public string Name { get { return name; } set { name = value; } }
        public int Gender { get { return gender; } }
        public int Level { get { return level; } set { level = value; } }
        public int Camp { get { return camp; } set { camp = value; } }
        public char TriggerLabel { get { return triggerLabel; } set { triggerLabel = value; } }
        public Dictionary<string, int> Attrs { get { return attrs; } set { attrs = value; } }
        public Dictionary<string, double> Growth { get { return growth; } set { growth = value; } }
        public Dictionary<string, double> Fix { get {  return fix; } set { fix = value; } }
        public Weapon Weapon { get {  return weapon; } set { weapon = value; } }
        public List<Weapon> Weapons { get {  return weapons; } set { weapons = value; } }
        public Position Position { get { return position; } set {  position = value; } }
        public Armor Armor { get {  return armor; } set { armor = value; } }
        public Accessory Accessory { get {  return accessory; } set { accessory = value; } }
        public List<Item> Inventory { get { return inventory; } set {  inventory = value; } }
        public int AttackTendency { get { return attackTendency; } set { attackTendency = value; } }
        public int RetreatTendency { get { return retreatTendency; } set { retreatTendency = value; } }
        public List<Ability> Abilities { get { return abilities; } set { abilities = value; } }
        public Occupation Occupation { get { return occupation; } set { occupation = value; } }
        public Dictionary<string, double> SpecialFix { get { return specialFix; } set { specialFix = value; } }
        public Dictionary<string, Dictionary<string, double>> BattleFix { get { return battleFix; } set { battleFix = value; } }

        // 武器列表中增加新武器，武器不能超过3件，不能拥有相同武器
        public void AddWeapon(Weapon weapon)
        {
            if (Weapons.Count >= 3)
            {
                throw new WeaponListFull("Weapon list full.");
            }
            if (Occupation.OccupationLevel >= weapon.Level)
            {
                foreach (Weapon w in Weapons)
                {
                    if (w.Equals(weapon))
                    {
                        throw new WeaponDuplicated($"{Name} has already own {weapon.FormalName}.");
                    }
                }
                Weapons.Add(weapon);
                if (Weapon.FormalName == "No Weapon" && Occupation.AvailableWeapons.Contains(weapon.WeaponType))
                {
                    Weapon = weapon;
                }
            }
        }

        // 武器列表中移除武器，如果移除的是当前装备的武器，则当前装备的武器会变为无武器
        public void RemoveWeapon(Weapon weapon)
        {
            if (Weapons.Contains(weapon))
            {
                Weapons.Remove(weapon);
            }
            if (Weapon.Equals(weapon))
            {
                Weapon = new NoWeapon();
            }
        }

        // 更换武器
        public void ChangeWeapon(Weapon weapon)
        {
            foreach (Weapon w in Weapons)
            {
                if (w.Equals(weapon))
                {
                    if (Occupation.AvailableWeapons.Contains(weapon.WeaponType) && Occupation.OccupationLevel >= weapon.Level)
                    {
                        Weapon = weapon;
                        break;
                    }
                    else
                    {
                        throw new EquipmentNotAvailable($"{weapon.WeaponType} is not available for this unit.");
                    }
                }
            }
        }
        
        // 装备盔甲
        public void SetArmor(Armor armor)
        {
            if (Occupation.AvailableArmors.Contains(armor.ArmorType) && Occupation.OccupationLevel >= armor.Level)
            {
                Armor = armor;
            }
            else
            {
                throw new EquipmentNotAvailable($"{armor.ArmorType} is not available for this unit.");
            }
        }

        // 给予武器
        public void ProvideWeapon(Unit u, Weapon weapon)
        {
            if (Mission.CalculateDistanceBetweenPositions(Position, u.Position) != 1 || Camp != u.Camp)
            {
                return;
            }
            if (Weapons.Contains(weapon))
            {
                RemoveWeapon(weapon);
                u.AddWeapon(weapon);
            }
        }

        // 获取武器
        public void AcquireWeapon(Unit u, Weapon weapon)
        {
            if (Mission.CalculateDistanceBetweenPositions(Position, u.Position) != 1 || Camp != u.Camp)
            {
                return;
            }
            if (u.Weapons.Contains(weapon))
            {
                u.RemoveWeapon(weapon);
                AddWeapon(weapon);
            }
        }

        // 增加道具
        public void AddItem(Item item)
        {
            Inventory.Add(item);
        }

        // 减少道具
        public void RemoveItem(Item item)
        {
            if (Inventory.Contains(item))
            {
                Inventory.Remove(item);
            }
        }

        // 偷窃道具
        public void StealItem(Unit u, Item item)
        {
            if (Mission.CalculateDistanceBetweenPositions(Position, u.Position) != 1)
            {
                return;
            }
            else
            {
                if (Inventory.Contains(item))
                {
                    u.RemoveItem(item);
                    AddItem(item);
                }
            }
        }

        // 给予道具
        public void ProvideItem(Unit u, Item item)
        {
            if (Mission.CalculateDistanceBetweenPositions(Position, u.Position) != 1 || Camp != u.Camp)
            {
                return;
            }
            else
            {
                if (u.Inventory.Contains(item))
                {
                    RemoveItem(item);
                    u.AddItem(item);
                }
            }
        }

        // 获取道具
        public void AcquireItem(Unit u, Item item)
        {
            if (Mission.CalculateDistanceBetweenPositions(Position, u.Position) != 1 || Camp != u.Camp)
            {
                return;
            }
            else
            {
                if (Inventory.Contains(item))
                {
                    u.RemoveItem(item);
                    AddItem(item);
                }
            }
        }

        // 增加技能
        public void AddAbility(Ability ability)
        {   
            foreach (Ability a in Abilities)
            {
                if (a.Equals(ability))
                {
                    Abilities.Remove(a);
                    foreach (KeyValuePair<string, int> kv in ability.AbilityAddOn)
                    {
                        if (kv.Value != 0)
                        {
                            Fix[kv.Key] -= kv.Value;
                        }
                    }
                    foreach (KeyValuePair<string, double> kv in ability.AbilityRate)
                    {
                        if (kv.Value != 1)
                        {
                            Fix[kv.Key] /= kv.Value;
                        }
                    }
                    foreach (KeyValuePair<string, double> kv in ability.AbilitySpecialFix)
                    {
                        if (kv.Value != 0)
                        {
                            SpecialFix[kv.Key] -= kv.Value;
                        }
                    }
                    foreach (KeyValuePair<string, double> kv in ability.AbilityBattleFix)
                    {
                        if (ability.EffectType[0])
                        {
                            if (kv.Key.EndsWith("AddOn"))
                            {
                                BattleFix["attack"][kv.Key] -= kv.Value;
                            }
                            else
                            {
                                BattleFix["attack"][kv.Key] /= kv.Value;
                            }
                        }
                        if (ability.EffectType[1])
                        {
                            if (kv.Key.EndsWith("AddOn"))
                            {
                                BattleFix["conterAttack"][kv.Key] -= kv.Value;
                            }
                            else
                            {
                                BattleFix["conterAttack"][kv.Key] /= kv.Value;
                            }
                        }
                        if (ability.EffectType[2])
                        {
                            if (kv.Key.EndsWith("AddOn"))
                            {
                                BattleFix["defend"][kv.Key] -= kv.Value;
                            }
                            else
                            {
                                BattleFix["defend"][kv.Key] /= kv.Value;
                            }
                        }
                    }

                }
            }
            Abilities.Add(ability);
            foreach (KeyValuePair<string, int> kv in ability.AbilityAddOn)
            {
                if (kv.Value != 0)
                {
                    Fix[kv.Key] += kv.Value;
                }
            }
            foreach (KeyValuePair<string, double> kv in ability.AbilityRate)
            {
                if (kv.Value != 1)
                {
                    Fix[kv.Key] *= kv.Value;
                }
            }
            foreach (KeyValuePair<string, double> kv in ability.AbilitySpecialFix)
            {
                if (kv.Value != 0)
                {
                    SpecialFix[kv.Key] += kv.Value;
                }
            }
            foreach (KeyValuePair<string, double> kv in ability.AbilityBattleFix)
            {
                if (ability.EffectType[0])
                {
                    if (kv.Key.EndsWith("AddOn"))
                    {
                        BattleFix["attack"][kv.Key] += kv.Value;
                    } else
                    {
                        BattleFix["attack"][kv.Key] *= kv.Value;
                    }
                }
                if (ability.EffectType[1])
                {
                    if (kv.Key.EndsWith("AddOn"))
                    {
                        BattleFix["conterAttack"][kv.Key] += kv.Value;
                    }
                    else
                    {
                        BattleFix["conterAttack"][kv.Key] *= kv.Value;
                    }
                }
                if (ability.EffectType[2])
                {
                    if (kv.Key.EndsWith("AddOn"))
                    {
                        BattleFix["defend"][kv.Key] += kv.Value;
                    }
                    else
                    {
                        BattleFix["defend"][kv.Key] *= kv.Value;
                    }
                }
            }
        }

        // 减少技能
        public void RemoveAbility(Ability ability)
        {
            foreach (Ability a in Abilities)
            {
                if (a.Equals(ability))
                {
                    Abilities.Remove(a);
                    foreach (KeyValuePair<string, int> kv in ability.AbilityAddOn)
                    {
                        if (kv.Value != 0)
                        {
                            Fix[kv.Key] -= kv.Value;
                        }
                    }
                    foreach (KeyValuePair<string, double> kv in ability.AbilityRate)
                    {
                        if (kv.Value != 1)
                        {
                            Fix[kv.Key] /= kv.Value;
                        }
                    }
                    foreach (KeyValuePair<string, double> kv in ability.AbilitySpecialFix)
                    {
                        if (kv.Value != 0)
                        {
                            SpecialFix[kv.Key] -= kv.Value;
                        }
                    }
                    foreach (KeyValuePair<string, double> kv in ability.AbilityBattleFix)
                    {
                        if (ability.EffectType[0])
                        {
                            if (kv.Key.EndsWith("AddOn"))
                            {
                                BattleFix["attack"][kv.Key] -= kv.Value;
                            }
                            else
                            {
                                BattleFix["attack"][kv.Key] /= kv.Value;
                            }
                        }
                        if (ability.EffectType[1])
                        {
                            if (kv.Key.EndsWith("AddOn"))
                            {
                                BattleFix["conterAttack"][kv.Key] -= kv.Value;
                            }
                            else
                            {
                                BattleFix["conterAttack"][kv.Key] /= kv.Value;
                            }
                        }
                        if (ability.EffectType[2])
                        {
                            if (kv.Key.EndsWith("AddOn"))
                            {
                                BattleFix["defend"][kv.Key] -= kv.Value;
                            }
                            else
                            {
                                BattleFix["defend"][kv.Key] /= kv.Value;
                            }
                        }
                    }

                }
            }
        }

        // 获取当前攻击范围，根据不同的攻击模式读取不同加成值
        // mode - 1攻击 2反击 3防御
        public int GetAttackRange(int mode) 
        {
            Dictionary<string, double> kv;
            if (mode == 1)
            {
                kv = BattleFix["attack"];
            } 
            else if (mode == 2)
            {
                kv = BattleFix["counterAttack"];
            }
            else
            {
                kv = BattleFix["defend"];
            }

            int weaponRange = Weapon.Range;
            int rangeModifier1 = Weapon.Range == 1 ? Convert.ToInt16(kv["closedRangeAddOn"]) : Convert.ToInt16(kv["rangedRangeAddOn"]);
            int rangeModifier2 = 0;

            switch (Weapon.WeaponType)
            {
                case "Sword":
                    rangeModifier2 = Convert.ToInt16(kv["swordRangeAddOn"]);
                    break;
                case "Spike":
                    rangeModifier2 = Convert.ToInt16(kv["spikeRangeAddOn"]);
                    break;
                case "Axe":
                    rangeModifier2 = Convert.ToInt16(kv["axeRangeAddOn"]);
                    break;
                case "Knife":
                    rangeModifier2 = Convert.ToInt16(kv["knifeRangeAddOn"]);
                    break;
                case "Bow":
                    rangeModifier2 = Convert.ToInt16(kv["bowRangeAddOn"]);
                    break;
                case "Crossbow":
                    rangeModifier2 = Convert.ToInt16(kv["crossbowRangeAddOn"]);
                    break;
                case "Tome":
                    rangeModifier2 = Convert.ToInt16(kv["tomeRangeAddOn"]);
                    break;
                case "Stave":
                    rangeModifier2 = Convert.ToInt16(kv["staveRangeAddOn"]);
                    break;
                case "Spell":
                    rangeModifier2 = Convert.ToInt16(kv["spellRangeAddOn"]);
                    break;
                case "Claw":
                    rangeModifier2 = Convert.ToInt16(kv["clawRangeAddOn"]);
                    break;
            }

            return weaponRange + rangeModifier1 + rangeModifier2;
        }

        // 获取当单位作为攻击方时的加成
        public Dictionary<string, double> GetBattleFixAsAttacker() { return BattleFix["attack"]; }

        // 获取当单位作为反击方时的加成
        public Dictionary<string, double> GetBattleFixAsConterAttacker() { return BattleFix["conterAttack"]; }

        // 获取当单位作为防守方时的加值
        public Dictionary<string, double> GetBattleFixAsDefender() { return BattleFix["defend"]; }

        // 操作七维
        public int GetMaxHp() { return Attrs["maxhp"] + Convert.ToInt32(Fix["extraMaxHp"]); }
        public int GetCurrHp() { return Attrs["hp"] + Convert.ToInt32(Fix["extraMaxHp"]); }
        public void AdjustMaxHp(int value)
        {
            Attrs["maxhp"] += value;
            Attrs["hp"] += value;
        }
        public void AdjustHp(int value)
        {
            Attrs["hp"] += value;
            if (Attrs["hp"] > Attrs["maxhp"])
            {
                Attrs["hp"] = Attrs["maxhp"];
            }
        }
        public double GetHpGrowthRate() { return Growth["hp"] + Occupation.GetOccupationHpGrowth() + SpecialFix["hpGrowthAddOn"] + Accessory.GrowthFix["hp"]; }
        public int GetAtk() { return Attrs["atk"]; }
        public int GetCurrAtk() { return Convert.ToInt32(Convert.ToDouble(Attrs["atk"]) + Fix["extraAtk"]); }
        public void AdjustAtk(int value) { Attrs["atk"] += value; }
        public double GetAtkGrowthRate() { return Growth["atk"] + Occupation.GetOccupationAtkGrowth() + SpecialFix["atkGrowthAddOn"] + Accessory.GrowthFix["atk"]; }
        public int GetSatk() { return Attrs["satk"]; }
        public int GetCurrSatk() { return Convert.ToInt32(Convert.ToDouble(Attrs["satk"]) + Fix["extraSatk"]); }
        public void AdjustSatk(int value) { Attrs["satk"] += value; }
        public double GetSatkGrowthRate() { return Growth["satk"] + Occupation.GetOccupationSatkGrowth() + SpecialFix["satkGrowthAddOn"] + Accessory.GrowthFix["satk"]; }
        public int GetDef() { return Attrs["def"]; }
        public int GetCurrDef() { return Convert.ToInt32(Convert.ToDouble(Attrs["def"]) + Fix["extraDef"]); }
        public void AdjustDef(int value) { Attrs["def"] += value; }
        public double GetDefGrowthRate() { return Growth["def"] + Occupation.GetOccupationDefGrowth() + SpecialFix["defGrowthAddOn"] + Accessory.GrowthFix["def"]; }
        public int GetSdef() { return Attrs["sdef"]; }
        public int GetCurrSdef() { return Convert.ToInt32(Convert.ToDouble(Attrs["sdef"]) + Fix["extraSdef"]); }
        public void AdjustSdef(int value) { Attrs["sdef"] += value; }
        public double GetSdefGrowthRate() { return Growth["sdef"] + Occupation.GetOccupationSdefGrowth() + SpecialFix["sdefGrowthAddOn"] + Accessory.GrowthFix["sdef"]; }
        public int GetDex() { return Attrs["dex"]; }
        public int GetCurrDex() { return Convert.ToInt32(Attrs["dex"] + Fix["extraDex"] - Math.Floor(Convert.ToDouble(Weapon.Weight) / Math.Sqrt(GetCurrAtk()))); }
        public void AdjustDex(int value) { Attrs["dex"] += value; }
        public double GetDexGrowthRate() { return Growth["dex"] + Occupation.GetOccupationDexGrowth() + SpecialFix["dexGrowthAddOn"] + Accessory.GrowthFix["dex"]; }
        public int GetTech() { return Attrs["tech"]; }
        public int GetCurrTech() { return Convert.ToInt32(Convert.ToDouble(Attrs["tech"]) + Fix["extraTech"]); }
        public void AdjustTech(int value) { Attrs["tech"] += value; }
        public double GetTechGrowthRate() { return Growth["tech"] + Occupation.GetOccupationTechGrowth() + SpecialFix["techGrowthAddOn"] + Accessory.GrowthFix["tech"]; }
        public int GetMove() { return Attrs["move"]; }
        public int GetCurrMove() { return Convert.ToInt32(Convert.ToDouble(Attrs["move"]) + Fix["extraMove"]); }
        public void AdjustMove(int value) { Attrs["move"] += value; }
        public double GetPhyDmgFix() { return Fix["phyDmgRate"]; }
        public double GetMgcDmgFix() { return Fix["mgcDmgRate"]; }
        public double GetDodgeFix() { return Fix["dodgeRate"]; }
        public double GetCriticalFix() { return Fix["criticalRate"]; }
        public double GetAccuracyFix() { return Fix["accuracyRate"]; }
        public double GetExpFix() { return Fix["expRate"]; }

        // 调整经验值，当满足条件时会升级
        public void AdjustExp(int value)
        {
            if (Attrs["exp"] < 100)
            {
                Attrs["exp"] += value;
            }
            if (Attrs["exp"] >= 100)
            {
                try
                {
                    LevelUp();
                    Attrs["exp"] -= value;
                }
                catch (MaximumLevelApproached)
                {
                    Attrs["exp"] -= value;
                }
            }
        }

        /*
         * 升级方法，当经验达到100且等级未达到最高之前可以进行升级
         * 升级逻辑如下：
         * 1. 等级 + 1
         * 2. 对七维中的每一维生成一个0-1之间的随机数，
         * 3. 如果该数字小于角色总成长率，则该属性 + 1，并提升成长率0.01
         * 4. 如果该数字小于角色总成长率 - 1，则该属性 + 2，并提升成长率0.02
         */
        public void LevelUp()
        {
            if ((Occupation.OccupationLevel == 1 && Level == 10) || (Occupation.OccupationLevel == 2 && Level == 20) || (Occupation.OccupationLevel == 3 && Level == 30) || Level == 50)
            {
                throw new MaximumLevelApproached($"{Name} has approached the max level of current occupation.");
            }
            System.Random dice = new();
            double r1 = dice.NextDouble();
            double r2 = dice.NextDouble();
            double r3 = dice.NextDouble();
            double r4 = dice.NextDouble();
            double r5 = dice.NextDouble();
            double r6 = dice.NextDouble();
            double r7 = dice.NextDouble();

            if (GetHpGrowthRate() > r1 + 1)
            {
                AdjustMaxHp(2);
                Growth["hp"] += 0.02;
            } 
            else if (GetHpGrowthRate() > r1)
            {
                AdjustMaxHp(1);
                Growth["hp"] += 0.01;
            }
            if (GetAtkGrowthRate() > r2 + 1)
            {
                AdjustAtk(2);
                Growth["atk"] += 0.02;
            }
            else if (GetAtkGrowthRate() > r2)
            {
                AdjustAtk(1);
                Growth["atk"] += 0.01;
            }
            if (GetSatkGrowthRate() > r3 + 1)
            {
                AdjustSatk(2);
                Growth["satk"] += 0.02;
            }
            else if (GetSatkGrowthRate() > r3)
            {
                AdjustSatk(1);
                Growth["satk"] += 0.01;
            }
            if (GetDefGrowthRate() > r4 + 1)
            {
                AdjustDef(2);
                Growth["def"] += 0.02;
            }
            else if (GetDefGrowthRate() > r4)
            {
                AdjustDef(1);
                Growth["def"] += 0.01;
            }
            if (GetSdefGrowthRate() > r5 + 1)
            {
                AdjustSdef(2);
                Growth["sdef"] += 0.02;
            }
            else if (GetSdefGrowthRate() > r5)
            {
                AdjustSdef(1);
                Growth["sdef"] += 0.01;
            }
            if (GetDexGrowthRate() > r6 + 1)
            {
                AdjustDex(2);
                Growth["dex"] += 0.02;
            }
            else if (GetDexGrowthRate() > r6)
            {
                AdjustDex(1);
                Growth["dex"] += 0.01;
            }
            if (GetTechGrowthRate() > r7 + 1)
            {
                AdjustTech(2);
                Growth["tech"] += 0.02;
            }
            else if (GetTechGrowthRate() > r7)
            {
                AdjustTech(1);
                Growth["tech"] += 0.01;
            }
            Level++;
        }

        // 连续升级
        public void MultiLevelUp(int times)
        {
            for (int i = 0; i < times; i++)
            {
                LevelUp();
            }
        }

        /*
         * 转职方法，当满足等级、性别和转职树条件时可转职
         * 转职逻辑如下：
         * 1. 如有需要，如有条件，替换武器为背包中的可用武器，尽可能保持原武器。若无武器可用，武器将变为无武器
         * 2. 如新职业无法使用当前盔甲，当前盔甲会变为无盔甲
         * 3. 七维属性增强
         * 4. 将新职业的职业技能加入技能栏
         */
        public void StageUp(Occupation occupation)
        {
            if ((occupation.OccupationLevel == 2 && Level == 10) || (occupation.OccupationLevel == 3 && Level == 20) || (occupation.OccupationLevel == 4 && Level == 30) && (occupation.GenderLimitation == 0 || occupation.GenderLimitation == Gender) && Occupation.UpperOccupation.Contains(occupation.FormalName))
            {
                Occupation = occupation;
                bool flag = false;
                if (occupation.AvailableWeapons.Contains(Weapon.WeaponType)) 
                {
                    flag = true;
                }
                foreach (Weapon w in Weapons)
                {
                    if (occupation.AvailableWeapons.Contains(w.WeaponType))
                    {
                        ChangeWeapon(w);
                        flag = true;
                    }
                }
                if (!flag)
                {
                    Weapon = new NoWeapon();
                }
                if (!occupation.AvailableArmors.Contains(Armor.ArmorType))
                {
                    Armor = new NoArmor();
                }
                AdjustMaxHp(Occupation.GetHpAddOn());
                AdjustAtk(Occupation.GetAtkAddOn());
                AdjustSatk(Occupation.GetSatkAddOn());
                AdjustDef(Occupation.GetDefAddOn());
                AdjustSdef(Occupation.GetSdefAddOn());
                AdjustDex(Occupation.GetDexAddOn());
                AdjustMove(Occupation.GetMoveAddOn());
                foreach (Ability a in occupation.OccupationAbility)
                {
                    AddAbility(a);
                }
            }
            else if (!Occupation.UpperOccupation.Contains(occupation.FormalName))
            {
                throw new OccupationNotAvailable($"{Occupation.GetType().Name} is not able to stage up to {occupation.GetType().Name}.");
            }
            else if (occupation.GenderLimitation != 0 && occupation.GenderLimitation != Gender)
            {
                throw new OccupationNotAvailable($"{occupation.GetType().Name} is gender restricted.");
            }
            else
            {
                throw new OccupationNotAvailable("Level requirement not reach.");
            }
        }

        // 计算NPC的行为趋势
        public double[] CalculateNPCTendency()
        {
            int sum = AttackTendency + RetreatTendency;
            if (sum == 0)
            {
                return new double[2] { 1, 0 };
            }
            return new double[2] { AttackTendency / sum,  RetreatTendency / sum };
        }
    }

    // 表示棋盘中的一个位置
    public readonly struct Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Position(Position p)
        {
            X = p.X; 
            Y = p.Y;
        }

        public int X { get; }
        public int Y { get; }
        public override string ToString() => $"({X}, {Y})";
    }
}
