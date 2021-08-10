using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaWeekly.Model;

namespace PizzaWeekly.Controller
{
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {
        public List<Order> GetOrders()
        {
           var OrderList = new List<Order>();

            var order1 = new Order {
                Type = "Margarita",
                Crust = "American",
                Quantity = 3,
                Name = "Vivi Lu",
                Address = "Lørenvangen 1",
                Phone = "12345678"
            };             

            OrderList.Add(order1);

            return OrderList;
        }
    }
}
