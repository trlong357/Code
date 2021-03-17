using System;
using System.Runtime.Serialization;

namespace MakingMethodCallsSimpler.Replace_Error_Code_with_Exception
{
    [Serializable]
    internal class BalanceException : Exception
    {
        public BalanceException()
        {
        }

        public BalanceException(string message) : base(message)
        {
        }

        public BalanceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BalanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}