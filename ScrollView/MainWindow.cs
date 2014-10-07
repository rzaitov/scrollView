using System;

using Foundation;
using AppKit;

namespace ScrollView
{
	public partial class MainWindow : NSWindow
	{
		NSView container;
		NSButton btn1, btn2, btn3;

		public MainWindow (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindow (NSCoder coder) : base (coder)
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			container = new NSView ();

			btn1 = new NSButton ();
			btn1.Title = "First Button";
			btn1.SizeToFit ();

			btn2 = new NSButton ();
			btn2.Title = "Second Button";
			btn2.SizeToFit ();

			btn3 = new NSButton ();
			btn3.Title = "Third Button";
			btn3.SizeToFit ();

			var rect = btn2.Frame;
			rect.X += btn1.Frame.Right + 10;
			btn2.Frame = rect;

			rect = btn3.Frame;
			rect.X += btn2.Frame.Right + 10;
			btn3.Frame = rect;

			container.AddSubview (btn1);
			container.AddSubview (btn2);
			container.AddSubview (btn3);
			container.Frame = new CoreGraphics.CGRect (0, 0, btn3.Frame.Right, btn3.Frame.Bottom);

			Scroll.DocumentView = container;
			Scroll.HasHorizontalScroller = true;
		}
	}
}
