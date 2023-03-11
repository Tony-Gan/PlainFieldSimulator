using System;
using System.Collections.Generic;
using PlainFieldSimulator.BattleField;
using PlainFieldSimulator.Equipments.Accessories;
using PlainFieldSimulator.Equipments.Armors;
using PlainFieldSimulator.Equipments.Weapons;
using PlainFieldSimulator.Missions;
using PlainFieldSimulator.Occupations;
using PlainFieldSimulator.Units;

namespace PlainFieldSimulator.Algorithms
{
    public class BattleAlgorithms
    {
        // 获取进攻信息
        public static double[] GetAttackInfo(Unit attacker, Unit defender, Cell atkCell, Cell defCell, Weather weather, DayNight dayNight, bool isCounterAttack)
        {
            Weapon atkWeapon = attacker.Weapon;
            Weapon defWeapon = defender.Weapon;
            Armor atkArmor = attacker.Armor;
            Armor defArmor = defender.Armor;
            Accessory atkAccessory = attacker.Accessory;
            Accessory defAccessory = defender.Accessory;

            // 主动攻击、反击总修正
            Dictionary<string, double> attackSkillsFix = attacker.GetBattleFixAsAttacker();
            Dictionary<string, double> conterAttackSkillsFix = attacker.GetBattleFixAsConterAttacker();
            Dictionary<string, double> defendSkillsFix = defender.GetBattleFixAsDefender();

            // 获取当前属性
            double atkCurrAtk = Convert.ToDouble(attacker.GetCurrAtk() + atkWeapon.Dmg + atkAccessory.Atk + atkCell.GetAtkFix() 
                + Convert.ToInt32(isCounterAttack ? conterAttackSkillsFix["atkAddOn"] : attackSkillsFix["atkAddOn"])) 
                * (isCounterAttack ? conterAttackSkillsFix["atkRate"] : attackSkillsFix["atkRate"]);
            double atkCurrSatk = Convert.ToDouble(attacker.GetCurrSatk() + atkWeapon.Dmg + atkAccessory.Satk + atkCell.GetSatkFix()
                + Convert.ToInt32(isCounterAttack ? conterAttackSkillsFix["satkAddOn"] : attackSkillsFix["satkAddOn"]))
                * (isCounterAttack ? conterAttackSkillsFix["satkRate"] : attackSkillsFix["satkRate"]);
            double atkCurrTech = Convert.ToDouble(attacker.GetCurrTech() + atkArmor.Tech + atkAccessory.Tech + atkCell.GetTechFix() 
                + Convert.ToInt32(isCounterAttack ? conterAttackSkillsFix["techAddOn"] : attackSkillsFix["techAddOn"])) 
                * (isCounterAttack ? conterAttackSkillsFix["techRate"] : attackSkillsFix["techRate"]);
            double defCurrDef = Convert.ToDouble(defender.GetCurrDef() + defArmor.Def + defAccessory.Def + defCell.GetDefFix() 
                + Convert.ToInt32(defendSkillsFix["defAddOn"])) * defendSkillsFix["defRate"];
            double defCurrSdef = Convert.ToDouble(defender.GetCurrSdef() + defArmor.Sdef + defAccessory.Sdef + defCell.GetSdefFix() 
                + Convert.ToInt32(defendSkillsFix["sdefAddOn"])) * defendSkillsFix["sdefRate"];
            double defCurrDex = Convert.ToDouble(defender.GetCurrDex() + defArmor.Dex + defAccessory.Dex + defCell.GetDexFix() 
                + Convert.ToInt32(defendSkillsFix["dexAddOn"])) * (defendSkillsFix["dexRate"]);

            // 获取武器克制
            Dictionary<string, double> weaponRelation = new()
            {
                { "atk/satk", 1 },
                { "accuracy", 1 },
                { "criticalRate", 1 },
                { "criticalDmgRate", 1 },
            };
            List<bool[]> r1 = GetWeaponRelationship(atkWeapon, defWeapon);
            if (Array.IndexOf(r1[0], true) > -1)
            {
                weaponRelation["atk/satk"] = 1.2;
                weaponRelation["accuracy"] = 1.2;
            } else if (Array.IndexOf(r1[1], true) > -1)
            {
                weaponRelation["atk/satk"] = 1.1;
                weaponRelation["criticalRate"] = 1.1;
                weaponRelation["criticalDmgRate"] = 1.1;
            } else if (Array.IndexOf(r1[2], true) > -1)
            {
                weaponRelation["atk/satk"] = 1.2;
                weaponRelation["criticalRate"] = 1.2;
            } else if (Array.IndexOf(r1[3], true) > -1)
            {
                weaponRelation["atk/satk"] = 2;
            } else if (Array.IndexOf(r1[4], true) > -1)
            {
                weaponRelation["accuracy"] = 1.5;
                weaponRelation["criticalDmgRate"] = 1.5;
            }

            // 获取武器类型对职业克制
            Dictionary<string, double> occupationRelation = new()
            {
                { "atk/satk", 1 },
                { "accuracy", 1 },
                { "criticalRate", 1 },
                { "criticalDmgRate", 1 },
            };
            List<bool[]> r2 = GetWeaponOccupationRelationship(atkWeapon, defender.Occupation);
            if (Array.IndexOf(r2[0], true) > -1)
            {
                occupationRelation["atk/satk"] = 1.5;
                occupationRelation["accuracy"] = 1.1;
                occupationRelation["criticalRate"] = 1.2;
            } else if (Array.IndexOf(r2[1], true) > -1) 
            {
                occupationRelation["atk"] = 1.5;
                occupationRelation["criticalRate"] = 1.5;
                occupationRelation["criticalDmgRate"] = 1.2;
            }

            // 获取武器特效对职业克制
            Dictionary<string, double> spetialEffectsRelation = new()
            {
                { "atk/satk", 1 },
                { "accuracy", 1 },
                { "criticalRate", 1 },
                { "criticalDmgRate", 1 },
            };
            bool[] relationS7 =
            {
                atkWeapon.EffectiveToHeavyarmor && defArmor.ArmorType == "HeavyArmor",
                atkWeapon.EffectiveToFlying && defender.Occupation.IsFlying,
                atkWeapon.EffectiveToRider && defender.Occupation.IsRiding,
                atkWeapon.EffectiveToMagic && (defWeapon.Type == 2 || defWeapon.Type == 3)
            };
            if (Array.IndexOf(relationS7, true) > -1)
            {
                spetialEffectsRelation["atk/satk"] = 1.5;
                spetialEffectsRelation["criticalRate"] = 1.1;
                spetialEffectsRelation["criticalDmgRate"] = 1.1;
            }

            // 爪类武器专属加成
            Dictionary<string, double> clawSpecialFix = new()
            {
                { "atk/satk", 1 },
                { "accuracy", 1 },
                { "criticalRate", 1 },
                { "criticalDmgRate", 1 },
            };
            Random dice = new();
            if (atkWeapon.WeaponType == "Claw")
            {
                if (atkWeapon.WeaponResistRate > dice.NextDouble())
                {
                    clawSpecialFix = atkWeapon.WeaponResistFix is null ? clawSpecialFix : atkWeapon.WeaponResistFix;
                }
            }

            // 计算进攻方最终攻击、防守方最终防御
            double finalAtk;
            double finalDef;
            if (atkWeapon.Type == 1)
            {
                finalAtk = atkCurrAtk * weather.GetPhyDmgRate() * dayNight.GetPhyDmgRate() * atkCell.CellSpell.GetPhyDmgRate() * weaponRelation["atk/satk"] * occupationRelation["atk/satk"] 
                    * spetialEffectsRelation["atk/satk"] * clawSpecialFix["atk/satk"] * (isCounterAttack ? conterAttackSkillsFix["phyDmgRate"] : attackSkillsFix["phyDmgRate"]) 
                    + (isCounterAttack ? conterAttackSkillsFix["phyDmgAddOn"] : attackSkillsFix["phyDmgAddOn"]);
                finalDef = defCurrDef * defendSkillsFix["phyDmgReduceRate"] + defendSkillsFix["phyDmgReduceAddOn"];
            } else if (atkWeapon.Type == 2)
            {
                finalAtk = atkCurrSatk * weather.GetMgcDmgRate() * dayNight.GetMgcDmgRate() * atkCell.CellSpell.GetMgcDmgRate() * weaponRelation["atk/satk"] * occupationRelation["atk/satk"] 
                    * spetialEffectsRelation["atk/satk"] * clawSpecialFix["atk/satk"] * (isCounterAttack ? conterAttackSkillsFix["mgcDmgRate"] : attackSkillsFix["mgcDmgRate"]) 
                    + (isCounterAttack ? conterAttackSkillsFix["mgcDmgAddOn"] : attackSkillsFix["mgcDmgAddOn"]);
                finalDef = defCurrSdef * defendSkillsFix["mgcDmgReduceRate"] + defendSkillsFix["mgcDmgReduceAddOn"]; ;
            } else
            {
                finalAtk = atkCurrSatk;
                finalDef = 0;
            }

            // 计算暴击率
            double criticalP1;
            double criticalP2;
            double critical;
            if (atkWeapon.Type != 3)
            {
                criticalP1 = Math.Sqrt(attacker.Level) * atkCurrTech * atkWeapon.CriticalRate * atkAccessory.Critical * weaponRelation["criticalRate"] * occupationRelation["criticalRate"] * attacker.GetCriticalFix()
                * spetialEffectsRelation["criticalRate"] * clawSpecialFix["criticalRate"] * (isCounterAttack ? conterAttackSkillsFix["criticalRate"] : attackSkillsFix["criticalRate"]) 
                + (isCounterAttack ? conterAttackSkillsFix["criticalAddOn"] : attackSkillsFix["criticalAddOn"]);
                criticalP2 = Math.Sqrt(defender.Level) * defCurrDex * defArmor.CriticalRateAdjustRate * defAccessory.CriticalRateAdjustRate * defendSkillsFix["criticalReduceRate"] + defendSkillsFix["criticalReduceAddOn"];
                critical = Math.Round((criticalP1 - criticalP2) / criticalP1, 4);
            } else
            {
                critical = atkCurrAtk / 100 * (isCounterAttack ? conterAttackSkillsFix["criticalRate"] : attackSkillsFix["criticalRate"]) + (isCounterAttack ? conterAttackSkillsFix["criticalAddOn"] : attackSkillsFix["criticalAddOn"]); ;
            }
            if (critical > 1) { critical = 1; }
            else if (critical < 0) {  critical = 0; }
            

            // 计算最终准确率、最终闪避率
            double accuracy = Math.Round(atkCurrTech * atkWeapon.Hit * weather.GetAccuracyRate() * dayNight.GetAccuracyRate() * atkAccessory.Accuracy * weaponRelation["accuracy"]  * attacker.GetAccuracyFix()
                * (1.3 - Convert.ToDouble(atkWeapon.Weight) / Convert.ToDouble(attacker.GetCurrTech())) * occupationRelation["accuracy"] * spetialEffectsRelation["accuracy"] * clawSpecialFix["accuracy"] * (Convert.ToDouble(attacker.Level) / 10.0) 
                * (isCounterAttack ? conterAttackSkillsFix["accuracyRate"] : attackSkillsFix["accuracyRate"]) + (isCounterAttack ? conterAttackSkillsFix["accuracyAddOn"] : attackSkillsFix["accuracyAddOn"]), 4);
            double dodge = Math.Round((defCurrDex + defCell.GetDodgeFix()) * weather.GetDodgeRate() * dayNight.GetDodgeRate() * defAccessory.Dodge * (Convert.ToDouble(defender.Level) / 8.0) * defender.GetDodgeFix()
                * (1.3 - Convert.ToDouble(defWeapon.Weight) / Convert.ToDouble(defender.GetCurrDex())) * defendSkillsFix["dodgeRate"] + defendSkillsFix["dodgeAddOn"], 4);

            // 计算命中率
            double hit;
            if (dodge == 0 && accuracy != 0) { hit = 1; } 
            else if (dodge == 0) { hit = 0; } 
            else { hit = Math.Round(accuracy / dodge, 2); }
            
            if (hit > 1) { hit = 1; }
            if (atkWeapon.Type == 3) { hit = 1; }

            // 计算伤害
            double basicDmg;
            double criticalDmg;
            if (atkWeapon.Type == 1)
            {
                basicDmg = (finalAtk - finalDef) * defArmor.PhyDmgRatio * atkAccessory.DmgRate * attacker.GetPhyDmgFix();
                criticalDmg = (finalAtk * atkWeapon.CriticalDmg * atkAccessory.CriticalDmgRate * weaponRelation["criticalDmgRate"] * occupationRelation["criticalDmgRate"] * attacker.GetPhyDmgFix() * clawSpecialFix["criticalDmgRate"]
                    * spetialEffectsRelation["criticalDmgRate"] - finalDef) * defArmor.PhyDmgRatio * atkAccessory.DmgRate * (isCounterAttack ? conterAttackSkillsFix["criticalDmgRate"] : attackSkillsFix["criticalDmgRate"]) 
                    * (0.8 + Convert.ToDouble(atkCurrTech) / 100) + (isCounterAttack ? conterAttackSkillsFix["criticalDmgAddOn"] : attackSkillsFix["criticalDmgAddOn"]);
            } else if (atkWeapon.Type == 2)
            {
                basicDmg = (finalAtk - finalDef) * defArmor.MgcDmgRatio * atkAccessory.DmgRate * attacker.GetMgcDmgFix();
                criticalDmg = (finalAtk * atkWeapon.CriticalDmg * atkAccessory.CriticalDmgRate * weaponRelation["criticalDmgRate"] * occupationRelation["criticalDmgRate"] * attacker.GetMgcDmgFix() * clawSpecialFix["criticalDmgRate"]
                    * spetialEffectsRelation["criticalDmgRate"] - finalDef) * defArmor.MgcDmgRatio * atkAccessory.DmgRate * (isCounterAttack ? conterAttackSkillsFix["criticalDmgRate"] : attackSkillsFix["criticalDmgRate"])
                    * (0.8 + Convert.ToDouble(atkCurrTech) / 100) + (isCounterAttack ? conterAttackSkillsFix["criticalDmgAddOn"] : attackSkillsFix["criticalDmgAddOn"]) ;
            } else
            {
                basicDmg = finalAtk * atkWeapon.HealingRate * attackSkillsFix["healingRate"] + attackSkillsFix["healingAddOn"];
                criticalDmg = finalAtk * atkWeapon.CriticalDmg * atkWeapon.HealingRate * attackSkillsFix["healingRate"] + attackSkillsFix["healingAddOn"];
            }

            if (basicDmg < 0)
            {
                basicDmg = 0;
                criticalDmg /= 2;
            }
            if (criticalDmg < 0)
            {
                criticalDmg = 0;
            }

            // 等级差最终补正
            int gap = attacker.Level - defender.Level;
            if (gap <= -10)
            {
                basicDmg *= 0.2;
                criticalDmg *= 0.2;
            } else if (gap >= -10) {
                basicDmg *= 2;
                criticalDmg *= 2;
            } else
            {
                basicDmg *= (21 / 260) * gap + 1;
                criticalDmg *= (14 / 260) * gap + 1;

            }

            return new double[6] { finalAtk, finalDef, critical, hit, basicDmg, criticalDmg };
        }

