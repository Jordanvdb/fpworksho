using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FlowPilots.Workshop.Toodoos.Core;
using System.Linq;

namespace FlowPilots.Workshop.Toodoos.Touch
{
    public partial class TodoListTableViewController : UIViewController
    {
        public TodoListTableViewController(IntPtr handle)
            : base(handle)
        {
        }

        #region View lifecycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            TodoList.Source = new TodoSource(this);
        }

        #endregion

        public class TodoSource : UITableViewSource
        {
            TodoListTableViewController controller;

            public TodoSource (TodoListTableViewController controller)
            {
                this.controller = controller;
            }

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

            public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
            {
                var detailViewController = UIStoryboard.FromName("MainStoryboard", null).InstantiateViewController("DetailViewController") as DetailViewController;

                var currentTodo = DataManager.GetAllTodos().ElementAt(indexPath.Row);

                detailViewController.CurrentTodo = currentTodo;

                controller.PresentViewController(detailViewController, true, null);

            }
        }
    }
}

