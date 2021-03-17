using MakingMethodCallsSimpler.HideMethod;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class HideMethodFact
    {
        [Fact]
        public void should_get_last_reading_name()
        {
            var hideMethod = new HideMethod();
            Assert.Equal("Clean Code", hideMethod.GetLastReadingName());
        }
    }
}