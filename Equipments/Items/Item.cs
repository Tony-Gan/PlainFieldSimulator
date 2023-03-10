using System.Collections.Generic;

namespace PlainFieldSimulator.Equipments.Items
{   
    public abstract class Item
    {
        // 是否消耗
        private readonly bool isComsumable;

        // 持续轮次
        private readonly int round;

        // 当前剩余伦次
        private int currLeftRound;

        // 持有上限
        private readonly int possessionLimitation;

        // 效果
        private readonly Dictionary<string, double> effects;

        // 标准名
        private string formalName = "Item";

        public Item(bool isComsumable, int round, int possessionLimitation, Dictionary<string, double> effects, string formalName)
        {
            this.isComsumable = isComsumable;
            this.round = round;
            this.currLeftRound = round;
            this.possessionLimitation = possessionLimitation;
            this.effects = effects;
            this.formalName = formalName;
        }

        public bool IsComsumable { get { return isComsumable; } }
        public int Round { get { return round; } }
        public int CurrentLeftRound { get {  return currLeftRound; } set { currLeftRound = value; } }
        public int CurrentPossessionLimitation { get {  return possessionLimitation; } }
        public Dictionary<string, double> Effects { get {  return effects; } }
        public string FormalName { get {  return formalName; } set { formalName = value; } }
    }
}
