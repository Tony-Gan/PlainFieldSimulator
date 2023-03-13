using System.Collections.Generic;

namespace PlainFieldSimulator.Occupations
{
    public class Samurai : Occupation
    {
        public Samurai()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 3 },
                    { "satk", 1 },
                    { "def", 2 },
                    { "sdef", 2 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.6 },
                    { "atk", 0.48 },
                    { "satk", 0.35 },
                    { "def", 0.39 },
                    { "sdef", 0.34 },
                    { "dex", 0.4 },
                    { "tech", 0.4 },
                },
                3,
                new List<string>
                {
                    "Sword Master",
                    "Master of Weapons",
                    "Berserker",
                    "Valkyrie",
                    "Mortal Savant"
                },
                new List<string>
                {
                    "Swordman",
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
            FormalName = "Samurai";
        }
    }

    public class LancerTrainer : Occupation
    {
        public LancerTrainer()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 3 },
                    { "satk", 1 },
                    { "def", 2 },
                    { "sdef", 2 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.6 },
                    { "atk", 0.48 },
                    { "satk", 0.35 },
                    { "def", 0.39 },
                    { "sdef", 0.34 },
                    { "dex", 0.4 },
                    { "tech", 0.4 },
                },
                3,
                new List<string>
                {
                    "Lance Master",
                    "Master of Weapons",
                    "Berserker",
                    "Valkyrie"
                },
                new List<string>
                {
                    "Lancer",
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
                    "MediumArmor",
                },
                false,
                false
            )
        {
            FormalName = "Lancer Trainer";
        }
    }

    public class Warrior : Occupation
    {
        public Warrior()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 4 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.66 },
                    { "atk", 0.54 },
                    { "satk", 0.34 },
                    { "def", 0.45 },
                    { "sdef", 0.32 },
                    { "dex", 0.34 },
                    { "tech", 0.33 },
                },
                3,
                new List<string>
                {
                    "Axe Master",
                    "Master of Weapons",
                    "Berserker",
                    "Valkyrie"
                },
                new List<string>
                {
                    "Axeman",
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
            FormalName = "Warrior";
        }
    }

    public class Fortress : Occupation
    {
        public Fortress()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 10 },
                    { "atk", 2 },
                    { "satk", 1 },
                    { "def", 6 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.84 },
                    { "atk", 0.32 },
                    { "satk", 0.12 },
                    { "def", 0.65 },
                    { "sdef", 0.24 },
                    { "dex", 0.33 },
                    { "tech", 0.33 },
                },
                3,
                new List<string>
                {
                    "Hero",
                    "General",
                    "Fortress Knight"
                },
                new List<string>
                {
                    "Armorman",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Axe",
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
            FormalName = "Fortress";
        }
    }

    public class ArmorKnight : Occupation
    {
        public ArmorKnight()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 3 },
                    { "satk", 1 },
                    { "def", 4 },
                    { "sdef", 2 },
                    { "dex", 1 },
                    { "tech", 1 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.76 },
                    { "atk", 0.35 },
                    { "satk", 0.12 },
                    { "def", 0.53 },
                    { "sdef", 0.36 },
                    { "dex", 0.33 },
                    { "tech", 0.33 },
                },
                3,
                new List<string>
                {
                    "General",
                    "Fortress Knight"
                },
                new List<string>
                {
                    "Cavalier",
                    "Armorman"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Axe",
                    "Crossbow"
                },
                new List<string>()
                {
                    "NoArmor",
                    "HeavyArmor"
                },
                false,
                true
            )
        {
            FormalName = "Armor Knight";
        }
    }

    public class Sniper : Occupation
    {
        public Sniper()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 5 },
                    { "satk", 1 },
                    { "def", 1 },
                    { "sdef", 2 },
                    { "dex", 3 },
                    { "tech", 1 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.34 },
                    { "atk", 0.6 },
                    { "satk", 0.12 },
                    { "def", 0.26 },
                    { "sdef", 0.31 },
                    { "dex", 0.5 },
                    { "tech", 0.45 },
                },
                3,
                new List<string>
                {
                    "Bow Master",
                    "Crossbow Master",
                    "Martial Master"
                },
                new List<string>
                {
                    "Longbow Man",
                    "Shortbow Man"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Knife"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LeatherArmor",
                    "LightArmor"
                },
                false,
                false
            )
        {
            FormalName = "Sniper";
        }
    }

    public class Trickster : Occupation
    {
        public Trickster()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 3 },
                    { "satk", 3 },
                    { "def", 2 },
                    { "sdef", 3 },
                    { "dex", 1 },
                    { "tech", 0 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.42 },
                    { "atk", 0.44 },
                    { "satk", 0.45 },
                    { "def", 0.33 },
                    { "sdef", 0.43 },
                    { "dex", 0.45 },
                    { "tech", 0.41 },
                },
                3,
                new List<string>
                {
                    "Crossbow Master",
                    "Battle Master",
                    "Martial Master",
                    "Breaker"
                },
                new List<string>
                {
                    "Longbow Man",
                    "Shortbow Man"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Knife"
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
            FormalName = "Trickster";
        }
    }

    public class Assassin : Occupation
    {
        public Assassin()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 2 },
                    { "satk", 2 },
                    { "def", 1 },
                    { "sdef", 1 },
                    { "dex", 4 },
                    { "tech", 4 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.34 },
                    { "atk", 0.4 },
                    { "satk", 0.4 },
                    { "def", 0.28 },
                    { "sdef", 0.28 },
                    { "dex", 0.6 },
                    { "tech", 0.58 },
                },
                3,
                new List<string>
                {
                    "Shadow Servent",
                    "Shapeless",
                    "Breaker",
                    "Martial Master"
                },
                new List<string>
                {
                    "Thief",
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Crossbow",
                    "Knife",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LeatherArmor",
                    "LightArmor"
                },
                false,
                false
            )
        {
            FormalName = "Assassin";
        }
    }

    public class Shadow : Occupation
    {
        public Shadow()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 2 },
                    { "satk", 3 },
                    { "def", 1 },
                    { "sdef", 2 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.46 },
                    { "atk", 0.33 },
                    { "satk", 0.49 },
                    { "def", 0.31 },
                    { "sdef", 0.39 },
                    { "dex", 0.45 },
                    { "tech", 0.46 },
                },
                3,
                new List<string>
                {
                    "Dark Mage",
                    "Shapeless",
                    "Necromancer",
                    "Breaker"
                },
                new List<string>
                {
                    "Thief",
                    "Wizard"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Claw",
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
            FormalName = "Shadow";
        }
    }

    public class LeaderReconoitor : Occupation
    {
        public LeaderReconoitor()
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
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.5 },
                    { "atk", 0.41 },
                    { "satk", 0.36 },
                    { "def", 0.33 },
                    { "sdef", 0.3 },
                    { "dex", 0.41 },
                    { "tech", 0.44 },
                },
                3,
                new List<string>
                {
                    "Paladin",
                    "Great Knight"
                },
                new List<string>
                {
                    "Thief",
                    "Cavalier"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spike",
                    "Sword"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                },
                false,
                true
            )
        {
            FormalName = "Leader Reconoitor";
        }
    }

    public class Knight : Occupation
    {
        public Knight()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 3 },
                    { "satk", 2 },
                    { "def", 2 },
                    { "sdef", 0 },
                    { "dex", 1 },
                    { "tech", 1 },
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.58 },
                    { "atk", 0.44 },
                    { "satk", 0.38 },
                    { "def", 0.39 },
                    { "sdef", 0.28 },
                    { "dex", 0.41 },
                    { "tech", 0.33 },
                },
                3,
                new List<string>
                {
                    "Fortress Knight",
                    "Paladin",
                    "Great Knight"
                },
                new List<string>
                {
                    "Cavalier"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spike",
                    "Sword"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                    "HeavyArmor",
                },
                false,
                true
            )
        {
            FormalName = "Knight";
        }
    }

    public class Warlock : Occupation
    {
        public Warlock()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 2 },
                    { "satk", 3 },
                    { "def", 1 },
                    { "sdef", 3 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.5 },
                    { "atk", 0.38 },
                    { "satk", 0.4 },
                    { "def", 0.37 },
                    { "sdef", 0.4 },
                    { "dex", 0.38 },
                    { "tech", 0.36 },
                },
                3,
                new List<string>
                {
                    "Dark Knight"
                },
                new List<string>
                {
                    "Sowrdman",
                    "Wizard"

                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spell",
                    "Tome",
                    "Claw",
                    "Sword"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                    "LeatherArmor"
                },
                false,
                false
            )
        {
            FormalName = "Warlock";
        }
    }

    public class Mage : Occupation
    {
        public Mage()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 1 },
                    { "satk", 5 },
                    { "def", 1 },
                    { "sdef", 4 },
                    { "dex", 1 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.38 },
                    { "atk", 0.22 },
                    { "satk", 0.51 },
                    { "def", 0.29 },
                    { "sdef", 0.62 },
                    { "dex", 0.39 },
                    { "tech", 0.33 },
                },
                3,
                new List<string>
                {
                    "Paladin",
                    "Sage",
                    "Mage Knight",
                    "Mortal Savant"
                },
                new List<string>
                {
                    "Bishop",
                    "Wizard"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spell",
                    "Tome",
                    "Stave"
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
            FormalName = "Mage";
        }
    }

    public class DarkMage : Occupation
    {
        public DarkMage()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 1 },
                    { "satk", 6 },
                    { "def", 0 },
                    { "sdef", 2 },
                    { "dex", 3 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.38 },
                    { "atk", 0.18 },
                    { "satk", 0.58 },
                    { "def", 0.24 },
                    { "sdef", 0.56 },
                    { "dex", 0.38 },
                    { "tech", 0.38 },
                },
                3,
                new List<string>
                {
                    "Darkness",
                    "Dark Knight",
                    "Necromancer",
                    "Dark Flier"
                },
                new List<string>
                {
                    "Bishop",
                    "Wizard"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spell",
                    "Tome",
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
            FormalName = "Dark Mage";
        }
    }

    public class Priest : Occupation
    {
        public Priest()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 1 },
                    { "satk", 4 },
                    { "def", 1 },
                    { "sdef", 2 },
                    { "dex", 2 },
                    { "tech", 2 },
                    { "move", 1 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.42 },
                    { "atk", 0.2 },
                    { "satk", 0.46 },
                    { "def", 0.23 },
                    { "sdef", 0.63 },
                    { "dex", 0.41 },
                    { "tech", 0.37 },
                },
                3,
                new List<string>
                {
                    "Sage",
                    "Mage Knight"
                },
                new List<string>
                {
                    "Bishop",
                    "Wizard"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Spell",
                    "Stave",
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
            FormalName = "Priest";
        }
    }

    public class WyvernRider : Occupation
    {
        public WyvernRider()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 6 },
                    { "atk", 4 },
                    { "satk", 1 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 1 },
                    { "tech", 1 },
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.6 },
                    { "atk", 0.44 },
                    { "satk", 0.33 },
                    { "def", 0.25 },
                    { "sdef", 0.41 },
                    { "dex", 0.44 },
                    { "tech", 0.31 },
                },
                3,
                new List<string>
                {
                    "Wyvern Lord"
                },
                new List<string>
                {
                    "Axeman",
                    "Pegasus Rider"
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
                true,
                false
            )
        {
            FormalName = "Wyvern Rider";
            GenderLimitation = 1;
        }
    }

    public class PegasusElite : Occupation
    {
        public PegasusElite()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 4 },
                    { "atk", 3 },
                    { "satk", 1 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 1 },
                    { "tech", 1 },
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.56 },
                    { "atk", 0.42 },
                    { "satk", 0.36 },
                    { "def", 0.28 },
                    { "sdef", 0.44 },
                    { "dex", 0.46 },
                    { "tech", 0.31 },
                },
                3,
                new List<string>
                {
                    "Falcon Knight"
                },
                new List<string>
                {
                    "Lancer",
                    "Pegasus Rider"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Lance",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                    "LeatherArmor"
                },
                true,
                false
            )
        {
            FormalName = "Pegasus Elite";
            GenderLimitation = 2;
        }
    }

    public class SkyWatcher : Occupation
    {
        public SkyWatcher()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 2 },
                    { "atk", 3 },
                    { "satk", 3 },
                    { "def", 0 },
                    { "sdef", 1 },
                    { "dex", 1 },
                    { "tech", 1 },
                    { "move", 2 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.52 },
                    { "atk", 0.39 },
                    { "satk", 0.39 },
                    { "def", 0.33 },
                    { "sdef", 0.35 },
                    { "dex", 0.45 },
                    { "tech", 0.4 },
                },
                3,
                new List<string>
                {
                    "Breaker"
                },
                new List<string>
                {
                    "Pegasus Rider"
                },
                new List<string>()
                {
                    "NoWeapon",
                    "Bow",
                    "Claw",
                    "Stave"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor"
                },
                true,
                false
            )
        {
            FormalName = "Sky Watcher";
        }
    }
}
