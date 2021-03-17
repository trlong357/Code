namespace MakingMethodCallsSimpler.PreserveWholeObject
{
    public class TempRange
    {
        private readonly int low;
        private readonly int high;

        public TempRange(int low, int high)
        {
            this.low = low;
            this.high = high;
        }

        public int GetLow()
        {
            return low;
        }

        public int GetHigh()
        {
            return high;
        }
    }
}