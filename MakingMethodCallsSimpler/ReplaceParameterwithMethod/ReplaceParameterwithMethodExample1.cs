namespace MakingMethodCallsSimpler.ReplaceParameterwithMethod
{
    public class ReplaceParameterwithMethodExample1
    {
        private readonly string name;

        public ReplaceParameterwithMethodExample1(string name)
        {
            this.name = name;
        }

        public decimal GetPrice(int quantity, decimal itemPrice)
        {
            var basePrice = quantity * itemPrice;
            var discountLevel = GetDiscountLevel();
            return GetDiscountedPrice(basePrice, discountLevel);
        }

        private static decimal GetDiscountedPrice(decimal basePrice, int discountLevel)
        {
            return discountLevel == 2 ? basePrice*0.9M : basePrice;
        }

        private int GetDiscountLevel()
        {
            return name.Equals("Kent") ? 2 : 1;
        }
    }
}
