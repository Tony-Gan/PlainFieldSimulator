using System;
using System.Collections.Generic;
using PlainFieldSimulator.Equipments.Armors;
using PlainFieldSimulator.Equipments.Weapons;
using PlainFieldSimulator.Missions;
using PlainFieldSimulator.Units;

namespace PlainFieldSimulator.Algorithms
{
    public class EnemyLogicAlgorithms
    {
        // NPC行动
        public static void ImplementNPCMovement(Mission mission, List<Unit> enemyGroup)
        {
            foreach (Unit unit in enemyGroup)
            {
                if (unit.GetCurrHp() == 0 || !mission.IsActivated[unit.TriggerLabel])
                {
                    continue;
                }
                Random dice = new();
                double[] tendency = unit.CalculateNPCTendency();
                if (dice.NextDouble() <= tendency[0])
                {
                    ImplementNPCAttack(mission, unit);
                }
                else
                {
                    ImplementNPCRetreat(mission, unit);
                }
            }
        }

        // NPC进行攻击行动
        private static void ImplementNPCAttack(Mission mission, Unit unit)
        {
            // 获取当前移动范围
            List<Position> availableMovement = BattleAlgorithms.AvailableMovement(mission, unit);
            // 获取所有攻击范围
            List<Position> attackablePosition = new();
            foreach (Position pos in availableMovement)
            {
                attackablePosition.AddRange(BattleAlgorithms.AvailableAttack(mission, unit, pos));
            }
            // 获取所有可攻击对象
            List<Unit> attackableUnits = new();
            foreach (Position pos in attackablePosition)
            {
                if (mission.Map.GetCell(pos).Unit != null)
                {
                    attackableUnits.Add(unit);
                }
            }

            // 当攻击范围内没有任意目标时
            if (attackableUnits.Count == 0)
            {
                // 寻找最近目标
                int minDistanceToEnemy = Int16.MaxValue;
                List<Unit> nearestEnemies = new();
                foreach (Unit u in mission.AllUnits)
                {
                    if (u.Camp != unit.Camp)
                    {
                        int dist = Mission.CalculateDistanceBetweenPositions(unit.Position, u.Position);
                        if (minDistanceToEnemy < dist)
                        {
                            minDistanceToEnemy = dist;
                        }
                    }
                }
                foreach (Unit u in mission.AllUnits)
                {
                    if (u.Camp != unit.Camp)
                    {
                        if (Mission.CalculateDistanceBetweenPositions(unit.Position, u.Position) == minDistanceToEnemy)
                        {
                            nearestEnemies.Add(u);
                        }
                    }
                }
                if (nearestEnemies.Count == 0)
                {
                    return;
                }

                // 进行目标分析，选择目标
                int targetScore = 0;
                Unit targetUnit = unit;
                foreach (Unit u in nearestEnemies)
                {
                    int score = EnemiesTargetAnalysis(mission, unit, u);
                    if (score > targetScore)
                    {
                        targetScore = score;
                        targetUnit = u;
                    }
                }

                Position shortestPath = FindShortestPathToUnreachableUnit(unit, targetUnit, mission);
                mission.MoveUnit(unit, shortestPath);
            }
            // 当攻击范围内有目标时
            else
            {
                int targetScore = 0;
                Unit targetUnit = unit;
                // 回复类武器
                if (unit.Weapon.Type == 3)
                {
                    foreach (Unit u in attackableUnits)
                    {
                        if (unit.Camp == u.Camp)
                        {
                            int score = AlliesTargetAnalysis(u);
                            if (score > targetScore)
                            {
                                targetScore = score;
                                targetUnit = u;
                            }
                        }
                    }
                }
                // 非回复类武器
                else
                {
                    foreach (Unit u in attackableUnits)
                    {
                        if (unit.Camp != u.Camp)
                        {
                            int score = EnemiesTargetAnalysis(mission, unit, u);
                            if (score > targetScore)
                            {
                                targetScore = score;
                                targetUnit = u;
                            }
                        }
                    }
                }
                Position shortestPath = FindShortestPathToReachableUnit(unit, targetUnit, mission);
                mission.MoveUnit(unit, shortestPath);
                mission.Attack(unit, targetUnit);
            }
        }

        // NPC进行撤退行动
        private static void ImplementNPCRetreat(Mission mission, Unit unit)
        {
            // 获取当前移动范围
            List<Position> availableMovement = BattleAlgorithms.AvailableMovement(mission, unit);

            // 获取最近的至多三个敌人的距离
            List<Unit> nearestThreeUnits = new();
            foreach (Unit u in mission.AllUnits)
            {
                if (u.GetCurrHp() != 0 && u.Camp != unit.Camp)
                {
                    if (nearestThreeUnits.Count < 3)
                    {
                        nearestThreeUnits.Add(u);
                    }
                    else
                    {
                        nearestThreeUnits.Sort();
                        nearestThreeUnits[2] = u;
                    }
                }
            }

            // 寻找可能的最远距离
            int longestDistance = 0;
            Position p = unit.Position;
            foreach (Position pos in availableMovement)
            {
                int dist = 0;
                foreach (Unit u in nearestThreeUnits)
                {
                    dist += Mission.CalculateDistanceBetweenPositions(u.Position, pos);
                } 
                if (dist > longestDistance)
                {
                    longestDistance = dist;
                    p = pos;
                }
            }

            // 润了
            mission.MoveUnit(unit, p);
        }

