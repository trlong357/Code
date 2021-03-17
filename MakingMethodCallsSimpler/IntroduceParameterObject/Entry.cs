using System;

namespace MakingMethodCallsSimpler.IntroduceParameterObject
{
    public class Entry
    {
        private readonly int value;
        private readonly DateTime chargeDate;

        public Entry(int value, DateTime chargeDate)
        {
            this.value = value;
            this.chargeDate = chargeDate;
        }

        public DateTime ChargeDate
        {
            get { return chargeDate; }
        }

        public int Value
        {
            get { return value; }
        }
    }
}