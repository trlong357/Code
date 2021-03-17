using MakingMethodCallsSimpler.ParameterizeMethod;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class ParameterizeMethodFact
    {
        [Fact]
        public void should_get_ten_percent_raise_of_salary()
        {
            var employee = new ParameterizeMethodExample1(100);
            const double result = 100*1.1;
            Assert.Equal(result, employee.TenPercentRaise());
        }

        [Fact]
        public void should_get_five_percent_raise_of_salary()
        {
            var employee = new ParameterizeMethodExample1(100);
            Assert.Equal(105, employee.FivePercentRaise());
        }

        [Fact]
        public void should_charge_three_percentage_given_last_usage_is_less_than_100_according_to_level_one_rule()
        {
            var employee = new ParameterizeMethodExample2(100);
            Assert.Equal(3, employee.BaseCharge());
        }

        [Fact]
        public void should_charge_five_percentage_of_last_usage_minus_100_more_than_level1_rule_given_last_usage_is_between_100_and_200_according_to_level_two_rule()
        {
            var employee = new ParameterizeMethodExample2(150);
            Assert.Equal(5.5, employee.BaseCharge());
        }

        [Fact]
        public void should_charge_seven_percentage_of_last_usage_minus_200_more_than_level2_given_last_usage_is_greater_than_200_according_to_level_three_rule()
        {
            var employee = new ParameterizeMethodExample2(250);
            Assert.Equal(11.5, employee.BaseCharge());
        }
    }
}