        public static string PrintBattleInfo(Unit attacker, Unit defender, Cell atkCell, Cell defCell, Weather weather, DayNight dayNight, bool isCounterAttack)
        {
            double[] atkInfo = GetAttackInfo(attacker, defender, atkCell, defCell, weather, dayNight, isCounterAttack);
            return
                $"Attacker: {attacker.Name}\n" +
                $"Defender: {defender.Name}\n" +
                $"\n" +
                $"Final Atk: {Convert.ToInt32(atkInfo[0])}\n" +
                $"Final Def: {Convert.ToInt32(atkInfo[1])}\n" +
                $"Critical Rate: {Convert.ToInt32(atkInfo[2] * 100)}%\n" +
                $"Hit Rate: {Convert.ToInt32(atkInfo[3] * 100)}%\n" +
                $"Basic Damage: {Convert.ToInt32(atkInfo[4])}\n" +
                $"Critical Damage: {Convert.ToInt32(atkInfo[5])}\n";
        }

        // 进行攻击动作
        public static void Attack(Unit attacker, Unit defender, Cell atkCell, Cell defCell, Weather weather, DayNight dayNight, bool isCounterAttack)
        {
            Random dice = new();
            double[] atkInfo = GetAttackInfo(attacker, defender, atkCell, defCell, weather, dayNight, isCounterAttack);

            // 是否命中
            bool isHit = atkInfo[3] > dice.NextDouble();

            // 是否暴击
            bool isCritical = atkInfo[2] > dice.NextDouble();

            // 是否击败对手
            bool isWin = false;
            if (atkInfo[3] != 0)
            {
                
                if (isHit)
                {
                    if (isCritical)
                    {
                        defender.AdjustHp(-Convert.ToInt16(atkInfo[4]));
                    }
                    else
                    {
                        defender.AdjustHp(-Convert.ToInt16(atkInfo[5]));
                    }
                } 
                if (defender.GetCurrHp() == 0)
                {
                    isWin = true;
                    defender.Position = new Position(-1, -1);
                    defCell.Unit = null;
                }
            }
            
            // 如果未能击败对手，且当前为主动攻击，且对手武器不为法杖，且在对手攻击范围内，对手则进行一次反击
            if (!isCounterAttack && defender.Weapon.WeaponType != "Stave" && defender.GetCurrHp() > 0 && defender.GetAttackRange(2) >= attacker.GetAttackRange(1))
            {
                Attack(defender, attacker, defCell, atkCell, weather, dayNight, true);
            }

            // 主动攻击击中则能够获取经验
            if (!isCounterAttack && isHit)
            {
                int exp = CalculateExpGain(attacker.Level, defender.Level, isWin);
                attacker.AdjustExp(Convert.ToInt16(attacker.GetExpFix() * exp));
            }
        }

