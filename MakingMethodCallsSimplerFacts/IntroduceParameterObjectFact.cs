using System;
using System.Collections.Generic;
using MakingMethodCallsSimpler.IntroduceParameterObject;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class IntroduceParameterObjectFact
    {
        [Fact]
        public void should_get_flow_between_start_time_and_end_time()
        {
            var entries = new List<Entry> {new Entry(10, new DateTime(2012, 4, 1)), new Entry(20, new DateTime(2012, 6, 1))};
            var account = new Account(entries);
            var flows = account.GetFlowBetween(new DateTime(2012, 3, 1), new DateTime(2012, 4, 2));
            Assert.Equal(10, flows);
        }
    }
}