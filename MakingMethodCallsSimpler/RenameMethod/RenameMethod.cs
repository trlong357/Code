using System;

namespace MakingMethodCallsSimpler.RenameMethod
{
    public class RenameMethod
    {
        private readonly string officeAreaCode;
        private readonly string officeNumber;

        public RenameMethod(string officeAreaCode, string officeNumber)
        {
            this.officeAreaCode = officeAreaCode;
            this.officeNumber = officeNumber;
        }

        public String GetTelephoneNumber()
        {
            return ("(" + officeAreaCode + ") " + officeNumber);
        }
    }
}
