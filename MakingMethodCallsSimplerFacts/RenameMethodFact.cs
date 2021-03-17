using MakingMethodCallsSimpler.RenameMethod;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class RenameMethodFact
    {
        [Fact]
        public void should_get_office_telephone_number_for_customer()
        {
            var customer = new RenameMethod("CA", "0011");
            Assert.Equal("(CA) 0011", customer.GetTelephoneNumber());
        }
    }
}
