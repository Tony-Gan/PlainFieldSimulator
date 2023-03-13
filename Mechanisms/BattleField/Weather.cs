using System.Collections.Generic;

namespace PlainFieldSimulator.BattleField
{
    public abstract class Weather
    {
        // 方格特效补正
        // 物理伤害倍率，魔法伤害倍率，命中倍率，闪避倍率，移动加值
        private Dictionary<string, double> weatherFix;

        // 标准名
        private string formalName = "Undefined";

        public Weather(Dictionary<string, double> weatherFix)
        {
            this.weatherFix = weatherFix;
        }

        public Dictionary<string, double> WeatherFix { get { return weatherFix; } set { weatherFix = value; } }
        public string FormalName { get { return formalName; } set { formalName = value; } }
        public double GetPhyDmgRate() { return WeatherFix["phyDmgRate"]; }
        public double GetMgcDmgRate() { return WeatherFix["mgcDmgRate"]; }
        public double GetAccuracyRate() { return WeatherFix["accuracyRate"]; }
        public double GetDodgeRate() { return WeatherFix["dodgeRate"]; }
        public double GetMoveFix() { return WeatherFix["moveFix"]; }
    }

    public class Sunny : Weather
    {
        public Sunny() 
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Sunny";
        }
    }

    public class Cloudy : Weather
    {
        public Cloudy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Cloudy";
        }
    }

    public class LightRainy : Weather
    {
        public LightRainy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1.03 },
                { "accuracyRate", 0.97 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Rainy";
        }
    }

    public class MediumRainy : Weather
    {
        public MediumRainy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1.05 },
                { "accuracyRate", 0.95 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Rainy";
        }
    }

    public class HeavyRainy : Weather
    {
        public HeavyRainy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1.1 },
                { "accuracyRate", 0.9 },
                { "dodgeRate", 1 },
                { "moveFix", -1 },
            };
            FormalName = "Rainy";
        }
    }

    public class Snowy : Weather
    {
        public Snowy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Snowy";
        }
    }

    public class HeavySnowy : Weather
    {
        public HeavySnowy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 0.95 },
                { "mgcDmgRate", 1.05 },
                { "accuracyRate", 0.95 },
                { "dodgeRate", 1 },
                { "moveFix", -1 },
            };
            FormalName = "Snowy";
        }
    }

    public class Foggy : Weather
    {
        public Foggy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 0.85 },
                { "dodgeRate", 0.9 },
                { "moveFix", 0 },
            };
            FormalName = "Snowy";
        }
    }

    public class Storming : Weather
    {
        public Storming()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1.05 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Snowy";
        }
    }

    public class StronglyWindy : Weather
    {
        public StronglyWindy()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1.02 },
                { "mgcDmgRate", 0.98 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Snowy";
        }
    }

    public class Ethreal : Weather
    {
        public Ethreal()
            : base(new Dictionary<string, double> { })
        {
            WeatherFix = new Dictionary<string, double>
            {
                { "phyDmgRate", 1 },
                { "mgcDmgRate", 1 },
                { "accuracyRate", 1 },
                { "dodgeRate", 1 },
                { "moveFix", 0 },
            };
            FormalName = "Snowy";
        }
    }
}
