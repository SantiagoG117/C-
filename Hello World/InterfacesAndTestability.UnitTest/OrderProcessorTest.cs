using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ObjectOrientedProgramming.InterfacesAndTestability;

namespace InterfacesAndTestability.UnitTest
{
    /// <summary>
    /// Unit testing:
    ///     Instead manually testing our code, we write automated test to achieve that.
    /// 
    ///     When doing unit testing on a class, we need to isolate it. This means that we need to assume
    ///    that every other class in our application is working properly and see if the class under test
    ///     is working as expected. To achieve this, we must remove all dependencies from a class using
    ///     interfaces.
    /// 
    /// </summary>
    [TestClass]
    public class OrderProcessorTest
    {
        /*
         * [TestMethod] attribute represent metadata about the TestMethod1 and its methods
         * Convention to name methods: MethodName_Condition_Expectation
         */
        [TestMethod]
        //* Expected result of our method:
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            //* Create the class we are testing:
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            //* Create an order that has been already shipped by initializing the Shipment property of the order
            var order = new Order() { Shipment = new Shipment() };
            
            //* Because the order has already been shipped, we are expecting an exception
            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_ShouldSetShipmentPropertyOfOrder()
        {
            //* Create the class we are testing
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            //*Create an order that has not been shipped
            var order = new Order();
            
            orderProcessor.Process(order);
            
            //* Asset that the Shipment of the order is initialized properly:
            Assert.IsTrue(order.IsShipped());
            //* FakeShippingCalculator always return a 1 for cost of shipping
            Assert.AreEqual(1, order.Shipment.Cost);
            //* Assert that the date will be calculated properly (Tomorrow's date)
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
        
    }
    
    /*
     * We want to isolate the orderProcessor method so we can test it. So instead of sending a concrete real
     * implementation we send a Fake implementation. We
     */
    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            //* No logic: We assume this class is doing its job properly
            return 1;
        }
    }
    
}
