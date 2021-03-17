using System;

namespace MakingMethodCallsSimpler.ParameterizeMethod
{
    public class ParameterizeMethodExample2
    {
        public ParameterizeMethodExample2(double lastUsage)
        {
            LastUsage = lastUsage;
        }

        public double BaseCharge()
        {
            var result = Math.Min(LastUsage, 100) * 0.03;
            if (LastUsage > 100)
            {
                result += (Math.Min(LastUsage, 200) - 100) * 0.05;
            }
            if (LastUsage > 200)
            {
                result += (LastUsage - 200) * 0.07;
            }
            return result;
        }

        public double LastUsage { get; private set; }
    }
}
