namespace MakingMethodCallsSimpler.EncapsulateDowncast
{
    public class Reading
    {
        private readonly string name;

        public Reading(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
