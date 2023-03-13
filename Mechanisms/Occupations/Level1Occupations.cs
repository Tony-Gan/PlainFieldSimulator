using System.Collections.Generic;
using PlainFieldSimulator.Abilities;

namespace PlainFieldSimulator.Occupations
{
    public class FighterApprentice : Occupation
    {
        public FighterApprentice() 
            : base
            (
                new Dictionary<string, int> 
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                }, 
                new Dictionary<string, double>
                {
                    { "hp", 0.4 },
                    { "atk", 0.25 },
                    { "satk", 0.15 },
                    { "def", 0.18 },
                    { "sdef", 0.14 },
                    { "dex", 0.24 },
                    { "tech", 0.24 },
                }, 
                1,
                new List<string>()
                {
                    "Swordman",
                    "Lancer",
                    "Axeman",
                    "Shortbow Man",
                    "Armorman",
                    "Thief",
                    "Cavalier",
                    "Pegasus Rider"
                },
                new List<string>(), 
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Axe",
                    "Spike",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                    "LeatherArmor",
                },
                false, 
                false
            )
        {
            FormalName = "Fighter Apprentice";
        }
    }

    public class BlacksmithApprentice : Occupation
    {
        public BlacksmithApprentice()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.54 },
                    { "atk", 0.2 },
                    { "satk", 0.12 },
                    { "def", 0.4 },
                    { "sdef", 0.05 },
                    { "dex", 0.18 },
                    { "tech", 0.18 },
                },
                1,
                new List<string>
                {
                    "Swordman",
                    "Lancer",
                    "Axeman",
                    "Armorman"
                },
                new List<string>(),
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Axe",
                    "Spike",
                },
                new List<string>()
                {
                    "NoArmor",
                    "HeavyArmor",
                    "MediumArmor",
                },
                false,
                false
            )
        {
            FormalName = "Blacksmith Apprentice";
        }
    }

    public class ArcherApprentice : Occupation
    {
        public ArcherApprentice()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.36 },
                    { "atk", 0.22 },
                    { "satk", 0.22 },
                    { "def", 0.12 },
                    { "sdef", 0.17 },
                    { "dex", 0.25 },
                    { "tech", 0.24 },
                },
                1,
                new List<string>
                {
                    "Longbow Man",
                    "Shortbow Man",
                    "Crossbow Rider"
                },
                new List<string>(),
                new List<string>()
                {
                    "NoWeapon",
                    "Knife",
                    "Claw",
                    "Bow",
                    "Crossbow",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Archer Apprentice";
        }
    }

    public class HunterApprentice : Occupation
    {
        public HunterApprentice()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.28 },
                    { "atk", 0.18 },
                    { "satk", 0.2 },
                    { "def", 0.14 },
                    { "sdef", 0.16 },
                    { "dex", 0.3 },
                    { "tech", 0.28 },
                },
                1,
                new List<string>
                {
                    "Longbow Man",
                    "Shortbow Man",
                    "Magic Blader",
                    "Thief"
                },
                new List<string>(),
                new List<string>()
                {
                    "NoWeapon",
                    "Knife",
                    "Claw",
                    "Crossbow",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Hunter Apprentice";
        }
    }

    public class RiderApprentice : Occupation
    {
        public RiderApprentice()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.32 },
                    { "atk", 0.25 },
                    { "satk", 0.16 },
                    { "def", 0.18 },
                    { "sdef", 0.15 },
                    { "dex", 0.22 },
                    { "tech", 0.28 },
                },
                1,
                new List<string>
                {
                    "Cavalier",
                    "Crossbow Rider",
                    "Pegasus Rider"
                },
                new List<string>(),
                new List<string>()
                {
                    "NoWeapon",
                    "Spike",
                    "Sword",
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Rider Apprentice";
        }
    }

    public class MageApprentice : Occupation
    {
        public MageApprentice()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.2 },
                    { "atk", 0.12 },
                    { "satk", 0.3 },
                    { "def", 0.12 },
                    { "sdef", 0.28 },
                    { "dex", 0.22 },
                    { "tech", 0.26 },
                },
                1,
                new List<string>
                {
                    "Magic Blader",
                    "Wizard",
                    "Bishop",
                },
                new List<string>(),
                new List<string>()
                {
                    "Tome",
                    "Crossbow",
                    "MgcClaw",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Mage Apprentice";
        }
    }

    public class WizardApprentice : Occupation
    {
        public WizardApprentice()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.26 },
                    { "atk", 0.15 },
                    { "satk", 0.2 },
                    { "def", 0.18 },
                    { "sdef", 0.32 },
                    { "dex", 0.24 },
                    { "tech", 0.18 },
                },
                1,
                new List<string>()
                {
                    "Wizard",
                    "Bishop",
                },
                new List<string>(),
                new List<string>()
                {
                    "Stave",
                    "Crossbow",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Wizard Apprentice";
        }
    }

    public class Villager : Occupation
    {
        public Villager()
            : base
            (
                new Dictionary<string, int>
                {
                    { "hp", 0 },
                    { "atk", 0 },
                    { "satk", 0 },
                    { "def", 0 },
                    { "sdef", 0 },
                    { "dex", 0 },
                    { "tech", 0 },
                    { "move", 0 },
                },
                new Dictionary<string, double>
                {
                    { "hp", 0.2 },
                    { "atk", 0.1 },
                    { "satk", 0.1 },
                    { "def", 0.1 },
                    { "sdef", 0.1 },
                    { "dex", 0.1 },
                    { "tech", 0.1 },
                },
                1,
                new List<string>
                {
                    "Swordman",
                    "Lancer",
                    "Axeman",
                    "Shortbow Man",
                    "Longbow Man",
                    "Armorman",
                    "Magic Blader",
                    "Thief",
                    "Cavalier",
                    "Crossbow Rider",
                    "Bishop",
                    "Wizard",
                    "Pegasus Rider"
                },
                new List<string>(),
                new List<string>()
                {
                    "NoWeapon",
                    "Sword",
                    "Axe",
                    "Spike",
                    "Claw",
                    "Bow",
                    "Crossbow",
                    "Tome",
                    "Stave",
                    "Spell"
                },
                new List<string>()
                {
                    "NoArmor",
                    "LightArmor",
                    "MediumArmor",
                    "HeavyArmor",
                    "LeatherArmor",
                },
                false,
                false
            )
        {
            FormalName = "Villager";
            OccupationAbility.Add(new Genious());
        }
    }
}
