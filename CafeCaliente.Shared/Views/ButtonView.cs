using System;
using System.Collections.Generic;
using System.Text;

namespace CalienteExpress.Shared.Views
{
    public class ButtonView
    {
        public string Text { get; set; }

        public bool Enabled { get; set; }

        public Action Action { get; set; }
    }
}
