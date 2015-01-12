// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System;
using System.CodeDom.Compiler;

namespace FlowPilots.Workshop.Toodoos.Touch
{
	[Register ("FlowPilots_Workshop_Toodoos_TouchViewController")]
	partial class TodoListTableViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView TodoList { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TodoList != null) {
				TodoList.Dispose ();
				TodoList = null;
			}
		}
	}
}
