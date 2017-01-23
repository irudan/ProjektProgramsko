using System;
using Gtk;
using System.Collections.Generic;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetPrijava : Gtk.Bin
	{
		public WidgetPrijava()
		{
			this.Build();

			buttonPotvrdi.Clicked += potvrdi;
			buttonOdustani.Clicked += odustani;
		}

		protected void potvrdi(object sender, EventArgs a)
		{
			List<Korisnik> listaKorisnika = BPKorisnik.DohvatiSve();

			foreach (var i in listaKorisnika)
			{
				if (entryUsername.Text == i.Username && entryPassword.Text == i.Password)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Prijava uspješna");

					d.Run();
					d.Destroy();

					MyGlobals.trenutni = i;

					this.Toplevel.Destroy();
					return;
				}
			}

			foreach (var i in listaKorisnika)
			{
				if (entryUsername.Text != i.Username || entryPassword.Text != i.Password)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Neispravno korisničko ime ili lozinka");

					d.Run();
					d.Destroy();
					return;
				}
				break;
			}

		}

		protected void odustani(object sender, EventArgs a)
		{
			Toplevel.Destroy();
		}

		public Button getReg()
		{
			return buttonRegistrirajse;
		}
	}
}
