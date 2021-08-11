using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaWeekly.Model;

namespace PizzaWeekly.Controller
{
    [Route("[controller]/[action]")]
    public class OrderController : ControllerBase
    {

        private readonly OrderDB _orderDB;

        public OrderController(OrderDB db)
        {
            _orderDB = db;
        }

        public List<Order> GetOrders()
        {
            List<Order> OrderList = _orderDB.Orders.ToList();
            return OrderList;
        }

        // TODO: Change to boolean in order to print error message
        public void PlaceOrder(Order newOrder)
        {
            _orderDB.Add(newOrder);
            _orderDB.SaveChanges();
        }
    }
}
 