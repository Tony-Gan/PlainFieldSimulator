using System.Collections.Generic;

namespace PlainFieldSimulator.Models
{
    public class AttrsGrowthModels
    {
        public static Dictionary<string, int> GetLevel1GeneralPhyAttr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 20 },
                { "hp", 20 },
                { "atk", 12 },
                { "satk", 9 },
                { "def", 9 },
                { "sdef", 8 },
                { "dex", 11 },
                { "tech", 11 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralPhyGrowth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.44 },
                { "atk", 0.24 },
                { "satk", 0.13 },
                { "def", 0.23 },
                { "sdef", 0.16 },
                { "dex", 0.21 },
                { "tech", 0.21 }
            };
        }

        public static Dictionary<string, int> GetLevel1GeneralHunAttr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 16 },
                { "hp", 16 },
                { "atk", 8 },
                { "satk", 8 },
                { "def", 9 },
                { "sdef", 9 },
                { "dex", 14 },
                { "tech", 15 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralHunGrowth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.32 },
                { "atk", 0.16 },
                { "satk", 0.16 },
                { "def", 0.17 },
                { "sdef", 0.18 },
                { "dex", 0.31 },
                { "tech", 0.31 }
            };
        }

        public static  Dictionary<string, int> GetLevel1GeneralMgc1Attr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 16 },
                { "hp", 16 },
                { "atk", 7 },
                { "satk", 13 },
                { "def", 5 },
                { "sdef", 13 },
                { "dex", 11 },
                { "tech", 11 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralMgc1Growth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.32 },
                { "atk", 0.13 },
                { "satk", 0.26 },
                { "def", 0.12 },
                { "sdef", 0.28 },
                { "dex", 0.21 },
                { "tech", 0.24 }
            };
        }

        public static Dictionary<string, int> GetLevel1GeneralArcAttr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 16 },
                { "hp", 16 },
                { "atk", 13 },
                { "satk", 7 },
                { "def", 8 },
                { "sdef", 10 },
                { "dex", 10 },
                { "tech", 11 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralArcGrowth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.34 },
                { "atk", 0.24 },
                { "satk", 0.19 },
                { "def", 0.16 },
                { "sdef", 0.19 },
                { "dex", 0.22 },
                { "tech", 0.25 }
            };
        }

        public static Dictionary<string, int> GetLevel1GeneralMgc2Attr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 18 },
                { "hp", 18 },
                { "atk", 7 },
                { "satk", 13 },
                { "def", 7 },
                { "sdef", 13 },
                { "dex", 9 },
                { "tech", 9 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralMgc2Growth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.34 },
                { "atk", 0.13 },
                { "satk", 0.24 },
                { "def", 0.14 },
                { "sdef", 0.26 },
                { "dex", 0.2 },
                { "tech", 0.24 }
            };
        }

        public static Dictionary<string, int> GetLevel1GeneralDefAttr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 28 },
                { "hp", 28 },
                { "atk", 8 },
                { "satk", 7 },
                { "def", 16 },
                { "sdef", 3 },
                { "dex", 9 },
                { "tech", 8 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralDefGrowth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.5 },
                { "atk", 0.18 },
                { "satk", 0.15 },
                { "def", 0.32 },
                { "sdef", 0.12 },
                { "dex", 0.17 },
                { "tech", 0.19 }
            };
        }

        public static Dictionary<string, int> GetLevel1GeneralBlcAttr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 20 },
                { "hp", 20 },
                { "atk", 10 },
                { "satk", 10 },
                { "def", 10 },
                { "sdef", 10 },
                { "dex", 10 },
                { "tech", 10 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralBlcGrowth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.4 },
                { "atk", 0.2 },
                { "satk", 0.2 },
                { "def", 0.2 },
                { "sdef", 0.2 },
                { "dex", 0.2 },
                { "tech", 0.2 }
            };
        }

        public static Dictionary<string, int> GetLevel1GeneralVilAttr()
        {
            return new Dictionary<string, int>
            {
                { "maxhp", 16 },
                { "hp", 16 },
                { "atk", 6 },
                { "satk", 6 },
                { "def", 6 },
                { "sdef", 6 },
                { "dex", 6 },
                { "tech", 6 },
                { "move", 5 },
                { "exp", 0 },
            };
        }

        public static Dictionary<string, double> GetLevel1GeneralVilGrowth()
        {
            return new Dictionary<string, double>
            {
                { "hp", 0.36 },
                { "atk", 0.18 },
                { "satk", 0.18 },
                { "def", 0.18 },
                { "sdef", 0.18 },
                { "dex", 0.18 },
                { "tech", 0.18 }
            };
        }
    }
}
