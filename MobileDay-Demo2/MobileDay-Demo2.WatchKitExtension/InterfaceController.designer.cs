// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MobileDayDemo2.WatchKitExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceButton btnUbicar { get; set; }

		[Outlet]
		WatchKit.WKInterfaceMap Mapa { get; set; }

		[Outlet]
		WatchKit.WKInterfaceButton Zoom1 { get; set; }

		[Outlet]
		WatchKit.WKInterfaceButton Zoom2 { get; set; }

		[Action ("btnZoomInClick")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnZoomInClick ();

		[Action ("btnZoomOutClick")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnZoomOutClick ();

		[Action ("UbicaClick")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void UbicaClick ();

		void ReleaseDesignerOutlets ()
		{
			if (btnUbicar != null) {
				btnUbicar.Dispose ();
				btnUbicar = null;
			}
			if (Mapa != null) {
				Mapa.Dispose ();
				Mapa = null;
			}
			if (Zoom1 != null) {
				Zoom1.Dispose ();
				Zoom1 = null;
			}
			if (Zoom2 != null) {
				Zoom2.Dispose ();
				Zoom2 = null;
			}
		}
	}
}
