using System.Collections.Generic;

namespace PlainFieldSimulator.Occupations
{
    public class Swordman : Occupation
    {
        public Swordman()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 2 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.5 },
                    { "atk", 0.34 },
                    { "satk", 0.28 },
                    { "def", 0.26 },
                    { "sdef", 0.21 },
                    { "dex", 0.35 },
                    { "tech", 0.35 },
                },
                2,
                new List<string>
                {
                    "Samurai",
                    "Warlock"
                },
                new List<string>
                {
                    "Fighter Apprentice",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                },
                false,
                false
            )
        {
            FormalName = "Swordman";
        }
    }

    public class Lancer : Occupation
    {
        public Lancer()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 2 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.46 },
                    { "atk", 0.32 },
                    { "satk", 0.26 },
                    { "def", 0.23 },
                    { "sdef", 0.21 },
                    { "dex", 0.37 },
                    { "tech", 0.37 },
                },
                2,
                new List<string>
                {
                    "Lancer Trainer",
                    "Pegasus Elite"
                },
                new List<string>
                {
                    "Fighter Apprentice",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spike",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                },
                false,
                false
            )
        {
            FormalName = "Lancer";
        }
    }

    public class Axeman : Occupation
    {
        public Axeman()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 3 },
                    { "satk", 1 },
                    { "def", 0 },
                    { "sdef", 1 },
                    { "dex", 1 },
                    { "tech", 2 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.54 },
                    { "atk", 0.4 },
                    { "satk", 0.26 },
                    { "def", 0.3 },
                    { "sdef", 0.18 },
                    { "dex", 0.3 },
                    { "tech", 0.32 },
                },
                2,
                new List<string>
                {
                    "Warrior",
                    "Wyvern Rider"
                },
                new List<string>
                {
                    "Fighter Apprentice",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Axe",
                },
                new List<string>()
                {
                    "NoArmor",
                    "MediumArmor",
                    "HeavyArmor"
                },
                false,
                false
            )
        {
            FormalName = "Axeman";
        }
    }

    public class LongbowMan : Occupation
    {
        public LongbowMan()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 4 },
                    { "satk", 3 },
                    { "def", 1 },
                    { "sdef", 0 },
                    { "dex", 2 },
                    { "tech", 1 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.32 },
                    { "atk", 0.46 },
                    { "satk", 0.3 },
                    { "def", 0.15 },
                    { "sdef", 0.2 },
                    { "dex", 0.4 },
                    { "tech", 0.36 },
                },
                2,
                new List<string>
                {
                    "Sniper",
                    "Trickster"
                },
                new List<string>
                {
                    "Archer Apprentice",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                },
                false,
                false
            )
        {
            FormalName = "Longbow Man";
        }
    }

    public class ShortbowMan : Occupation
    {
        public ShortbowMan()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 2 },
                    { "satk", 2 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 2 },
                    { "tech", 1 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.4 },
                    { "atk", 0.31 },
                    { "satk", 0.32 },
                    { "def", 0.23 },
                    { "sdef", 0.23 },
                    { "dex", 0.4 },
                    { "tech", 0.34 },
                },
                2,
                new List<string>
                {
                    "Sniper",
                    "Trickster"
                },
                new List<string>
                {
                    "Archer Apprentice",
                    "Hunter Apprentice",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Claw",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor"
                },
                false,
                false
            )
        {
            FormalName = "Shortbow Man";
        }
    }

    public class Armorman : Occupation
    {
        public Armorman()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 1 },
                    { "satk", 0 },
                    { "def", 4 },
                    { "sdef", 0 },
                    { "dex", 1 },
                    { "tech", 1 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.62 },
                    { "atk", 0.28 },
                    { "satk", 0.18 },
                    { "def", 0.45 },
                    { "sdef", 0.15 },
                    { "dex", 0.25 },
                    { "tech", 0.28 },
                },
                2,
                new List<string>
                {
                    "Armor Knight",
                    "Fortress"
                },
                new List<string>
                {
                    "Blacksmith Apprentice",
                    "Fighter Apprentice",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Axe",
                    "Spike",
                    "Crossbow"
                },
                new List<string>()
                {
                    "NoArmor",
                    "HeavyArmor"
                },
                false,
                false
            )
        {
            FormalName = "Armorman";
        }
    }

    public class MagicBlader : Occupation
    {
        public MagicBlader()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 2 },
                    { "satk", 3 },
                    { "def", 0 },
                    { "sdef", 2 },
                    { "dex", 1 },
                    { "tech", 2 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.3 },
                    { "atk", 0.34 },
                    { "satk", 0.4 },
                    { "def", 0.19 },
                    { "sdef", 0.3 },
                    { "dex", 0.3 },
                    { "tech", 0.4 },
                },
                2,
                new List<string>(),
                new List<string>
                {
                    "Hunter Apprentice",
                    "Mage Apprentice",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Knife",
                    "Claw",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor"
                },
                false,
                false
            )
        {
            FormalName = "Magic Blader";
        }
    }

    public class Thief : Occupation
    {
        public Thief()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 1 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.24 },
                    { "atk", 0.28 },
                    { "satk", 0.28 },
                    { "def", 0.2 },
                    { "sdef", 0.2 },
                    { "dex", 0.42 },
                    { "tech", 0.42 },
                },
                2,
                new List<string>
                {
                    "Assassin",
                    "Shadow",
                    "Leader Reconoitor"
                },
                new List<string>
                {
                    "Hunter Apprentice",
                    "Fighter Apprentice"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Knife",
                    "Claw",
                    "Bow"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor"
                },
                false,
                false
            )
        {
            FormalName = "Thief";
        }
    }

    public class Cavalier : Occupation
    {
        public Cavalier()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 1 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 1 },
                    { "tech", 1 },
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.46 },
                    { "atk", 0.32 },
                    { "satk", 0.26 },
                    { "def", 0.24 },
                    { "sdef", 0.24 },
                    { "dex", 0.3 },
                    { "tech", 0.3 },
                },
                2,
                new List<string>
                {
                    "Armor Knight",
                    "Leader Reconoitor"
                },
                new List<string>
                {
                    "Fighter Apprentice",
                    "Rider Apprentice"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spike",
                    "Crossbow"
                },
                new List<string>()
                {
                    "NoArmor",
                    "MediumArmor",
                },
                false,
                true
            )
        {
            FormalName = "Cavalier";
        }
    }

    public class CrossbowRider : Occupation
    {
        public CrossbowRider()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 1 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 1 },
                    { "tech", 0 },
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.32 },
                    { "atk", 0.34 },
                    { "satk", 0.28 },
                    { "def", 0.21 },
                    { "sdef", 0.21 },
                    { "dex", 0.35 },
                    { "tech", 0.35 },
                },
                2,
                new List<string>(),
                new List<string>
                {
                    "Archer Apprentice",
                    "Rider Apprentice"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Crossbow",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                },
                false,
                true
            )
        {
            FormalName = "Crossbow Rider";
        }
    }

    public class Bishop : Occupation
    {
        public Bishop()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 0 },
                    { "satk", 3 },
                    { "def", 0 },
                    { "sdef", 2 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.36 },
                    { "atk", 0.2 },
                    { "satk", 0.34 },
                    { "def", 0.2 },
                    { "sdef", 0.38 },
                    { "dex", 0.33 },
                    { "tech", 0.33 },
                },
                2,
                new List<string>
                {
                    "Mage",
                    "Dark Mage",
                    "Priest"

                },
                new List<string>
                {
                    "Mage Apprentice",
                    "Wizard Apprentice"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Stave"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                },
                false,
                false
            )
        {
            FormalName = "Bishop";
        }
    }

    public class Wizard : Occupation
    {
        public Wizard()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "stak", 5 },
                    { "def", 0 },
                    { "sdef", 2 },
                    { "dex", 0 },
                    { "tech", 3 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.3 },
                    { "atk", 0.22 },
                    { "satk", 0.48 },
                    { "def", 0.16 },
                    { "sdef", 0.32 },
                    { "dex", 0.26 },
                    { "tech", 0.4 },
                },
                2,
                new List<string>
                {
                    "Warlock",
                    "Mage",
                    "Dark Mage",
                    "Priest"
                },
                new List<string>
                {
                    "Mage Apprentice",
                    "Wizard Apprentice"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Tome",
                    "Claw"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                },
                false,
                false
            )
        {
            FormalName = "Wizard";
        }
    }

    public class PegasusRider : Occupation
    {
        public PegasusRider()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 1 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 0 },
                    { "tech", 1 },
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.34 },
                    { "atk", 0.32 },
                    { "satk", 0.31 },
                    { "def", 0.22 },
                    { "sdef", 0.3 },
                    { "dex", 0.3 },
                    { "tech", 0.32 },
                },
                2,
                new List<string>
                {
                    "Wyvern Rider",
                    "Pegasus Elite"
                },
                new List<string>
                {
                    "Fighter Apprentice",
                    "Rider Apprentice",
                    "SkyWatcher"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spike",
                    "Axe"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LeatherArmor",
                    "LightArmor"
                },
                true,
                false
            )
        {
            FormalName = "Pegasus Rider";
        }
    }
}
