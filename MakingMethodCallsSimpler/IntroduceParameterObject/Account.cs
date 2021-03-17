using System;
using System.Collections.Generic;
using System.Linq;

namespace MakingMethodCallsSimpler.IntroduceParameterObject
{
    public class Account
    {
        private readonly List<Entry> entries;

        public Account(List<Entry> entries)
        {
            this.entries = entries;
        }

        public int GetFlowBetween(DateTime start, DateTime end)
        {
            var entriesWithinStartAndEnd = entries.Where(entry => entry.ChargeDate >= start && entry.ChargeDate <= end).ToList();
            return entriesWithinStartAndEnd.Sum(entry => entry.Value);
        }
    }
}