using MakingMethodCallsSimpler.ReplaceParameterwithExplicitMethods;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class ReplaceParameterwithExplicitMethodsFact
    {
        [Fact]
        public void should_get_setted_height_value()
        {
            var example1 = new ReplaceParameterwithExplicitMethodsExample1();
            example1.SetValue("height", 100);
            Assert.Equal(100, example1.Height);
        }

        [Fact]
        public void should_get_setted_width_value()
        {
            var example1 = new ReplaceParameterwithExplicitMethodsExample1();
            example1.SetValue("width", 50);
            Assert.Equal(50, example1.Width);
        }

        [Fact]
        public void should_create_engineer_given_type_is_engineer()
        {
            var employee = ReplaceParameterwithExplicitMethodsExample2.Create(0);
            Assert.Equal(typeof(Engineer), employee.GetType());
        }

        [Fact]
        public void should_create_salesman_given_type_is_salesman()
        {
            var employee = ReplaceParameterwithExplicitMethodsExample2.Create(1);
            Assert.Equal(typeof(Salesman), employee.GetType());
        }

        [Fact]
        public void should_create_manager_given_type_is_manager()
        {
            var employee = ReplaceParameterwithExplicitMethodsExample2.Create(2);
            Assert.Equal(typeof(Manager), employee.GetType());
        }
    }
}