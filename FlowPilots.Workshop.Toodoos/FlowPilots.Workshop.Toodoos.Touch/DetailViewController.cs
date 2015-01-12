using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;
using FlowPilots.Workshop.Toodoos.Core;

namespace FlowPilots.Workshop.Toodoos.Touch
{
	partial class DetailViewController : UIViewController
	{
        public Todo CurrentTodo { get; set; }

		public DetailViewController (IntPtr handle) : base (handle)
		{
		}

        partial void Dismiss(UIButton sender)
        {
            DismissViewController (true, null);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            NameLabel.Text = CurrentTodo.Name;
            DescriptionView.Text = CurrentTodo.Description;
            TodoStatus.On = CurrentTodo.Done;
        }

        partial void Toggle(UISwitch sender)
        {
            CurrentTodo.Done = !CurrentTodo.Done;
        }
	}
}
