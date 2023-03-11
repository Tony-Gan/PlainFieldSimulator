using PlainFieldSimulator.Abilities;
using PlainFieldSimulator.Occupations;
using PlainFieldSimulator.Equipments.Accessories;
using PlainFieldSimulator.Units;
using PlainFieldSimulator.Missions;
using PlainFieldSimulator.Equipments.Weapons;
using PlainFieldSimulator.Algorithms;
using UnityEngine;
using PlainFieldSimulator.BattleField;
using PlainFieldSimulator.Equipments.Armors;

namespace PlainFieldSimulator
{
    class Program : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Unit LEO = MainCharacterGroupGenerator.GenerateMainCharacter();
            LEO.Accessory = new SapphireNecklace();
            LEO.MultiLevelUp(5);
            LEO.StageUp(new Swordman());
            LEO.MultiLevelUp(10);
            LEO.StageUp(new Samurai());
            LEO.MultiLevelUp(10);
            LEO.StageUp(new SwordMaster());
            LEO.MultiLevelUp(20);
            Debug.Log(LEO);

            Unit MARLO = MainCharacterGroupGenerator.GenerateMainCharacter();
            MARLO.AddWeapon(new ShortKnife());
            MARLO.Accessory = new EmeraldNecklace();
            MARLO.MultiLevelUp(5);
            MARLO.StageUp(new Thief());
            MARLO.MultiLevelUp(10);
            MARLO.StageUp(new Assassin());
            MARLO.MultiLevelUp(10);
            MARLO.StageUp(new Shapeless());
            MARLO.MultiLevelUp(20);
            Debug.Log(MARLO);

            Unit ALISSA = MainCharacterGroupGenerator.GenerateAlissaCharacter();
            ALISSA.AddWeapon(new Fire());
            ALISSA.AddWeapon(new EthrealClaw());
            ALISSA.Accessory = new SapphireNecklace();
            ALISSA.MultiLevelUp(5);
            ALISSA.StageUp(new Bishop());
            ALISSA.MultiLevelUp(10);
            ALISSA.StageUp(new Mage());
            ALISSA.MultiLevelUp(10);
            ALISSA.StageUp(new Sage());
            ALISSA.MultiLevelUp(20);
            ALISSA.SetArmor(new TrainingLeatherArmor());
            Debug.Log(ALISSA);

            Unit CLOUD = MainCharacterGroupGenerator.GenerateCloudCharacter();
            CLOUD.AddWeapon(new WoodCrossbow());
            CLOUD.AddWeapon(new IronSpike());
            CLOUD.Accessory = new IronShield();
            CLOUD.MultiLevelUp(5);
            CLOUD.StageUp(new Armorman());
            CLOUD.MultiLevelUp(10);
            CLOUD.StageUp(new Fortress());
            CLOUD.MultiLevelUp(10);
            CLOUD.StageUp(new Hero());
            CLOUD.MultiLevelUp(20);
            CLOUD.SetArmor(new TrainingHeavyArmor());
            Debug.Log(CLOUD);

            Unit JOHN = MainCharacterGroupGenerator.GenerateJohnCharacter();
            JOHN.AddWeapon(new IronBow());
            JOHN.AddWeapon(new BluntClaw());
            JOHN.Accessory = new SapphireNecklace();
            JOHN.MultiLevelUp(9);
            JOHN.StageUp(new LongbowMan());
            JOHN.MultiLevelUp(10);
            JOHN.StageUp(new Sniper());
            JOHN.MultiLevelUp(10);
            JOHN.StageUp(new BowMaster());
            JOHN.MultiLevelUp(20);
            JOHN.SetArmor(new TrainingLightArmor());
            Debug.Log(JOHN);

            Debug.Log(BattleAlgorithms.PrintBattleInfo(LEO, MARLO, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
            Debug.Log(BattleAlgorithms.PrintBattleInfo(LEO, CLOUD, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
            Debug.Log(BattleAlgorithms.PrintBattleInfo(LEO, ALISSA, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
            Debug.Log(BattleAlgorithms.PrintBattleInfo(LEO, JOHN, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
            Debug.Log(BattleAlgorithms.PrintBattleInfo(ALISSA, CLOUD, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
            Debug.Log(BattleAlgorithms.PrintBattleInfo(JOHN, ALISSA, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
            Debug.Log(BattleAlgorithms.PrintBattleInfo(MARLO, CLOUD, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
            Debug.Log(BattleAlgorithms.PrintBattleInfo(ALISSA, ALISSA, new SandSurface(), new SandSurface(), new Sunny(), new Daytime(), false));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}