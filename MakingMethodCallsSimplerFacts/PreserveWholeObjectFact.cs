using MakingMethodCallsSimpler.PreserveWholeObject;
using Xunit;

namespace MakingMethodCallsSimplerFacts
{
    public class PreserveWholeObjectFact
    {
        [Fact]
        public void should_get_room_within_plan_given_room_low_temp_is_not_lower_than_plan_low_temp_and_high_temp_is_not_higher_than_plan_high_temp()
        {
            var room = new Room {TempRange = new TempRange(10, 20)};
            var heatingPlan = new HeatingPlan(new TempRange(5, 25));
            Assert.True(room.WithinPlan(heatingPlan));
        }

        [Fact]
        public void should_get_room_not_within_plan_given_room_low_temp_is_higher_than_plan_low_temp()
        {
            var room = new Room {TempRange = new TempRange(10, 20)};
            var heatingPlan = new HeatingPlan(new TempRange(15, 25));
            Assert.False(room.WithinPlan(heatingPlan));
        }

        [Fact]
        public void should_get_room_not_within_plan_given_room_high_temp_is_lower_than_plan_high_temp()
        {
            var room = new Room {TempRange = new TempRange(10, 20)};
            var heatingPlan = new HeatingPlan(new TempRange(5, 15));
            Assert.False(room.WithinPlan(heatingPlan));
        }
    }
}