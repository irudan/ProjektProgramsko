using System;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowUredivanjeAutora : Gtk.Window
	{
		public Autor at;

		public WindowUredivanjeAutora(Autor arg) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			at = arg;

			entryIme.Text = at.Ime;
			entryPrezime.Text = at.Prezime;

			buttonSpremi.Clicked += spremiAutor;
			buttonOdustani.Clicked += odustani;
		}

		protected void spremiAutor(object sender, EventArgs a)
		{
			if (entryIme.Text == "" || entryPrezime.Text == "")
			{

				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			at.Ime = entryIme.Text;
			at.Prezime = entryPrezime.Text;

			BPAutor.Uredi(at);

			this.Destroy();
		}

		protected void odustani(object sender, EventArgs a)
		{
			this.Destroy();
		}
	}
}
