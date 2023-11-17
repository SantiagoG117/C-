namespace ObjectOrientedProgramming.InterfacesAndTestability
{
    public class ShippingCalculator : IShippingCalculator
    {
        //?Public methods
        /// <summary>
        /// If total price of the order is less than 30 dollars, the shipping cost will be 10% of the total price of the
        /// order
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <returns> If the shipping cost is more than 30 dollars, the shipping will be free</returns>
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            return 0;
        }
    }
}