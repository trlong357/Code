using System.Collections.Generic;
using MakingMethodCallsSimpler.EncapsulateDowncast;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class EncapsulateDowncastFact
    {
        [Fact]
        public void should_get_last_reading_name()
        {
            var readings = new List<Reading> {new Reading("Refactoring"), new Reading("Clean Code")};
            var site = new Site(readings);
            var readingName = ((Reading)site.LastReading()).Name;
            Assert.Equal("Clean Code", readingName);
        }
    }
}