        // 计算经验获取
        private static int CalculateExpGain(int atkLevel, int defLevel, bool isWin)
        {
            // 基础经验，击败为30，未击败为5
            double baseExp = isWin ? 30.0 : 5.0;

            // 等级差
            double gap = atkLevel - defLevel;
            if (gap > 0)
            {
                return Convert.ToInt16(baseExp * (1 + gap / 10));
            }
            else if (gap < 0)
            {
                return Convert.ToInt16((baseExp * 1 - gap / 15));
            }
            else
            {
                return Convert.ToInt16(baseExp);
            }
        }

        // 计算可移动的坐标
        public static List<Position> AvailableMovement(Mission mission, Unit u)
        {
            List<Position> res = new();
            MapGenerator map = mission.Map;
            Position p = u.Position;

            int move = u.GetCurrMove() + Convert.ToInt32(mission.GetCurrWeather().GetMoveFix());

            RecursiveMoveSearch(map, p, res, move, u.Occupation.IsFlying, u.Occupation.IsRiding);
            return res;
        }

        private static void RecursiveMoveSearch(MapGenerator map, Position p, List<Position> res, int move, bool isFlying, bool isRiding)
        {
            Cell cell = map.GetCell(p);
            if (cell.Unit != null)
            {
                return;
            }
            if ((cell.IsReachableForFly && isFlying) || cell.IsReachableForAll)
            {
                if (isFlying)
                {
                    if (cell.FlyingMoveCost > move)
                    {
                        return;
                    }
                    move -= cell.FlyingMoveCost;
                }
                else if (isRiding)
                {
                    if (cell.RidingMoveCost > move)
                    {
                        return;
                    }
                    move -= cell.RidingMoveCost;
                }
                else
                {
                    if (cell.NormalMoveCost > move)
                    {
                        return;
                    }
                    move -= cell.NormalMoveCost;
                }
                res.Add(p);
                if (p.X > 0)
                {
                    RecursiveMoveSearch(map, new Position(p.X - 1, p.Y), res, move, isFlying, isRiding);
                }
                if (p.Y > 0)
                {
                    RecursiveMoveSearch(map, new Position(p.X, p.Y - 1), res, move, isFlying, isRiding);
                }
                if (p.X < map.Board.Count - 1)
                {
                    RecursiveMoveSearch(map, new Position(p.X + 1, p.Y), res, move, isFlying, isRiding);
                }
                if (p.Y < map.Board[0].Count)
                {
                    RecursiveMoveSearch(map, new Position(p.X, p.Y + 1), res, move, isFlying, isRiding);
                }
            }
            else
            {
                return;
            }
        }

