using System;
using System.Collections.Generic;
using System.Text;

using Foundation;
using UIKit;

using CalienteExpress.Shared.Controllers;
using CalienteExpress.Shared.Views;

namespace CalienteExpress.IOS.ViewControllers.Menu
{
    public class MenuTableViewController : UITableViewController
    {
        private MenuController controller;

        public MenuTableViewController(MenuController controller)
            : base()
        {
            this.controller = controller;
            TableView.RegisterClassForCellReuse(typeof(MenuTableViewCell), new NSString(MenuTableViewCell.Key));
            this.TableView.Source = new MenuTableViewSource(controller);
        }



        private class MenuTableViewSource : UITableViewSource
        {
            private MenuController controller;

            public MenuTableViewSource(MenuController controller)
            {
                this.controller = controller;
            }

            public override nint NumberOfSections(UITableView tableView)
            {
                return 1;
            }

            public override nfloat GetHeightForRow(UITableView tableView, Foundation.NSIndexPath indexPath)
            {
                return base.GetHeightForRow(tableView, indexPath);
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return ((this.controller != null &&
                    this.controller.View != null &&
                    this.controller.View.Rows != null) ?
                    this.controller.View.Rows.Count :
                    0
                );
            }

            public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
            {
                var cell = (MenuTableViewCell)tableView.DequeueReusableCell(new NSString(MenuTableViewCell.Key), indexPath);

                if (this.controller != null &&
                    this.controller.View != null &&
                    this.controller.View.Rows.Count > indexPath.Row)
                {
                    cell.UpdateCell(this.controller.View.Rows[indexPath.Row]);
                }

                return cell;
            }
        }

        private class MenuTableViewCell : UITableViewCell
        {
            public const string Key = "MenuTableViewCell";

            public MenuTableViewCell(IntPtr handle)
                : base(handle)
            {
            }

            public void UpdateCell(MenuView.MenuTableRow row)
            {
            }

            public override void LayoutSubviews()
            {
                base.LayoutSubviews();
            }
        }
    }
}
