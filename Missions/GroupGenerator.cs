using System.Collections.Generic;
using PlainFieldSimulator.Equipments.Accessories;
using PlainFieldSimulator.Equipments.Armors;
using PlainFieldSimulator.Equipments.Weapons;
using PlainFieldSimulator.Exceptions;
using PlainFieldSimulator.Occupations;
using PlainFieldSimulator.Models;
using PlainFieldSimulator.Units;
using PlainFieldSimulator.Abilities;

namespace PlainFieldSimulator.Missions
{
    public class GroupGenerator
    {
        public static List<List<Unit>> GetMission1EnemyGroup(int difficulty)
        {
            List<Unit> units = new();

            // TEAM 1 UNIT 1 LV5/7/8 APPRENTICE FIGHTER
            Unit t1Fighter1 = new("Gleen", 1, 2, AttrsGrowthModels.GetLevel1GeneralPhyAttr(), AttrsGrowthModels.GetLevel1GeneralPhyGrowth(), new FighterApprentice())
            {
                TriggerLabel = 'a'
            };
            t1Fighter1.MultiLevelUp(4);
            t1Fighter1.AddWeapon(new IronSword());

            // TEAM 1 UNIT 2 LV5/7/8 APPRENTICE FIGHTER
            Unit t1Fighter2 = new("Dylon", 1, 2, AttrsGrowthModels.GetLevel1GeneralPhyAttr(), AttrsGrowthModels.GetLevel1GeneralPhyGrowth(), new FighterApprentice())
            {
                TriggerLabel = 'a'
            };
            t1Fighter2.MultiLevelUp(4);
            t1Fighter2.AddWeapon(new IronSword());

            // TEAM 1 UNIT 3 LV6/8/9 LEADER ARMORMAN
            Unit t1Leader = new("Kas", 1, 2, AttrsGrowthModels.GetLevel1GeneralDefAttr(), AttrsGrowthModels.GetLevel1GeneralDefGrowth(), new BlacksmithApprentice())
            {
                TriggerLabel = 'a',
                Armor = new TrainingLightArmor()
            };
            if (difficulty > 3) { t1Leader.AddAbility(new DifficultyModifier2()); }
            t1Leader.MultiLevelUp(5);
            t1Leader.AddWeapon(new IronSpike());

            List<Unit> t1 = new()
            {
                t1Fighter1,
                t1Fighter2,
                t1Leader
            };


            // TEAM 2 UNIT 1 LV5/7/8 APPRENTICE FIGHTER
            Unit t2Fighter1 = new("Alex", 1, 3, AttrsGrowthModels.GetLevel1GeneralPhyAttr(), AttrsGrowthModels.GetLevel1GeneralPhyGrowth(), new FighterApprentice())
            {
                TriggerLabel = 'b'
            };
            t2Fighter1.MultiLevelUp(4);
            t2Fighter1.AddWeapon(new IronSpike());

            // TEAM 2 UNIT 2 LV5/7/8 APPRENTICE FIGHTER
            Unit t2Fighter2 = new("Cease", 2, 3, AttrsGrowthModels.GetLevel1GeneralPhyAttr(), AttrsGrowthModels.GetLevel1GeneralPhyGrowth(), new FighterApprentice())
            {
                TriggerLabel = 'b'
            };
            t2Fighter2.MultiLevelUp(4);
            t2Fighter2.AddWeapon(new IronAxe());

            // TEAM 2 UNIT 3 LV5/7/8 APPRENTICE ARCHER
            Unit t2Hunter1 = new("Olivia", 1, 3, AttrsGrowthModels.GetLevel1GeneralArcAttr(), AttrsGrowthModels.GetLevel1GeneralArcGrowth(), new ArcherApprentice())
            {
                TriggerLabel = 'b'
            };
            t2Hunter1.MultiLevelUp(4);
            t2Hunter1.AddWeapon(new IronBow());

            // TEAM 2 UNIT 4 LV5/7/8 APPRENTICE ARCHER
            Unit t2Hunter2 = new("Ore", 1, 3, AttrsGrowthModels.GetLevel1GeneralArcAttr(), AttrsGrowthModels.GetLevel1GeneralArcGrowth(), new ArcherApprentice())
            {
                TriggerLabel = 'b'
            };
            t2Hunter2.MultiLevelUp(4);
            t2Hunter2.AddWeapon(new IronBow());

            List<Unit> t2 = new()
            {
                t2Fighter1,
                t2Fighter2,
                t2Hunter1,
                t2Hunter2
            };


            // TEAM 3 UNIT 1 LV5/7/8 APPRENTICE FIGHTER
            Unit t3Fighter1 = new("Kate", 2, 3, AttrsGrowthModels.GetLevel1GeneralBlcAttr(), AttrsGrowthModels.GetLevel1GeneralBlcGrowth(), new FighterApprentice())
            {
                TriggerLabel = 'c'
            };
            t3Fighter1.MultiLevelUp(4);
            t3Fighter1.AddWeapon(new AirBlade());

            // TEAM 3 UNIT 2 LV5/7/8 APPRENTICE FIGHTER
            Unit t3Fighter2 = new("Linda", 2, 3, AttrsGrowthModels.GetLevel1GeneralBlcAttr(), AttrsGrowthModels.GetLevel1GeneralBlcGrowth(), new FighterApprentice())
            {
                TriggerLabel = 'c'
            };
            t3Fighter2.MultiLevelUp(4);
            t3Fighter2.AddWeapon(new AirBlade());

            // TEAM 3 UNIT 3 LV5/7/8 APPRENTICE ARCHER
            Unit t3Hunter1 = new("Pony", 1, 3, AttrsGrowthModels.GetLevel1GeneralArcAttr(), AttrsGrowthModels.GetLevel1GeneralArcGrowth(), new ArcherApprentice())
            {
                TriggerLabel = 'c'
            };
            t3Hunter1.MultiLevelUp(4);
            t3Hunter1.AddWeapon(new WoodCrossbow());

            // TEAM 3 UNIT 4 LV5/7/8 APPRENTICE ARCHER
            Unit t3Hunter2 = new("Louis", 1, 3, AttrsGrowthModels.GetLevel1GeneralArcAttr(), AttrsGrowthModels.GetLevel1GeneralArcGrowth(), new ArcherApprentice())
            {
                TriggerLabel = 'c'
            };
            t3Hunter2.MultiLevelUp(4);
            t3Hunter2.AddWeapon(new WoodCrossbow());

            List<Unit> t3 = new()
            {
                t3Fighter1,
                t3Fighter2,
                t3Hunter1,
                t3Hunter2
            };


            // DIFFICULTY MODIFIERS
            if (difficulty > 1)
            {
                t1Fighter1.MultiLevelUp(2);
                t1Fighter2.MultiLevelUp(2);
                t1Leader.MultiLevelUp(2);
                t2Fighter1.MultiLevelUp(2);
                t2Fighter2.MultiLevelUp(2);
                t2Hunter1.MultiLevelUp(2);
                t2Hunter2.MultiLevelUp(2);
                t3Fighter1.MultiLevelUp(2);
                t3Fighter2.MultiLevelUp(2);
                t3Hunter1.MultiLevelUp(2);
                t3Hunter2.MultiLevelUp(2);
            }
            if (difficulty > 2)
            {
                t1Fighter1.MultiLevelUp(1);
                t1Fighter1.SetArmor(new TrainingLightArmor());
                t1Fighter2.MultiLevelUp(1);
                t1Fighter2.SetArmor(new TrainingLightArmor());
                t1Leader.MultiLevelUp(1);
                t1Leader.SetArmor(new TrainingMediumArmor());
                t2Fighter1.MultiLevelUp(1);
                t2Fighter1.SetArmor(new TrainingLightArmor());
                t2Fighter2.MultiLevelUp(1);
                t2Fighter2.SetArmor(new TrainingLightArmor());
                t2Hunter1.MultiLevelUp(1);
                t2Hunter1.SetArmor(new TrainingLeatherArmor());
                t2Hunter2.MultiLevelUp(1);
                t2Hunter2.SetArmor(new TrainingLeatherArmor());
                t3Fighter1.MultiLevelUp(1);
                t3Fighter1.SetArmor(new TrainingLightArmor());
                t3Fighter2.MultiLevelUp(1);
                t3Fighter2.SetArmor(new TrainingLightArmor());
                t3Hunter1.MultiLevelUp(1);
                t3Hunter1.SetArmor(new TrainingLeatherArmor());
                t3Hunter2.MultiLevelUp(1);
                t3Hunter2.SetArmor(new TrainingLeatherArmor());
            }
            if (difficulty > 3)
            {
                t1Fighter1.SetArmor(new TrainingMediumArmor());
                t1Fighter1.Accessory = new RubyNecklace();
                t1Fighter1.AddAbility(new ExtraDifficultyModifier1());
                t1Fighter2.SetArmor(new TrainingMediumArmor());
                t1Fighter2.Accessory = new RubyNecklace();
                t1Fighter2.AddAbility(new ExtraDifficultyModifier1());
                t1Leader.SetArmor(new TrainingHeavyArmor());
                t1Leader.Accessory = new LeatherShield();
                t1Leader.AddAbility(new ExtraDifficultyModifier1());
                t2Fighter1.SetArmor(new TrainingMediumArmor());
                t2Fighter1.Accessory = new RubyNecklace();
                t2Fighter2.SetArmor(new TrainingMediumArmor());
                t2Fighter2.Accessory = new RubyNecklace();
                t2Hunter1.AddAbility(new ExtraDifficultyModifier1());
                t2Hunter1.Accessory = new SapphireNecklace();
                t2Hunter2.AddAbility(new ExtraDifficultyModifier1());
                t2Hunter2.Accessory = new SapphireNecklace();
                t3Fighter1.SetArmor(new TrainingMediumArmor());
                t3Fighter1.Accessory = new RubyNecklace();
                t3Fighter2.SetArmor(new TrainingMediumArmor());
                t3Fighter2.Accessory = new RubyNecklace();
                t3Hunter1.AddAbility(new ExtraDifficultyModifier1());
                t3Hunter1.Accessory = new SapphireNecklace();
                t3Hunter2.AddAbility(new ExtraDifficultyModifier1());
                t3Hunter2.Accessory = new SapphireNecklace();
            }


            return new List<List<Unit>>() { t1, t2, t3 };
        }
    }

