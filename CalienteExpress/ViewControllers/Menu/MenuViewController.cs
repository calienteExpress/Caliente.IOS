using System;
using System.Collections.Generic;
using System.Text;

using Foundation;
using UIKit;

using CalienteExpress.Shared.Controllers;
using CalienteExpress.Shared.Views;
using CalienteExpress.IOS.Widgets;

namespace CalienteExpress.IOS.ViewControllers.Menu
{
    public class MenuViewController : ViewControllerBase
    {
        private MenuController controller = new MenuController();
        private MenuTableViewController tableViewController;
        private AppButton actionButton; 

        public MenuViewController() : base() 
        {
            //menu display table
            this.tableViewController = new MenuTableViewController(this.controller);

            //action button 
            this.actionButton = new AppButton();
            this.actionButton.SetTitle(controller.View.ActionButton.Text, UIControlState.Normal);
            this.actionButton.SetTitle(controller.View.ActionButton.Text, UIControlState.Disabled);
            this.actionButton.TouchUpInside += (o, e) =>
            {
                this.controller.View.ActionButton.Action(); 
            };

            //add subviews
            this.View.AddSubviews(this.tableViewController.TableView, this.actionButton); 
        }

        public async override void ViewDidLoad()
        {
            base.ViewDidLoad();

            await this.controller.PopulateMenu(); 
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
        }
    }
}
