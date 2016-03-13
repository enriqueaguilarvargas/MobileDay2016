using System;

using WatchKit;
using Foundation;
using MapKit;
using CoreLocation;
using UIKit;
using CoreGraphics;

namespace MobileDayDemo2.WatchKitExtension
{
	public partial class InterfaceController : WKInterfaceController
	{
		MKCoordinateSpan Altura;
		CLLocationCoordinate2D Centrar;
		MKCoordinateRegion Region;
		double x,y;
		public InterfaceController (IntPtr handle) : base (handle)
		{
		}
		public override void Awake (NSObject context)
		{
			base.Awake (context);
		}
		public override void WillActivate ()
		{
		}
		public override void DidDeactivate ()
		{
		}
		partial void UbicaClick ()
		{
			x = 21.152711;
			y = -101.711731;
			Centrar = new CLLocationCoordinate2D(x,y);
			Altura = new MKCoordinateSpan(.005, .005);
			Region = new MKCoordinateRegion(Centrar, Altura);
			Mapa.AddAnnotation(Centrar, WKInterfaceMapPinColor.Green);
			Mapa.SetRegion(Region);
			var Imagen = UIImage.FromFile("salle.jpg");
			Mapa.AddAnnotation(Centrar, Imagen, CGPoint.Empty);
		}
		partial void btnZoomInClick ()
		{
			var span = new MKCoordinateSpan(Altura.LatitudeDelta
				* 0.5f, Altura.LongitudeDelta * 0.5f);
			var region = new MKCoordinateRegion(Region.Center, span);
			Altura = span;
			Mapa.SetRegion(region);
		}

		partial void btnZoomOutClick ()
		{
			var span = new MKCoordinateSpan(Altura.LatitudeDelta
				* 2, Altura.LongitudeDelta * 2);
			var region = new MKCoordinateRegion(Region.Center, span);
			Altura = span;
			Mapa.SetRegion(region);

		}


	}
}

