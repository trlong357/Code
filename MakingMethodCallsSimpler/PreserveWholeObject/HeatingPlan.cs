namespace MakingMethodCallsSimpler.PreserveWholeObject
{
    public class HeatingPlan
    {
        private readonly TempRange range;

        public HeatingPlan(TempRange range)
        {
            this.range = range;
        }

        public bool WithinRange(int low, int high)
        {
            return low >= range.GetLow() && high <= range.GetHigh();
        }
    }
}