        // 进攻得分分析，得分越高，NPC攻击该单位的倾向越强，进攻分析中会自动换武器
        private static int EnemiesTargetAnalysis(Mission mission, Unit u1, Unit u2)
        {
            int baseScore = 100;
            Weapon atkWeapon = u1.Weapon;
            Weapon defWeapon = u2.Weapon;
            Armor defArmor = u2.Armor;

            // 对方武器影响
            if (defWeapon == new NoWeapon())
            {
                baseScore *= 2;
            }
            else if (atkWeapon == new NoWeapon())
            {
                baseScore = 0;
            }
            List<bool[]> weaponRelation = BattleAlgorithms.GetWeaponRelationship(atkWeapon, defWeapon);
            foreach (Weapon w in u1.Weapons)
            {
                foreach (bool[] r in weaponRelation)
                {
                    if (Array.IndexOf(r, true) > -1)
                    {
                        u1.ChangeWeapon(w);
                        baseScore += 70;
                    }
                }
            }

            // 对方防具影响
            bool[] armorRelation =
            {
                atkWeapon.EffectiveToHeavyarmor && defArmor.ArmorType == "HeavyArmor",
                atkWeapon.EffectiveToFlying && u2.Occupation.IsFlying,
                atkWeapon.EffectiveToRider && u2.Occupation.IsRiding,
                atkWeapon.EffectiveToMagic && (defWeapon.Type == 2 || defWeapon.Type == 3)
            };
            foreach (Weapon w in u1.Weapons)
            {
                if (Array.IndexOf(armorRelation, true) > -1)
                {
                    u1.ChangeWeapon(w);
                    baseScore += 100;
                }
            }
            if (defArmor.ArmorType == "HeavyArmor")
            {
                baseScore -= 20;
            }
            else if (defArmor.ArmorType == "MediumArmor")
            {
                baseScore -= 10;
            }
            else if (defArmor == new NoArmor())
            {
                baseScore += 20;
            }

            // 武器职业克制影响
            List<bool[]> weaponOccupationRelation = BattleAlgorithms.GetWeaponOccupationRelationship(atkWeapon, u2.Occupation);
            foreach (Weapon w in u1.Weapons)
            {
                foreach (bool[] r in weaponOccupationRelation)
                {
                    if (Array.IndexOf(r, true) > -1)
                    {
                        u1.ChangeWeapon(w);
                        baseScore += 120;
                    }
                }
            }

            // 等级差影响
            baseScore += (u1.Level - u2.Level) * 10;

            // 职业等级影响
            baseScore += (u1.Occupation.OccupationLevel - u2.Occupation.OccupationLevel) * 10;


            // 命中率、暴击率、伤害、是否能击败、对方剩余血量影响 return new double[6] { finalAtk, finalDef, critical, hit, basicDmg, criticalDmg };
            double[] attackInfo = BattleAlgorithms.GetAttackInfo(u1, u2, mission.Map.GetCell(u1.Position), mission.Map.GetCell(u2.Position), mission.GetCurrWeather(), mission.GetCurrDaynight(), false);
            if (attackInfo[3] == 0 || (attackInfo[4] == 0 && attackInfo[3] < 0.3) || attackInfo[5] == 0)
            {
                baseScore = 0;
            }
            baseScore += Convert.ToInt16(attackInfo[4] * 5);
            baseScore += Convert.ToInt16(attackInfo[5] * attackInfo[3] * 5);

            // 随机微调
            Random dice = new();

            return baseScore + dice.Next(-5, 5);
        }

        // 治疗得分分析，得分越高，NPC治疗该单位的倾向越强，治疗分析中会自动换武器
        private static int AlliesTargetAnalysis(Unit u2)
        {
            int baseScore = 100;

            // 剩余血量影响
            double hpPercentage = u2.GetCurrHp() / u2.GetMaxHp();
            baseScore += Convert.ToInt16((1 - hpPercentage) * 100);

            // 武器类型影响
            if (u2.Weapon.Range == 1 || u2.Weapon == new NoWeapon())
            {
                baseScore += 10;
            }

            // 防具影响
            if (u2.Armor.ArmorType == "HeavyArmor")
            {
                baseScore += 20;
            }
            else if (u2.Armor.ArmorType == "MediumArmor")
            {
                baseScore += 10;
            }

            // 随机微调
            Random dice = new();

            return baseScore + dice.Next(-5, 5);
        }

        // 我写不动了，如果目标不可及，会找能够移动的范围内绝对距离最短的点，终点为距离目标所需移动力最低的点
        private static Position FindShortestPathToReachableUnit(Unit u1, Unit u2, Mission mission)
        {
            Position targetNode = u2.Position;

            List<Position> availableMovements = BattleAlgorithms.AvailableMovement(mission, u1);
            Position p = new(-1, -1);
            int shortestPath = Int16.MaxValue;
            foreach (Position pos in availableMovements)
            {
                int path = Mission.CalculateDistanceBetweenPositions(targetNode, pos);
                if (path < shortestPath)
                {
                    shortestPath = path;
                    p = pos;
                }
            }

            return p;
        }

        // 同上，累了，先实现再说
        private static Position FindShortestPathToUnreachableUnit(Unit u1, Unit u2, Mission mission)
        {
            Position targetNode = u2.Position;
            List<Position> availableMovements = BattleAlgorithms.AvailableMovement(mission, u1);
            int attackRange = u1.GetAttackRange(1);

            foreach (Position pos in availableMovements)
            {
                if (Mission.CalculateDistanceBetweenPositions(targetNode, pos) == attackRange)
                {
                    return pos;
                }
            }
            return new Position(-1, -1);
        }
    }
}