        // 计算位于攻击范围内的坐标
        public static List<Position> AvailableAttack (Mission mission, Unit u) 
        {
            List< Position> res = new();
            MapGenerator map = mission.Map;
            Position p = u.Position;

            int rangeLeft = u.GetAttackRange(1);

            RecursiveRangeSearch(map, p, res, rangeLeft);
            return res;
        }

        // 也是计算位于攻击范围内的目标，但起始点不是unit本身
        public static List<Position> AvailableAttack(Mission mission, Unit u, Position p)
        {
            List<Position> res = new();
            MapGenerator map = mission.Map;

            int rangeLeft = u.GetAttackRange(1);

            RecursiveRangeSearch(map, p, res, rangeLeft);
            return res;
        }

        private static void RecursiveRangeSearch(MapGenerator map, Position p, List<Position> res, int rangeLeft)
        {
            Cell cell = map.GetCell(p);

            if (rangeLeft == 0) { return; }

            res.Add(p);
            rangeLeft--;

            if (cell.IsPuncturable)
            {
                if (p.X > 0)
                {
                    RecursiveRangeSearch(map, new Position(p.X - 1, p.Y), res, rangeLeft);
                }
                if (p.Y > 0)
                {
                    RecursiveRangeSearch(map, new Position(p.X, p.Y - 1), res, rangeLeft);
                }
                if (p.X < map.Board.Count - 1)
                {
                    RecursiveRangeSearch(map, new Position(p.X + 1, p.Y), res, rangeLeft);
                }
                if (p.Y < map.Board[0].Count)
                {
                    RecursiveRangeSearch(map, new Position(p.X, p.Y + 1), res, rangeLeft);
                }
            }
            else
            {
                return;
            }
        }

