using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MakingMethodCallsSimpler.ReplaceExceptionwithTest
{
    class ReplaceExceptionwithTest
    {

        double GetValueForPeriod(int periodNumber)
        {
            if (periodNumber >= values.Length)
            {
                return 0;
            }
            return values[periodNumber];
        }
    }

    internal class values
    {
        public static int Length { get; internal set; }
    }
}
