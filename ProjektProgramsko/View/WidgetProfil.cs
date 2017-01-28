using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetProfil : Gtk.Bin
	{
		public WidgetProfil()
		{
			this.Build();

			buttonSpremi.Clicked += spremiPromjene;

			entryIme.Text = MyGlobals.trenutni.Ime;
			entryPrezime.Text = MyGlobals.trenutni.Prezime;
			entryUsername.Text = MyGlobals.trenutni.Username;
			entryMail.Text = MyGlobals.trenutni.Mail;
		}

		protected void spremiPromjene(object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
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

			List<Korisnik> listaKorisnika = BPKorisnik.DohvatiSve();

			if (entryStariPass.Text != MyGlobals.trenutni.Password)
			{
				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Stara lozinka neispravna!");

				d.Run();
				d.Destroy();
				return;
			}

			/*if (entryStariPass.Text != entryNoviPass.Text)
			{
				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Lozinke se ne podudaraju!");

				d.Run();
				d.Destroy();
				return;
			}*/

			foreach (var i in listaKorisnika)
			{
				if (entryUsername.Text == i.Username && i.Username != MyGlobals.trenutni.Username)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Korisnicko ime je zauzeto!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
			Match match = regex.Match(entryMail.Text);

			if (!match.Success)
			{
				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Email adresa nije u valjanom formatu!");

				d.Run();
				d.Destroy();
				return;
			}

			Korisnik temp = MyGlobals.trenutni;

			temp.Ime = entryIme.Text;
			temp.Prezime = entryPrezime.Text;
			temp.Username = entryUsername.Text;
			temp.Password = entryNoviPass.Text;
			temp.Mail = entryMail.Text;

			MyGlobals.trenutni = temp;

			BPKorisnik.Uredi(temp);

			Dialog spremljeno = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Info, ButtonsType.Ok, "Uređivanje uspješno!");

			spremljeno.Run();
			spremljeno.Destroy();

			entryStariPass.Text = "";
			entryNoviPass.Text = "";

			return;
		}
	}
}
