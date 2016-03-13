// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MobileDayDemo3
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton btnNotifica { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (btnNotifica != null) {
				btnNotifica.Dispose ();
				btnNotifica = null;
			}
		}
	}
}
