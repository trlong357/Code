using System;
using System.Collections.Generic;

namespace MakingMethodCallsSimpler.SeparateQueryfromModifier
{
    public class SeparateQueryfromModifier
    {
        private string alertedMessage;

        public string CheckSecurity(String[] people)
        {
            var found = FoundMiscreant(people);
            return SomeLaterCode(found);
        }

        private string SomeLaterCode(string found)
        {
            return alertedMessage + found;
        }

        private string FoundMiscreant(IEnumerable<string> peopleNames)
        {
            foreach (var name in peopleNames)
            {
                if (name.Equals("Don"))
                {
                    SendAlert();
                    return "Don";
                }
                if (name.Equals("John"))
                {
                    SendAlert();
                    return "John";
                }
            }
            return "";
        }

        private void SendAlert()
        {
            alertedMessage = "Alert";
        }
    }
}