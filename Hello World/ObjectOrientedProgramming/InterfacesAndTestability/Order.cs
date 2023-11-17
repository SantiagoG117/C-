using System;

namespace ObjectOrientedProgramming.InterfacesAndTestability
{
    public class Order
    {
        //?Properties
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }
        
        //?Public methods:
        public bool IsShipped()
        {
            return Shipment != null;
        }
    }
}