using MakingMethodCallsSimpler.ReplaceParameterwithMethod;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class ReplaceParameterwithMethodFact
    {
        [Fact]
        public void should_get_ninty_percentage_discount_given_name_is_kent()
        {
            var example1 = new ReplaceParameterwithMethodExample1("Kent");
            var price = example1.GetPrice(10, 10);
            Assert.Equal(90, price);
        }

        [Fact]
        public void should_not_get_discount_given_name_is_martin()
        {
            var example1 = new ReplaceParameterwithMethodExample1("Martin");
            var price = example1.GetPrice(10, 10);
            Assert.Equal(100, price);
        }

        [Fact]
        public void should_get_ninty_percentage_discount_given_quantity_is_over_100()
        {
            var example2 = new ReplaceParameterwithMethodExample2();
            var price = example2.GetPrice(200, 10);
            Assert.Equal(1800, price);
        }

        [Fact]
        public void should_not_get_discount_given_quantity_is_less_than_100()
        {
            var example2 = new ReplaceParameterwithMethodExample2();
            var price = example2.GetPrice(80, 10);
            Assert.Equal(800, price);
        }
    }
}