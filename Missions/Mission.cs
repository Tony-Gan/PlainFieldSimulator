using System;
using System.Collections.Generic;
using PlainFieldSimulator.Algorithms;
using PlainFieldSimulator.BattleField;
using PlainFieldSimulator.Equipments.Items;
using PlainFieldSimulator.Exceptions;
using PlainFieldSimulator.Occupations;
using PlainFieldSimulator.Units;

namespace PlainFieldSimulator.Missions
{
    // 关卡对象
    public abstract class Mission
    {
        // 关卡章节
        private readonly int chapter;

        // 关卡名
        private readonly string name;

        // 地图
        private MapGenerator map;

        // 天气列表
        private List<Weather> weathers = new();

        // 天气列表中每个元素的持续轮次
        private List<int> weathersQueue = new();

        // 当前天气指针
        private int currWeather = 0;

        // 日夜列表
        private List<DayNight> dayNights = new();

        // 日夜列表中每个元素的持续轮次
        private List<int> dayNightsQueue = new();

        // 当前日夜指针
        private int currDaynight = 0;

        // 当前回合
        private int currRound = 1;

        // 我方单位列表
        private List<Unit> firstCampUnits = new();

        // 敌方单位列表
        private List<Unit> secondCampUnits = new();

        // 第三方单位列表1
        private List<Unit> thirdCampUnits = new();

        // 第三方单位列表2
        private List<Unit> fourthCampUnits = new();

        // 第三方单位列表3
        private List<Unit> fifthCampUnits = new();

        // 所有单位列表
        private List<Unit> allUnits = new();

        // 仇恨联动区块
        private Dictionary<char, bool> isActivated = new();

        // 胜利条件类型 1敌全灭 2坚持回合 3突破 4防守突破 5取得物品
        private int endCondition;

        // 坚持回合胜利的回合数
        private int finalRound;

        // 突破胜利的突破人
        private Unit breakUnit;

        // 防守突破坐标
        private int[] defendPosition = new int[2];

        // 需要取得的物品
#nullable enable
        private Item? itemToRequire;

        // 是否全场结束
        private bool isEnd = false;

        // 难度
        private int difficulty;

        public Mission(int chapter, string name, int difficulty)
        {
            this.map = new Mission1Board();
            this.chapter = chapter;
            this.name = name;
            this.difficulty = difficulty;
            breakUnit = new Unit("PlaceHolder", 1, 9, new Dictionary<string, int>(), new Dictionary<string, double>(), new FighterApprentice());
        }

        public int Chapter { get { return chapter; } }
        public string Name { get { return name; } }
        public MapGenerator Map { get { return map; } set { map = value; } }
        public List<Weather> Weathers { get { return weathers; } set { weathers = value; } }
        public List<int> WeatherQueue { get { return weathersQueue; } set {  weathersQueue = value; } }
        public List<DayNight> DayNights { get { return dayNights; } set { dayNights = value; } }
        public List<int> DayNightsQueue { get { return dayNightsQueue; } set { dayNightsQueue = value; } }
        public int CurrRound { get { return currRound; } set { currRound = value; } }
        public List<Unit> FirstCampUnits { get { return firstCampUnits; } set { firstCampUnits = value; } }
        public List<Unit> SecondCampUnits { get { return secondCampUnits; } set { secondCampUnits = value; } }
        public List<Unit> ThirdCampUnits { get { return thirdCampUnits; } set { thirdCampUnits = value; } }
        public List<Unit> FourthCampUnits { get { return fourthCampUnits; } set { fourthCampUnits = value;} }
        public List<Unit> FifthCampUnits { get { return fifthCampUnits; } set { fifthCampUnits = value; } }
        public List<Unit> AllUnits { get { return allUnits; } set { allUnits = value; } }
        public Dictionary<char, bool> IsActivated { get { return isActivated; } set {  isActivated = value; } }
        public int EndCondition { get { return endCondition; } set {  endCondition = value; } }
        public int FinalRound { get { return finalRound; } set {  finalRound = value; } }
        public Unit BreakUnit { get { return breakUnit; } set {  breakUnit = value; } }
        public int[] DefendPosition { get { return defendPosition; } set { defendPosition = value; } }
        public Item? ItemToRequire { get { return itemToRequire; } set { itemToRequire = value; } }
        public bool IsEnd { get { return isEnd; } set { IsEnd = value; } }
        public int Difficulty { get { return difficulty; } set {  difficulty = value; } }
        public int CurrWeather { get { return currWeather; } set { currWeather = value; } }
        public int CurrDaynight { get { return currDaynight; } set { currDaynight = value; } }

        // 获取当前天气
        public Weather GetCurrWeather()
        {
            return Weathers[CurrWeather];
        }

        // 获取当前日夜情况
        public DayNight GetCurrDaynight()
        {
            return DayNights[CurrDaynight];
        }

        // 在某位置上放置单位
        public void PutUnit(Position p, Unit unit)
        {
            int x = p.X;
            int y = p.Y;
            Cell cell = Map.GetCell(p);
            if (x < 0 || x > Map.Board.Count - 1 || y < 0 || y > Map.Board[0].Count)
            {
                throw new InvalidPosition($"Position ({x},{y}) out of map boundary.");
            }
            else if (cell.Unit != null)
            {
                throw new InvalidPosition($"Position ({x},{y}) already has unit on it.");
            }
            cell.Unit = unit;
            unit.Position = new Position(x, y);
        }

