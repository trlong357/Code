using System;
using MakingMethodCallsSimpler.RemoveParameter;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class RemoveParameterFact
    {
        [Fact]
        public void should_get_contact_name()
        {
            var removeParameter = new RemoveParameter();
            Assert.Equal("Kent", removeParameter.GetContact(DateTime.Now));
        }
    }
}