using System;
using System.Collections.Generic;
using System.Text;

namespace CalienteExpress.Shared.Model.Responses
{
    public class MenuResponse : ResponseBase
    {
        public List<MenuItem> Items { get; set; }

        public MenuResponse() : base()
        {
            this.Items = new List<MenuItem>(); 
        }
    }
}
