using System;
using System.Collections.Generic;
using Gtk;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetDodavanjeKnjiga : Gtk.Bin
	{
		public List<Autor> listaAutora = new List<Autor>();

		public WidgetDodavanjeKnjiga()
		{
			this.Build();

			buttonSpremi.Clicked += spremiKnjiga;
			buttonPregled.Clicked += pregledAutora;
			buttonDodaj.Clicked += spremiAutora;
		}

		protected void spremiKnjiga (object sender, EventArgs a)
		{
			Knjiga k = new Knjiga(entryJezik.Text, entryTagovi.Text, entryNaziv.Text, entryOpis.Text);

			BPKnjiga.Spremi(k, listaAutora);
		}

		protected void pregledAutora(object sender, EventArgs a)
		{
			var windowAutori = new WindowPregledAutora(ref listaAutora);
		}

		protected void spremiAutora(object sender, EventArgs a)
		{
			var windowAutori = new WindowDodavanjeAutora();
		}
	}
}
