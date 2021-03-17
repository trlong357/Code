using System;

namespace MakingMethodCallsSimpler.ReplaceParameterwithExplicitMethods
{
    public class ReplaceParameterwithExplicitMethodsExample2
    {
        private const int Engineer = 0;
        private const int Salesman = 1;
        private const int Manager = 2;

        public static Employee Create(int type)
        {
            switch (type)
            {
                case Engineer:
                    return new Engineer();
                case Salesman:
                    return new Salesman();
                case Manager:
                    return new Manager();
                default:
                    throw new ApplicationException("Incorrect type code value");
            }
        }
    }
}