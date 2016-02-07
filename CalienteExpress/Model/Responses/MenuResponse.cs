using System;
using System.Collections.Generic;
using System.Text;

namespace CalienteExpress.IOS.Model.Responses
{
    public class MenuResponse : ResponseBase
    {
        public List<MenuItem> Items { get; set; }
    }
}
