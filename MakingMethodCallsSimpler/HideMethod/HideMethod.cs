using System.Collections.Generic;
using System.Linq;

namespace MakingMethodCallsSimpler.HideMethod
{
    public class HideMethod
    {
        public string GetLastReadingName()
        {
            var readings = new[] { "Refactoring", "Clean Code" };
            return GetLast(readings);
        }

        public string GetLast(IEnumerable<string> readings)
        {
            return readings.Last();
        }
    }
}