    public class MainCharacterGroupGenerator
    {
        public static Unit GenerateMainCharacter(string name, int gender)
        {
            Dictionary<string, int> attrs = new()
            {
                { "maxhp", 22 },
                { "hp", 22 },
                { "atk", 13 },
                { "satk", 9 },
                { "def", 10 },
                { "sdef", 8 },
                { "dex", 11 },
                { "tech", 12 },
                { "move", 5 },
                { "exp", 0 },
            };
            Dictionary<string, double> growth = new()
            {
                { "hp", 0.48 },
                { "atk", 0.25 },
                { "satk", 0.21 },
                { "def", 0.20 },
                { "sdef", 0.17 },
                { "dex", 0.21 },
                { "tech", 0.23 }
            };
            Unit unit = new(name, gender, 1, attrs, growth, new FighterApprentice());
            unit.AddWeapon(new IronSword());
            unit.Armor = new TrainingLightArmor();
            unit.MultiLevelUp(4);
            unit.AddAbility(new Strong());

            return unit;
        }

        public static Unit GenerateAlissaCharacter()
        {
            Dictionary<string, int> attrs = new()
            {
                { "maxhp", 17 },
                { "hp", 17 },
                { "atk", 8 },
                { "satk", 13 },
                { "def", 6 },
                { "sdef", 8 },
                { "dex", 13 },
                { "tech", 10 },
                { "move", 5 },
                { "exp", 0 },
            };
            Dictionary<string, double> growth = new()
            {
                { "hp", 0.33 },
                { "atk", 0.17 },
                { "satk", 0.26 },
                { "def", 0.20 },
                { "sdef", 0.29 },
                { "dex", 0.23 },
                { "tech", 0.20 }
            };
            Unit unit = new("Alissa", 2, 1, attrs, growth, new WizardApprentice());
            unit.MultiLevelUp(4);
            unit.Armor = new TrainingLeatherArmor();
            unit.AddWeapon(new TrainingStave());
            unit.AddAbility(new Clever());

            return unit;
        }

        public static Unit GenerateCloudCharacter()
        {
            Dictionary<string, int> attrs = new()
            {
                { "maxhp", 28 },
                { "hp", 28 },
                { "atk", 10 },
                { "satk", 5 },
                { "def", 15 },
                { "sdef", 3 },
                { "dex", 9 },
                { "tech", 11 },
                { "move", 5 },
                { "exp", 0 },
            };
            Dictionary<string, double> growth = new()
            {
                { "hp", 0.51 },
                { "atk", 0.2 },
                { "satk", 0.1 },
                { "def", 0.3 },
                { "sdef", 0.08 },
                { "dex", 0.18 },
                { "tech", 0.23 }
            };
            Unit unit = new("Cloud", 1, 1, attrs, growth, new BlacksmithApprentice());
            unit.MultiLevelUp(4);
            unit.Armor = new TrainingMediumArmor();
            unit.AddWeapon(new IronAxe());
            unit.AddAbility(new Tough());

            return unit;
        }
    }
}
