using System;
using System.Collections.Generic;
using System.Text;

using CalienteExpress.Shared.Model;

namespace CalienteExpress.Shared.Views
{
    public class MenuView
    {
        public List<MenuTableRow> Rows { get; set; }

        public ButtonView ActionButton { get; set; }


        public class MenuTableRow
        {
            public MenuItem Item { get; set; }

            public List<MenuTableOption> Options { get; set; }
        }

        public class MenuTableOption
        {
            public MenuItemOption Option { get; set; }

            public bool IsSelected { get; set; }
        }
    }
}
