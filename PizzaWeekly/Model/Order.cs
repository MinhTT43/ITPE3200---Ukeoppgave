using System;
namespace PizzaWeekly.Model
{
    public class Order
    {
        public int OId { get; set; }
        public string Type { get; set; }
        public string Crust { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
