using System;

using WatchKit;
using Foundation;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.Generic;
using System.Threading.Tasks;
using UIKit;

namespace MobileDayDemo4.WatchKitExtension
{
	public partial class InterfaceController : WKInterfaceController
	{
		public InterfaceController (IntPtr handle) : base (handle)
		{
		}
		public List<Clientes> clientes;
		public static MobileServiceClient MobileService = 
			new MobileServiceClient(
				"Servicio Móvil en Azure",
				"Token de Acceso a Azure"
			);
		public async Task Authenticate(UIViewController view)
		{
			user = await MobileService.LoginAsync (view, 
				MobileServiceAuthenticationProvider.MicrosoftAccount);
		}
		private MobileServiceUser user;
		public async Task LoginAndGetData(UIViewController view)
		{
			await Authenticate (view);
		}
		async partial void EventoConsulta ()
		{
			clientes = await MobileService.GetTable<Clientes>().
				Select(cx=>cx).Where(x => x.Empresa == 
					"De La Salle Bajio").ToListAsync();
			foreach(var fila in clientes)
			{
				lblNombre.SetText(fila.Saldo.ToString());
				lblDomicilio.SetText(fila.Saldo.ToString());
				lblEmpresa.SetText(fila.Saldo.ToString());
				lblRFC.SetText(fila.Saldo.ToString());
				lblSaldo.SetText(fila.Saldo.ToString());
			}
		}


		public override void Awake (NSObject context)
		{
			base.Awake (context);

			// Configure interface objects here.
			Console.WriteLine ("{0} awake with context", this);
		}

		public override void WillActivate ()
		{
			// This method is called when the watch view controller is about to be visible to the user.
			Console.WriteLine ("{0} will activate", this);
		}

		public override void DidDeactivate ()
		{
			// This method is called when the watch view controller is no longer visible to the user.
			Console.WriteLine ("{0} did deactivate", this);
		}

	}
}

