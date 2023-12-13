using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using SelfHostServer.Host.Models;

namespace SelfHostServer.Host
{
    public class OrderController : ApiController

    {
        Order[] orders = new Order[]
        {
            new Order {Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1},
            new Order {Id = 1, Name = "Yo-yo", Category = "Toys", Price = 3.50M},
            new Order {Id = 1, Name = "Hammer", Category = "Hardware", Price = 14.70M},
        };

        public IEnumerable<Order> GetAllOrders()
        {
            return orders;
        }
    }

}