        // 移除某位置上的单位
        public void RemoveUnit(Position p)
        {
            int x = p.X;
            int y = p.Y;
            Unit? unit = GetUnit(p);
            if (unit != null)
            {
                unit.Position = new Position(-1, -1);
            }
            Map.GetCell(p).Unit = null;
        }

        // 获取某位置上的单位
        public Unit? GetUnit(Position p)
        {
            int x = p.X;
            int y = p.Y;
            if (x < 0 || x > Map.Board.Count - 1 || y < 0 || y > Map.Board[0].Count)
            {
                throw new InvalidPosition($"Position ({x},{y}) out of map boundary.");
            }
            return Map.GetCell(p).Unit;
        }

        // 移动单位
        public void MoveUnit(Unit unit, Position p)
        {
            Position originPos = unit.Position;
            if (originPos.X == -1 && originPos.Y == -1)
            {
                throw new UnitNotFound($"{unit.Name} not found in the map.");
            }
            List<Position> availableMovement = BattleAlgorithms.AvailableMovement(this, unit, p);
            if (availableMovement.Contains(p))
            {
                RemoveUnit(originPos);
                PutUnit(p, unit);
            } else
            {
                throw new OutOfMovementRange($"Position out of movement range.");
            }
        }

        // 获取攻击范围
        public List<Position> GetAttackRange(Unit unit)
        {
            Position p = unit.Position;
            if (p.X == -1 && p.Y == -1)
            {
                throw new UnitNotFound($"{unit.Name} not found in the map.");
            }
            return BattleAlgorithms.AvailableAttack(this, unit, p);
        }

        // 进行攻击
        public void Attack(Unit attacker, Unit defender)
        {
            Position p1 = attacker.Position;
            Position p2 = defender.Position;

            Cell atkCell = Map.GetCell(p1);
            Cell defCell = Map.GetCell(p2);

            BattleAlgorithms.Attack(attacker, defender, atkCell, defCell, GetCurrWeather(), GetCurrDaynight(), false);
        }

        // 拾取物品
        public void PickUpItem(Unit unit)
        {
            Position p = unit.Position;
            Cell cell = Map.GetCell(p);

            if (cell.CellItem != null)
            {
                unit.AddItem(cell.CellItem);
                cell.CellItem = null;
            }
        }

        // 计算两个位置之间的绝对距离
        public static int CalculateDistanceBetweenPositions(Position p1, Position p2)
        {
            return (Math.Abs(p1.X - p2.X) + Math.Abs(p1.Y - p2.Y));
        }

        // 更新当前天气
        public void UpdateCurrentWeather()
        {
            for (int i = 0; i < WeatherQueue.Count; i++)
            {
                if (currRound < WeatherQueue[i])
                {
                    CurrWeather = i;
                    break;
                }
            }
        }

        // 更新当前日夜情况
        public void UpdateDayNight()
        {
            for (int i = 0; i < DayNightsQueue.Count; i++)
            {
                if (currRound < DayNightsQueue[i])
                {
                    CurrDaynight = i;
                    break;
                }
            }
        }

        // 结束关卡
        public void EndMission()
        {
            // 回复，保存
        }
    }


    public class Mission1 : Mission
    {
        public Mission1(int chapter, string name, int difficulty) : base(chapter, name, difficulty)
        {
            Weathers.Add(new Cloudy());
            WeatherQueue.Add(3);
            Weathers.Add(new LightRainy());
            WeatherQueue.Add(8);
            Weathers.Add(new HeavyRainy());
            WeatherQueue.Add(99);
            DayNights.Add(new Daytime());
            DayNightsQueue.Add(99);

            // 友方阵营
            FirstCampUnits = new()
            {
                MainCharacterGroupGenerator.GenerateMainCharacter("Reilly", 1),
                MainCharacterGroupGenerator.GenerateAlissaCharacter(),
                MainCharacterGroupGenerator.GenerateCloudCharacter(),
            };


            // 敌方阵营
            List <List<Unit>> enemies = GroupGenerator.GetMission1EnemyGroup(difficulty);
            SecondCampUnits = enemies[0];
            ThirdCampUnits = enemies[1];
            FourthCampUnits = enemies[2];

            // 加载所有单位
            AllUnits.AddRange(FirstCampUnits);
            AllUnits.AddRange(SecondCampUnits);
            AllUnits.AddRange(ThirdCampUnits);
            AllUnits.AddRange(FourthCampUnits);

            // 加载地图
            Map = new Mission1Board();

            // 放置单位
            PutUnit(new Position(3,9), SecondCampUnits[0]);
            PutUnit(new Position(2, 11), SecondCampUnits[1]);
            PutUnit(new Position(3, 13), SecondCampUnits[2]);
            PutUnit(new Position(10, 3), ThirdCampUnits[0]);
            PutUnit(new Position(11, 2), ThirdCampUnits[1]);
            PutUnit(new Position(12, 2), ThirdCampUnits[2]);
            PutUnit(new Position(13, 3), ThirdCampUnits[3]);
            PutUnit(new Position(10, 20), FourthCampUnits[0]);
            PutUnit(new Position(11, 21), FourthCampUnits[1]);
            PutUnit(new Position(12, 21), FourthCampUnits[2]);
            PutUnit(new Position(13, 20), FourthCampUnits[3]);
            PutUnit(new Position(20, 9), FirstCampUnits[1]);
            PutUnit(new Position(21, 11), FirstCampUnits[0]);
            PutUnit(new Position(20, 13), FirstCampUnits[2]);

            // 仇恨设置
            IsActivated['a'] = false;
            IsActivated['b'] = false;
            IsActivated['c'] = false;

            // 胜利条件
            EndCondition = 1;
        }
    }
}
