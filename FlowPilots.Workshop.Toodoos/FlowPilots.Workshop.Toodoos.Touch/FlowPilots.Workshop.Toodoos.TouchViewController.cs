using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FlowPilots.Workshop.Toodoos.Core;
using System.Linq;

namespace FlowPilots.Workshop.Toodoos.Touch
{
    public partial class FlowPilots_Workshop_Toodoos_TouchViewController : UIViewController
    {
        public FlowPilots_Workshop_Toodoos_TouchViewController(IntPtr handle)
            : base(handle)
        {
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TodoList.Source = new TodoSource();
        }

        #endregion

        public class TodoSource : UITableViewSource
        {
            public override int RowsInSection(UITableView tableview, int section)
            {
                return DataManager.GetAllTodos().Count;
            }

            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell("TodoCell");

                var label = cell.ViewWithTag(1) as UILabel;
                label.Text = DataManager.GetAllTodos().ElementAt(indexPath.Row).Name;

                return cell;
            }
        }
    }
}

