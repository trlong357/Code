using MakingMethodCallsSimpler.SeparateQueryfromModifier;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class SeparateQueryfromModifierFact
    {
        [Fact]
        public void should_get_alert_message_if_people_names_include_don()
        {
            var peopleNames = new []{"Don", "Kent"};

            var separateQueryfromModifier = new SeparateQueryfromModifier();
            var alertMessage = separateQueryfromModifier.CheckSecurity(peopleNames);
            Assert.Equal("AlertDon", alertMessage);
        }

        [Fact]
        public void should_get_alert_message_if_people_names_include_john()
        {
            var peopleNames = new []{"John", "Kent"};

            var separateQueryfromModifier = new SeparateQueryfromModifier();
            var alertMessage = separateQueryfromModifier.CheckSecurity(peopleNames);
            Assert.Equal("AlertJohn", alertMessage);
        }

        [Fact]
        public void should_not_get_alert_message_if_people_names_does_include_don_and_john()
        {
            var peopleNames = new []{"Martin", "Kent"};

            var separateQueryfromModifier = new SeparateQueryfromModifier();
            var alertMessage = separateQueryfromModifier.CheckSecurity(peopleNames);
            Assert.Equal("", alertMessage);
        }
    }
}