using System;
namespace ProjektProgramsko
{
	public partial class WindowDodavanjeAutora : Gtk.Window
	{
		public WindowDodavanjeAutora() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			buttonSpremi.Clicked += spremiAutora;
		}

		protected void spremiAutora(object sender, EventArgs a)
		{
			Autor temp = new Autor();

			temp.Ime = entryIme.Text;
			temp.Prezime = entryPrezime.Text;

			BPAutor.Spremi(temp);

			this.Destroy();
		}
	}
}
