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
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView DescriptionView { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel NameLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISwitch TodoStatus { get; set; }

		[Action ("Dismiss:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Dismiss (UIButton sender);

		[Action ("Toggle:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void Toggle (UISwitch sender);

		void ReleaseDesignerOutlets ()
		{
			if (DescriptionView != null) {
				DescriptionView.Dispose ();
				DescriptionView = null;
			}
			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}
			if (TodoStatus != null) {
				TodoStatus.Dispose ();
				TodoStatus = null;
			}
		}
	}
}
