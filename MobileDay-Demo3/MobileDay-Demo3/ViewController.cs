using System;

using UIKit;
using Foundation;

namespace MobileDayDemo3
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			btnNotifica.TouchUpInside += delegate 
			{
				var notificacion = new UILocalNotification();
				notificacion.FireDate = NSDate.FromTimeIntervalSinceNow(15);
				notificacion.AlertAction = "Notificaciones";
				notificacion.AlertBody = "Alerta Alerta Alerta";
				UIApplication.SharedApplication.ScheduleLocalNotification(notificacion);
			};

		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

