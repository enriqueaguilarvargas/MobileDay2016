using System;

using WatchKit;
using Foundation;
using System.Net;
using System.IO;
using UIKit;

namespace MobileDayDemo1.WatchKitExtension
{
	public partial class InterfaceController : WKInterfaceController
	{
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
		partial void DescargarClick ()
		{
			WebClient client = new WebClient();
			byte[] imageData = client.DownloadData
				("https://dl.dropboxusercontent.com/u/95408124/foto1.jpg");
			string documentspath = System.Environment.GetFolderPath
				(System.Environment.SpecialFolder.Personal);
			string localfilename = "foto1.jpg";
			string localpath = Path.Combine(documentspath, localfilename);
			File.WriteAllBytes(localpath, imageData);
			var image = UIImage.FromFile(localpath);
			var png = image.AsPNG();
			Imagen.SetImage(png);
		}
		string texto = "";

		partial void CapturaClick ()
		{
			var suggers = new string[]{"De La Salle Bajio", "Tec de Lagos", "UNIVA", "IPN", "UNAM"};
			PresentTextInputController (suggers, WatchKit.WKTextInputMode.AllowEmoji, (result)=>
				{
					if (result != null && result.Count > 0)
					{
						texto = result.GetItem<NSObject>(0).ToString();
						lblTexto.SetText(lblTexto.ToString() + texto);
					}
				});
			PresentTextInputController (new string[0], WatchKit.WKTextInputMode.Plain, (result)=>
				{
					if (result != null && result.Count > 0)
					{
						texto = texto + result.GetItem<NSObject>(0).ToString();
						lblTexto.SetText(texto);
					}
				});
		}
		}
	}


