using System;
using Gtk;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetRegistracija : Gtk.Bin
	{
		public WidgetRegistracija()
		{
			this.Build();

			buttonPotvrdi.Clicked += potvrdi;
		}

		protected void potvrdi(object sender, EventArgs a)
		{
			Widget[] polje = vboxMain.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "")
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			if (entryLozinka.Text != entryPotvrdiLozinku.Text)
			{
				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Lozinke se ne podudaraju!");

				d.Run();
				d.Destroy();
				return;
			}

			List<Korisnik> listaKorisnika = BPKorisnik.DohvatiSve();

			foreach (var i in listaKorisnika)
			{
				if (entryKorisnickoIme.Text == i.Username)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Korisnicko ime je zauzeto!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(entryEmail.Text);

			if (!match.Success)
			{
				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Email adresa nije u valjanom formatu!");

				d.Run();
				d.Destroy();
				return;
			}

			Korisnik k = new Korisnik();

			k.Ime = entryIme.Text;
			k.Prezime = entryPrezime.Text;
			k.Username = entryKorisnickoIme.Text;
			k.Password = entryLozinka.Text;
			k.Mail = entryEmail.Text;

			BPKorisnik.Spremi(k);

			Dialog dTemp = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Registracija gotova, možete se prijaviti!");

			dTemp.Run();
			dTemp.Destroy();

			this.Destroy();
		}

		public Button getNatrag()
		{
			return buttonNatrag;
		}
	}
}
