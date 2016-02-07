using System;
using System.Collections.Generic;
using System.Text;

namespace CalienteExpress.Shared.Model
{
    public class MenuItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public List<MenuItemOption> Options { get; set; }

        public MenuItem()
        {
            this.Options = new List<MenuItemOption>(); 
        }
    }
}
