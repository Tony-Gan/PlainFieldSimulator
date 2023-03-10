using System.Collections.Generic;

namespace PlainFieldSimulator.Equipments.Accessories
{
    public class LeatherShield : Accessory
    {
        public LeatherShield()
            : base(0, 0, 2, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, new Dictionary<string, double> { }, 0)
        {
            GrowthFix = new Dictionary<string, double>
            {
                { "hp", 0 },
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
            };
            FormalName = "Leather Shield";
        }
    }

    public class IronShield : Accessory
    {
        public IronShield()
            : base(0, 0, 4, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, new Dictionary<string, double> { }, 0)
        {
            GrowthFix = new Dictionary<string, double>
            {
                { "hp", 0 },
                { "atk", 0 },
                { "satk", 0 },
                { "def", 0 },
                { "sdef", 0 },
                { "dex", 0 },
                { "tech", 0 },
            };
            FormalName = "Iron Shield";
        }
    }
}
