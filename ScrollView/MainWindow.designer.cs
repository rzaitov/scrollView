// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ScrollView
{
	[Register ("MainWindow")]
	partial class MainWindow
	{
		[Outlet]
		AppKit.NSButton Btn { get; set; }

		[Outlet]
		AppKit.NSScrollView Scroll { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Btn != null) {
				Btn.Dispose ();
				Btn = null;
			}

			if (Scroll != null) {
				Scroll.Dispose ();
				Scroll = null;
			}
		}
	}
}
