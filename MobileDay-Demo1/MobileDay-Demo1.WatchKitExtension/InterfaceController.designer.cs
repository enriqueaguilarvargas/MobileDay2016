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

namespace MobileDayDemo1.WatchKitExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceButton btnDescargar { get; set; }

		[Outlet]
		WatchKit.WKInterfaceImage Imagen { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton btnCapturar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceButton btnInput { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		WatchKit.WKInterfaceLabel lblTexto { get; set; }

		[Action ("CapturaClick")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void CapturaClick ();

		[Action ("DescargarClick")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void DescargarClick ();

		void ReleaseDesignerOutlets ()
		{
			if (btnCapturar != null) {
				btnCapturar.Dispose ();
				btnCapturar = null;
			}
			if (btnDescargar != null) {
				btnDescargar.Dispose ();
				btnDescargar = null;
			}
			if (btnInput != null) {
				btnInput.Dispose ();
				btnInput = null;
			}
			if (Imagen != null) {
				Imagen.Dispose ();
				Imagen = null;
			}
			if (lblTexto != null) {
				lblTexto.Dispose ();
				lblTexto = null;
			}
		}
	}
}
