namespace MakingMethodCallsSimpler.PreserveWholeObject
{
    public class Room
    {
        public bool WithinPlan(HeatingPlan plan)
        {
            var low = TempRange.GetLow();
            var high = TempRange.GetHigh();
            return plan.WithinRange(low, high);
        }

        public TempRange TempRange { get; set; }
    }
}