using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CalienteExpress.Shared.Views;
using CalienteExpress.Shared.Model;
using CalienteExpress.Shared.Model.Responses;
using CalienteExpress.Shared.Service;

namespace CalienteExpress.Shared.Controllers
{
    public class MenuController
    {
        public MenuView View { get; private set; }

        public MenuController()
        {
            this.View = new MenuView(); 
            this.View.ActionButton = new ButtonView() 
            {
                Enabled = false,
                Text = "Next", 
                Action = ButtonAction
            }; 
        }

        public void SelectOption(MenuView.MenuTableRow row, MenuView.MenuTableOption option)
        {
        }

        public async Task PopulateMenu()
        {
            MenuResponse response = await ApiService.GetMenu();

            this.View = new MenuView();
            foreach (var item in response.Items)
            {
                var row = new MenuView.MenuTableRow() { Item = item };

                foreach (var option in item.Options)
                {
                    row.Options.Add(new MenuView.MenuTableOption() { Option = option }); 
                }

                View.Rows.Add(row);
            }
        }

        private void ButtonAction()
        {
        }
    }
}
