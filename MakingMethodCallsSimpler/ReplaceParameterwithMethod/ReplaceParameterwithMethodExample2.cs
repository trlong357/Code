namespace MakingMethodCallsSimpler.ReplaceParameterwithMethod
{
    public class ReplaceParameterwithMethodExample2
    {
        public decimal GetPrice(int quantity, decimal itemPrice)
        {
            var basePrice = quantity * itemPrice;
            int discountLevel;
            if (quantity > 100) discountLevel = 2;
            else discountLevel = 1;
            var finalPrice = GetDiscountedPrice(basePrice, discountLevel);
            return finalPrice;
        }

        private static decimal GetDiscountedPrice(decimal basePrice, int discountLevel)
        {
            return discountLevel == 2 ? basePrice*0.9M : basePrice;
        }
    }
}
