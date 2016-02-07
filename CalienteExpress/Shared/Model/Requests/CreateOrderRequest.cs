using System;
using System.Collections.Generic;
using System.Text;

namespace CalienteExpress.Shared.Model.Requests
{
    public class CreateOrderRequest
    {
        public List<OrderItem> Items { get; set; }
    }
}