        public static List<bool[]> GetWeaponRelationship(Weapon atkWeapon, Weapon defWeapon)
        {
            bool[] relationS1 =
{
                atkWeapon.WeaponType == "Sword" && defWeapon.WeaponType == "Axe",
                atkWeapon.WeaponType == "Axe" && defWeapon.WeaponType == "Spike",
                atkWeapon.WeaponType == "Spike" && defWeapon.WeaponType == "Sword",
                atkWeapon.WeaponType == "Claw" && defWeapon.WeaponType == "Knife",
                atkWeapon.WeaponType == "Knife" && defWeapon.WeaponType == "Claw",
            };
            bool[] relationS2 =
            {
                atkWeapon.WeaponType == "Knife" && defWeapon.WeaponType == "Bow" && atkWeapon.Range == 1 && defWeapon.Range != 1,
                atkWeapon.WeaponType == "Knife" && defWeapon.WeaponType == "Crossbow" && atkWeapon.Range == 1 && defWeapon.Range != 1,
                atkWeapon.WeaponType == "Knife" && defWeapon.WeaponType == "Stave",
                atkWeapon.WeaponType == "Knife" && defWeapon.WeaponType == "Tome" && atkWeapon.Range == 1 && defWeapon.Range != 1,
                atkWeapon.WeaponType == "Knife" && defWeapon.WeaponType == "Spell" && atkWeapon.Range == 1 && defWeapon.Range != 1,
                atkWeapon.WeaponType == "Claw" && defWeapon.WeaponType == "Bow" && atkWeapon.Range == 1 && defWeapon.Range != 1,
                atkWeapon.WeaponType == "Claw" && defWeapon.WeaponType == "Crossbow" && atkWeapon.Range == 1 && defWeapon.Range != 1,
                atkWeapon.WeaponType == "Claw" && defWeapon.WeaponType == "Stave",
                atkWeapon.WeaponType == "Claw" && defWeapon.WeaponType == "Tome" && atkWeapon.Range == 1 && defWeapon.Range != 1,
                atkWeapon.WeaponType == "Claw" && defWeapon.WeaponType == "Spell" && atkWeapon.Range == 1 && defWeapon.Range != 1,
            };
            bool[] relationS3 =
            {
                atkWeapon.WeaponType == "Sword" && defWeapon.WeaponType == "Stave",
                atkWeapon.WeaponType == "Axe" && defWeapon.WeaponType == "Stave",
                atkWeapon.WeaponType == "Spike" && defWeapon.WeaponType == "Stave",
            };
            bool[] relationS4 =
            {
                defWeapon.WeaponType == "NoWeapon",
            };
            bool[] relationS5 =
            {
                atkWeapon.WeaponType == "Spell" && defWeapon.WeaponType == "Stave",
                atkWeapon.WeaponType == "Spell" && defWeapon.WeaponType == "Tome",
                atkWeapon.WeaponType == "Spell" && defWeapon.WeaponType == "Bow",
                atkWeapon.WeaponType == "Spell" && defWeapon.WeaponType == "Crossbow",
            };

            return new List<bool[]> { relationS1, relationS2, relationS3, relationS4, relationS5 };
        }

        public static List<bool[]> GetWeaponOccupationRelationship(Weapon atkWeapon, Occupation defOccupation)
        {
            bool[] relationS1 =
{
                atkWeapon.WeaponType == "Bow" && defOccupation.IsFlying,
                atkWeapon.WeaponType == "Crossbow" && defOccupation.IsFlying,
            };
            bool[] relationS2 =
            {
                atkWeapon.WeaponType == "Spike" && defOccupation.IsRiding,
            };

            return new List<bool[]> { relationS1, relationS2 };
        }
    }
}
