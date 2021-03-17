using System;

namespace MakingMethodCallsSimpler.AddParameter
{
    public class AddParameter
    {
        public string GetContact()
        {
            var currentDate = DateTime.Now;
            return currentDate > new DateTime(2012, 12, 31) ? "Kent" : "Martin";
        }
    }
}
