using System.Collections.Generic;
using PlainFieldSimulator.Equipments.Items;
using PlainFieldSimulator.Units;

namespace PlainFieldSimulator.BattleField
{
    public abstract class Cell
    {
        // 单位
#nullable enable
        private Unit? unit;

        // 属性修正
        // 攻击，魔攻，物防，魔防，敏捷，技术，闪避
        private Dictionary<string, int> cellAttrsFix;

        // 普通单位移动力花费
        private readonly int normalMoveCost;

        // 骑兵单位移动力花费
        private readonly int ridingMoveCost;

        // 飞行单位移动力花费
        private readonly int flyingMoveCost;

        // 每回合恢复量
        private readonly int recovery;

        // 是否所有单位可达
        private readonly bool isReachableForAll;

        // 是否空中单位可达
        private readonly bool isReachableForFly;

        // 远程攻击是否可穿越
        private readonly bool isPuncturable;

        // 格子特效
        private CellSpell cellSpell = new NoSpell();

        // 特效持续回合数
        private int spellRound = 99;

        // 道具
        private Item? cellItem;

        // 标准名
        private string formalName = "Undefined";

        public Cell(Unit? unit, Dictionary<string, int> cellAttrsFix, int normalMoveCost, int ridingMoveCost, int flyingMoveCost, int recovery, bool isReachableForAll, bool isReachableForFly, bool isPuncturable)
        {
            this.unit = unit;
            this.cellAttrsFix = cellAttrsFix;
            this.normalMoveCost = normalMoveCost;
            this.ridingMoveCost = ridingMoveCost;
            this.flyingMoveCost = flyingMoveCost;
            this.recovery = recovery;
            this.isReachableForAll = isReachableForAll;
            this.isReachableForFly = isReachableForFly;
            this.isPuncturable = isPuncturable;
            CellSpell = new NoSpell();
        }
# nullable enable
        public Unit? Unit { get { return unit; } set { unit = value; } }
        public Dictionary<string, int> CellAttrsFix { get { return cellAttrsFix; } set { cellAttrsFix = value; } }
        public int GetAtkFix() { return CellAttrsFix["atk"]; }
        public int GetSatkFix() { return CellAttrsFix["satk"]; }
        public int GetDefFix() { return CellAttrsFix["def"]; }
        public int GetSdefFix() { return CellAttrsFix["sdef"]; }
        public int GetDexFix() { return CellAttrsFix["dex"]; }
        public int GetTechFix() { return CellAttrsFix["tech"]; }
        public int GetDodgeFix() { return CellAttrsFix["dodge"]; }
        public int NormalMoveCost { get { return normalMoveCost; } }
        public int RidingMoveCost { get { return ridingMoveCost; } }
        public int FlyingMoveCost { get { return flyingMoveCost; } }
        public int Recovory { get { return recovery; } }
        public bool IsReachableForAll { get { return isReachableForAll; } }
        public bool IsReachableForFly { get { return isReachableForFly; } }
        public bool IsPuncturable { get { return isPuncturable; } }
        public CellSpell CellSpell { get { return cellSpell; } set { cellSpell = value; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }
        public int SpellRound { get { return spellRound; } set {  spellRound = value; } }

        public Item? CellItem { get { return cellItem; } set { cellItem = value; } }
    }


    public class GrassLand : Cell
    {
        public GrassLand() 
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, true, true, true)
        {
            CellAttrsFix = new Dictionary<string, int> 
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class SandSurface : Cell
    {
        public SandSurface()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, true, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class StoneSurface : Cell
    {
        public StoneSurface()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, true, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class SparseBush : Cell
    {
        public SparseBush()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, true, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 3 },
            };
        }
    }

    public class DenseBush : Cell
    {
        public DenseBush()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, true, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", -1 },
                { "tech", 0 },
                { "dodge", 10 },
            };
        }
    }

    public class ShadowWater : Cell
    {
        public ShadowWater()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, true, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", -1 },
                { "satk", 1 },
                { "def", 2 },
                { "sdef", -2 },
                { "dex", -5 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class DeepWater : Cell
    {
        public DeepWater()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, true, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", -1 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class Grandstand : Cell
    {
        public Grandstand()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, false, false, false)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class HighWall : Cell
    {
        public HighWall()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, false, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class DecoratedEdgeWall : Cell
    {
        public DecoratedEdgeWall()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, false, false, false)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class DecoratedEdgeGate : Cell
    {
        public DecoratedEdgeGate()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, false, false, false)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class RecoveryPhalanx : Cell
    {
        public RecoveryPhalanx()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 10, false, false, false)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }

    public class NoSurfaceArea : Cell
    {
        public NoSurfaceArea()
            : base(null, new Dictionary<string, int>(), 1, 1, 1, 0, false, true, true)
        {
            CellAttrsFix = new Dictionary<string, int>
            {
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
                { "dodge", 0 },
            };
        }
    }
}
