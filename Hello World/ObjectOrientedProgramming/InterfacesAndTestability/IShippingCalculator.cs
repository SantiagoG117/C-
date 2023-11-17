namespace ObjectOrientedProgramming.InterfacesAndTestability
{
    /// <summary>
    /// By defining this interface, we are defining a role or capability: The role of calculating shipping
    /// 
    /// </summary>
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
}