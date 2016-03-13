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

namespace MobileDayDemo4.WatchKitExtension
{
	[Register ("InterfaceController")]
	partial class InterfaceController
	{
		[Outlet]
		WatchKit.WKInterfaceButton btnConsulta { get; set; }

		[Outlet]
		WatchKit.WKInterfaceLabel lblDomicilio { get; set; }

		[Outlet]
		WatchKit.WKInterfaceLabel lblEmpresa { get; set; }

		[Outlet]
		WatchKit.WKInterfaceLabel lblNombre { get; set; }

		[Outlet]
		WatchKit.WKInterfaceLabel lblRFC { get; set; }

		[Outlet]
		WatchKit.WKInterfaceLabel lblSaldo { get; set; }

		[Action ("EventoConsulta")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void EventoConsulta ();

		void ReleaseDesignerOutlets ()
		{
			if (btnConsulta != null) {
				btnConsulta.Dispose ();
				btnConsulta = null;
			}
			if (lblDomicilio != null) {
				lblDomicilio.Dispose ();
				lblDomicilio = null;
			}
			if (lblEmpresa != null) {
				lblEmpresa.Dispose ();
				lblEmpresa = null;
			}
			if (lblNombre != null) {
				lblNombre.Dispose ();
				lblNombre = null;
			}
			if (lblRFC != null) {
				lblRFC.Dispose ();
				lblRFC = null;
			}
			if (lblSaldo != null) {
				lblSaldo.Dispose ();
				lblSaldo = null;
			}
		}
	}
}
