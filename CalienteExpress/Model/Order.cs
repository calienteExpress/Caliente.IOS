using System;
using System.Collections.Generic;
using System.Text;

namespace CalienteExpress.IOS.Model
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        public OrderType OrderType { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public float TotalPrice { get; set; }

        public List<OrderItem> Items { get; set; }
    }
}
