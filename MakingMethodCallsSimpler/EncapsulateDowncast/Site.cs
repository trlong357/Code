using System.Collections.Generic;
using System.Linq;

namespace MakingMethodCallsSimpler.EncapsulateDowncast
{
    public class Site
    {
        public Site(List<Reading> readings)
        {
            Readings = readings;
        }

        public List<Reading> Readings { get; private set; }

        public object LastReading()
        {
            return Readings.Last();
        }
    }
}