using System.Collections.Generic;

namespace PlainFieldSimulator.Occupations
{
    public class SwordMaster : Occupation
    {
        public SwordMaster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 6 },
                    { "satk", -1 },
                    { "def", 4 },
                    { "sdef", 4 },
                    { "dex", 4 },
                    { "tech", 4 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.76 },
                    { "atk", 0.62 },
                    { "satk", 0.1 },
                    { "def", 0.56 },
                    { "sdef", 0.52 },
                    { "dex", 0.55 },
                    { "tech", 0.55 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Samurai",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Spell"
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
            FormalName = "Sword Master";
        }
    }

    public class LanceMaster : Occupation
    {
        public LanceMaster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 6 },
                    { "satk", -1 },
                    { "def", 4 },
                    { "sdef", 4 },
                    { "dex", 4 },
                    { "tech", 4 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.7 },
                    { "atk", 0.6 },
                    { "satk", 0.1 },
                    { "def", 0.54 },
                    { "sdef", 0.54 },
                    { "dex", 0.59 },
                    { "tech", 0.59 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Lancer Trainer",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spike",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor"
                },
                false,
                false
            )
        {
            FormalName = "Lance Master";
        }
    }

    public class AxeMaster : Occupation
    {
        public AxeMaster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 8 },
                    { "atk", 7 },
                    { "satk", -1 },
                    { "def", 5 },
                    { "sdef", 3 },
                    { "dex", 3 },
                    { "tech", 3 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.8 },
                    { "atk", 0.69 },
                    { "satk", 0.1 },
                    { "def", 0.61 },
                    { "sdef", 0.48 },
                    { "dex", 0.5 },
                    { "tech", 0.5 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Warrior",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Axe",
                    "Spell"
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
            FormalName = "Axe Master";
        }
    }

    public class MasterOfWeapons : Occupation
    {
        public MasterOfWeapons()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 5 },
                    { "satk", 5 },
                    { "def", 4 },
                    { "sdef", 4 },
                    { "dex", 3 },
                    { "tech", 5 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.72 },
                    { "atk", 0.6 },
                    { "satk", 0.6 },
                    { "def", 0.58 },
                    { "sdef", 0.51 },
                    { "dex", 0.5 },
                    { "tech", 0.64 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Warrior",
                    "Lancer Trainer",
                    "Samurai"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Axe",
                    "Spike",
                    "Knife",
                    "Claw"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LeatherArmor"
                },
                false,
                false
            )
        {
            FormalName = "Master of Weapons";
        }
    }

    public class Berserker : Occupation
    {
        public Berserker()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", -6 },
                    { "atk", 14 },
                    { "satk", -1 },
                    { "def", -1 },
                    { "sdef", -1 },
                    { "dex", 8 },
                    { "tech", 8 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.06 },
                    { "atk", 1.14 },
                    { "satk", 0.1 },
                    { "def", 0.05 },
                    { "sdef", 0.15 },
                    { "dex", 0.93 },
                    { "tech", 0.88 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Warrior",
                    "Lancer Trainer",
                    "Samurai"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Axe",
                    "Sword"
                },
                new List<string>()
                {
                    "NoArmor",
                },
                false,
                false
            )
        {
            FormalName = "Berserker";
            GenderLimitation = 1;
        }
    }

    public class Valkyrie : Occupation
    {
        public Valkyrie()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", -4 },
                    { "atk", 12 },
                    { "satk", -1 },
                    { "def", -1 },
                    { "sdef", 0 },
                    { "dex", 8 },
                    { "tech", 8 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.32 },
                    { "atk", 0.99 },
                    { "satk", 0.1 },
                    { "def", 0.14 },
                    { "sdef", 0.17 },
                    { "dex", 0.88 },
                    { "tech", 0.84 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Warrior",
                    "Lancer Trainer",
                    "Samurai"
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
                    "LightArmor"
                },
                false,
                false
            )
        {
            FormalName = "Valkyrie";
            GenderLimitation = 2;
        }
    }
    
    public class Hero : Occupation
    {
        public Hero()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 16 },
                    { "atk", 4 },
                    { "satk", -1 },
                    { "def", 9 },
                    { "sdef", 1 },
                    { "dex", 1 },
                    { "tech", 2 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 1.22 },
                    { "atk", 0.47 },
                    { "satk", 0.1 },
                    { "def", 0.98 },
                    { "sdef", 0.31 },
                    { "dex", 0.34 },
                    { "tech", 0.45 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Fortress",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Axe",
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
            FormalName = "Hero";
        }
    }

    public class General : Occupation
    {
        public General()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 14 },
                    { "atk", 3 },
                    { "satk", 3 },
                    { "def", 4 },
                    { "sdef", 4 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 1.12 },
                    { "atk", 0.43 },
                    { "satk", 0.43 },
                    { "def", 0.78 },
                    { "sdef", 0.78 },
                    { "dex", 0.33 },
                    { "tech", 0.33 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Fortress",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Crossbow",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "HeavyArmor",
                    "LeatherArmor"
                },
                false,
                false
            )
        {
            FormalName = "General";
        }
    }

    public class FortressKnight : Occupation
    {
        public FortressKnight()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 12 },
                    { "atk", 5 },
                    { "satk", -1 },
                    { "def", 7 },
                    { "sdef", 2 },
                    { "dex", 2 },
                    { "tech", 3 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 1.04 },
                    { "atk", 0.51 },
                    { "satk", 0.1 },
                    { "def", 0.89 },
                    { "sdef", 0.45 },
                    { "dex", 0.38 },
                    { "tech", 0.41 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Fortress",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Lance",
                },
                new List<string>()
                {
                    "NoArmor",
                    "HeavyArmor",
                },
                false,
                true
            )
        {
            FormalName = "Fortress Knight";
        }
    }

    public class BowMaster : Occupation
    {
        public BowMaster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 8 },
                    { "satk", -1 },
                    { "def", 1 },
                    { "sdef", 2 },
                    { "dex", 7 },
                    { "tech", 6 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.58 },
                    { "atk", 0.72 },
                    { "satk", 0.1 },
                    { "def", 0.35 },
                    { "sdef", 0.42 },
                    { "dex", 0.73 },
                    { "tech", 0.67 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Sniper",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Spell"
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
            FormalName = "Bow Master";
        }
    }

    public class CrossbowMaster : Occupation
    {
        public CrossbowMaster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 7 },
                    { "satk", -1 },
                    { "def", 2 },
                    { "sdef", 3 },
                    { "dex", 6 },
                    { "tech", 5 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.64 },
                    { "atk", 0.66 },
                    { "satk", 0.1 },
                    { "def", 0.43 },
                    { "sdef", 0.48 },
                    { "dex", 0.66 },
                    { "tech", 0.61 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Sniper",
                    "Trickster"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Spell"
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
            FormalName = "Crossbow Master";
        }
    }

    public class BattleMaster : Occupation
    {
        public BattleMaster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 6 },
                    { "satk", 6 },
                    { "def", 3 },
                    { "sdef", 3 },
                    { "dex", 4 },
                    { "tech", 5 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.62 },
                    { "atk", 0.61 },
                    { "satk", 0.61 },
                    { "def", 0.46 },
                    { "sdef", 0.51 },
                    { "dex", 0.54 },
                    { "tech", 0.69 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Trickster",
                    "Assassin",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Sword",
                    "Claw"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor"
                },
                false,
                false
            )
        {
            FormalName = "Battle Master";
        }
    }

    public class MartialMaster : Occupation
    {
        public MartialMaster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 6 },
                    { "satk", 6 },
                    { "def", 3 },
                    { "sdef", 3 },
                    { "dex", 4 },
                    { "tech", 5 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.62 },
                    { "atk", 0.61 },
                    { "satk", 0.61 },
                    { "def", 0.46 },
                    { "sdef", 0.51 },
                    { "dex", 0.54 },
                    { "tech", 0.69 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Assassin",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Knife",
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
            FormalName = "Martial Master";
        }
    }

    public class ShadowServent : Occupation
    {
        public ShadowServent()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 4 },
                    { "satk", -1 },
                    { "def", 1 },
                    { "sdef", 2 },
                    { "dex", 9 },
                    { "tech", 7 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.58 },
                    { "atk", 0.54 },
                    { "satk", 0.1 },
                    { "def", 0.39 },
                    { "sdef", 0.41 },
                    { "dex", 0.86 },
                    { "tech", 0.74 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Trickster",
                    "Assassin",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Claw",
                    "Crossbow"
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
            FormalName = "Shadow Servent";
        }
    }

    public class Darkness : Occupation
    {
        public Darkness()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 4 },
                    { "satk", 4 },
                    { "def", 1 },
                    { "sdef", 2 },
                    { "dex", 6 },
                    { "tech", 6 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.5 },
                    { "atk", 0.51 },
                    { "satk", 0.51 },
                    { "def", 0.31 },
                    { "sdef", 0.48 },
                    { "dex", 0.8 },
                    { "tech", 0.73 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Dark Mage",
                    "Shadow"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Tome",
                    "Knife",
                    "Spell"
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
            FormalName = "Darkness";
        }
    }

    public class Shapeless : Occupation
    {
        public Shapeless()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 4 },
                    { "satk", -1 },
                    { "def", 1 },
                    { "sdef", 2 },
                    { "dex", 9 },
                    { "tech", 7 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.52 },
                    { "atk", 0.49 },
                    { "satk", 0.1 },
                    { "def", 0.31 },
                    { "sdef", 0.48 },
                    { "dex", 0.8 },
                    { "tech", 0.73 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Assassin",
                    "Shadow"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Sword",
                    "Spell"
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
            FormalName = "Shapeless";
        }
    }

    public class Faceless : Occupation
    {
        public Faceless()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 6 },
                    { "satk", 4 },
                    { "def", -2 },
                    { "sdef", -2 },
                    { "dex", 7 },
                    { "tech", 7 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.44 },
                    { "atk", 0.64 },
                    { "satk", 0.64 },
                    { "def", 0.3 },
                    { "sdef", 0.38 },
                    { "dex", 0.78 },
                    { "tech", 0.75 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Assassin",
                    "Shadow"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Knife",
                    "Spell",
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
            FormalName = "Faceless";
        }
    }

    public class Paladin : Occupation
    {
        public Paladin()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 6 },
                    { "satk", 5 },
                    { "def", 3 },
                    { "sdef", 4 },
                    { "dex", 2 },
                    { "tech", 3 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.74 },
                    { "atk", 0.61 },
                    { "satk", 0.56 },
                    { "def", 0.51 },
                    { "sdef", 0.54 },
                    { "dex", 0.49 },
                    { "tech", 0.59 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Knight",
                    "Leader Reconoitor",
                    "Mage"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Stave",
                    "Lance",
                    "Sword"
                },
                new List<string>()
                {
                    "NoArmor",
                    "MediumArmor",
                    "HeavyArmor",
                },
                false,
                true
            )
        {
            FormalName = "Paladin";
        }
    }

    public class DarkKnight : Occupation
    {
        public DarkKnight()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 5 },
                    { "satk", 6 },
                    { "def", 3 },
                    { "sdef", 4 },
                    { "dex", 2 },
                    { "tech", 3 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.7 },
                    { "atk", 0.56 },
                    { "satk", 0.61 },
                    { "def", 0.49 },
                    { "sdef", 0.56 },
                    { "dex", 0.49 },
                    { "tech", 0.59 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Dark Mage",
                    "Warlock"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Tome",
                    "Axe",
                },
                new List<string>()
                {
                    "NoArmor",
                    "MediumArmor",
                    "LeatherArmor",
                },
                false,
                true
            )
        {
            FormalName = "Dark Knight";
        }
    }

    public class GreatKnight : Occupation
    {
        public GreatKnight()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 5 },
                    { "satk", -1 },
                    { "def", 5 },
                    { "sdef", 3 },
                    { "dex", 3 },
                    { "tech", 4 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.82 },
                    { "atk", 0.66 },
                    { "satk", 0.1 },
                    { "def", 0.61 },
                    { "sdef", 0.42 },
                    { "dex", 0.52 },
                    { "tech", 0.61 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Knight",
                    "Leader Reconoitor",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Lance",
                    "Axe",
                    "Bow"
                },
                new List<string>()
                {
                    "NoArmor",
                    "MediumArmor",
                    "HeavyArmor",
                },
                false,
                true
            )
        {
            FormalName = "Great Knight";
        }
    }

    public class Sage : Occupation
    {
        public Sage()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", -1 },
                    { "satk", 10 },
                    { "def", -2 },
                    { "sdef", 8 },
                    { "dex", 5 },
                    { "tech", 3 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.48 },
                    { "atk", 0.1 },
                    { "satk", 0.7 },
                    { "def", 0.34 },
                    { "sdef", 0.72 },
                    { "dex", 0.61 },
                    { "tech", 0.54 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Mage",
                    "Priest",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spell",
                    "Stave",
                    "Tome"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Sage";
        }
    }

    public class MageKnight : Occupation
    {
        public MageKnight()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", -1 },
                    { "satk", 7 },
                    { "def", 4 },
                    { "sdef", 4 },
                    { "dex", 5 },
                    { "tech", 4 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.54 },
                    { "atk", 0.1 },
                    { "satk", 0.64 },
                    { "def", 0.43 },
                    { "sdef", 0.61 },
                    { "dex", 0.61 },
                    { "tech", 0.52 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Mage",
                    "Priest",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Claw",
                    "Tome"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                false,
                true
            )
        {
            FormalName = "Mage Knight";
        }
    }

    public class Necromancer : Occupation
    {
        public Necromancer()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", -1 },
                    { "satk", 11 },
                    { "def", -2 },
                    { "sdef", 7 },
                    { "dex", 5 },
                    { "tech", 3 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.44 },
                    { "atk", 0.1 },
                    { "satk", 0.74 },
                    { "def", 0.29 },
                    { "sdef", 0.66 },
                    { "dex", 0.71 },
                    { "tech", 0.54 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Mage",
                    "Priest",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spell",
                    "Tome"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Necromancer";
        }
    }

    public class MortalSavant : Occupation
    {
        public MortalSavant()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 5 },
                    { "satk", 5 },
                    { "def", 3 },
                    { "sdef", 3 },
                    { "dex", 5 },
                    { "tech", 5 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.62 },
                    { "atk", 0.57 },
                    { "satk", 0.57 },
                    { "def", 0.52 },
                    { "sdef", 0.58 },
                    { "dex", 0.62 },
                    { "tech", 0.55 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Samurai",
                    "Mage"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Tome",
                    "Stave"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor"
                },
                false,
                false
            )
        {
            FormalName = "Mortal Savant";
        }
    }

    public class WyvernLord : Occupation
    {
        public WyvernLord()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 8 },
                    { "atk", 7 },
                    { "satk", -1 },
                    { "def", 2 },
                    { "sdef", 2 },
                    { "dex", 4 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.8 },
                    { "atk", 0.66 },
                    { "satk", 0.1 },
                    { "def", 0.47 },
                    { "sdef", 0.47 },
                    { "dex", 0.66 },
                    { "tech", 0.49 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Wyvern Rider",
                    "Sky Watcher"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Lance",
                    "Crossbow"
                },
                new List<string>()
                {
                    "NoArmor",
                    "MediumArmor",
                    "HeavyArmor",
                },
                true,
                false
            )
        {
            FormalName = "Wyvern Lord";
            GenderLimitation = 1;
        }
    }

    public class FalconKnight : Occupation
    {
        public FalconKnight()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 8 },
                    { "atk", 7 },
                    { "satk", -1 },
                    { "def", 2 },
                    { "sdef", 2 },
                    { "dex", 4 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.8 },
                    { "atk", 0.66 },
                    { "satk", 0.1 },
                    { "def", 0.47 },
                    { "sdef", 0.47 },
                    { "dex", 0.66 },
                    { "tech", 0.49 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Pegasus Elite",
                    "Sky Watcher"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Lance",
                    "Crossbow"
                },
                new List<string>()
                {
                    "NoArmor",
                    "MediumArmor",
                    "HeavyArmor",
                },
                true,
                false
            )
        {
            FormalName = "Falcon Knight";
            GenderLimitation = 2;
        }
    }

    public class DarkFlier : Occupation
    {
        public DarkFlier()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", -1 },
                    { "satk", 7 },
                    { "def", 3 },
                    { "sdef", 4 },
                    { "dex", 4 },
                    { "tech", 4 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.48 },
                    { "atk", 0.1 },
                    { "satk", 0.63 },
                    { "def", 0.45 },
                    { "sdef", 0.61 },
                    { "dex", 0.61 },
                    { "tech", 0.61 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Sky Watcher",
                    "Dark Mage"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Lance",
                    "Tome"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                true,
                false
            )
        {
            FormalName = "Dark Flier";
        }
    }

    public class Breaker : Occupation
    {
        public Breaker()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 5 },
                    { "satk", 5 },
                    { "def", 2 },
                    { "sdef", 3 },
                    { "dex", 7 },
                    { "tech", 6 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.44 },
                    { "atk", 0.53 },
                    { "satk", 0.51 },
                    { "def", 0.41 },
                    { "sdef", 0.46 },
                    { "dex", 0.81 },
                    { "tech", 0.71 },
                },
                4,
                new List<string>(),
                new List<string>
                {
                    "Sky Watcher",
                    "Dark Mage"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Claw",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                true,
                false
            )
        {
            FormalName = "Breaker";
        }
    }
}
