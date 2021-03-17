namespace MakingMethodCallsSimpler.ParameterizeMethod
{
    public class ParameterizeMethodExample1
    {
        private double salary;

        public ParameterizeMethodExample1(double salary)
        {
            this.salary = salary;
        }

        public double TenPercentRaise()
        {
            salary *= 1.1;
            return salary;
        }

        public double FivePercentRaise()
        {
            salary *= 1.05;
            return salary;
        }
    }
}
