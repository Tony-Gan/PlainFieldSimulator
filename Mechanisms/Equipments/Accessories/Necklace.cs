using System.Collections.Generic;

namespace PlainFieldSimulator.Equipments.Accessories
{
    public class SapphireNecklace : Accessory
    {
        public SapphireNecklace()
            : base(0, 0, 0, 0, 0, 0, 0, 1.05, 1, 1, 1.05, 1, 1, new Dictionary<string, double> { }, 0)
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
            FormalName = "Sapphire Necklace";
        }
    }

    public class RubyNecklace : Accessory
    {
        public RubyNecklace()
            : base(1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, new Dictionary<string, double> { }, 0)
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
            FormalName = "Ruby Necklace";
        }
    }

    public class EmeraldNecklace : Accessory
    {
        public EmeraldNecklace()
            : base(0, 0, 0, 0, 0, 0, 0, 1, 1.05, 1.05, 1, 1, 1, new Dictionary<string, double> { }, 0)
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
            FormalName = "Emerald Necklace";
        }
    }
}
