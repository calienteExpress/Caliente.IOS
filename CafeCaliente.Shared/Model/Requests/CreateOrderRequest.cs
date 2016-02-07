using System;
using System.Collections.Generic;
using System.Text;

namespace CalienteExpress.Shared.Model.Requests
{
    public class CreateOrderRequest : RequestBase
    {
        public List<OrderItem> Items { get; set; }

        public CreateOrderRequest()
        {
            this.Items = new List<OrderItem>(); 
        }
    }
}
