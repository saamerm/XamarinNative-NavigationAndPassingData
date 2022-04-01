// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XamarinNativeNavigation.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton FirstNavigatioButton { get; set; }

		[Outlet]
		UIKit.UILabel HelloLabel { get; set; }

		[Outlet]
		UIKit.UIButton SecondNavigatioButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (SecondNavigatioButton != null) {
				SecondNavigatioButton.Dispose ();
				SecondNavigatioButton = null;
			}

			if (FirstNavigatioButton != null) {
				FirstNavigatioButton.Dispose ();
				FirstNavigatioButton = null;
			}

			if (HelloLabel != null) {
				HelloLabel.Dispose ();
				HelloLabel = null;
			}
		}
	}
}
