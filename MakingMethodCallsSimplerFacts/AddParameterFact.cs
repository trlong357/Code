using MakingMethodCallsSimpler.AddParameter;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class AddParameterFact
    {
        [Fact]
        public void should_get_contact_name()
        {
            var addParameter = new AddParameter();
            Assert.Equal("Kent", addParameter.GetContact());
        }
    }
}