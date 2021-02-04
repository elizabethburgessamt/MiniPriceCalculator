using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPriceCalculator.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateCreated { get; set; }
        public string CustomerName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DateCompleted { get; set; }
        public int Quantity { get; set; }
        public string Address { get; set; }

        public List<OrderItem> orderItems = new List<OrderItem>();

        public class OrderItem 
        { 
            public int OrderItemId { get; set; }
            public int OrderId { get; set; }
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public string Instructions { get; set; }

        }
    }
}
