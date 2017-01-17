using System;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowUredivanjeCasopis : Gtk.Window
	{
		public Casopis c;

		public WindowUredivanjeCasopis(Casopis arg) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			c = arg;

			entryNaziv.Text = c.Naziv;
			entryOpis.Text = c.Opis;
			entryTagovi.Text = c.Tagovi;

			buttonSpremi.Clicked += spremiCasopis;
			buttonOdustani.Clicked += odustani;
		}

		protected void spremiCasopis(object sender, EventArgs a)
		{
			if (entryNaziv.Text == "" || entryOpis.Text == "" || entryTagovi.Text == "")
			{

				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			c.Naziv = entryNaziv.Text;
			c.Opis = entryOpis.Text;
			c.Tagovi = entryTagovi.Text;

			BPCasopis.Uredi(c);

			this.Destroy();
		}

		protected void odustani(object sender, EventArgs a)
		{
			this.Destroy();
		}
	}
}
