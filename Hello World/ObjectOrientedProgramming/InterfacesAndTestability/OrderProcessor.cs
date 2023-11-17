using System;

namespace ObjectOrientedProgramming.InterfacesAndTestability
{
    
    public class OrderProcessor
    {
        //? Attributes
        /*
         * Loose coupling: OrderProcessor is not dependent on a concrete implementation. It is dependent on an interface
         * that defines the role of a shipping calculator to calculate the shipping cost
         */ 
        
        private readonly IShippingCalculator _shippingCalculator;

        //? Constructor
        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public void Process(Order order)
        {
            //? Test case
            if (order.IsShipped())
                throw new InvalidOperationException("This order is already processed");
            
            //* If order has not been shipped, create a new Shipment and assign it to the Shipment property of the current order 
            order.Shipment = new Shipment()
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}