using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetFilm : Gtk.Bin
	{
		public Film pok;

		public WidgetFilm(Film f)
		{
			this.Build();

			pok = f;

			labelNaslov.LabelProp = f.Naziv;
			labelOpis.LabelProp = f.Opis;
			labelRedatelj.LabelProp = f.Redatelj;
			labelGodina.LabelProp = f.Godina.ToString();
			labelTrajanje.LabelProp = f.Trajanje.ToString() + " min";
			labelCijena.LabelProp = f.Cijena.ToString() + " kn";
			labelTagovi.LabelProp = f.Tagovi;

			var buffer = System.IO.File.ReadAllBytes(f.SlikaPath);
			var pixbuf = new Gdk.Pixbuf(buffer);
			image1.Pixbuf = pixbuf;

			buttonKupi.Clicked += kupi;
			//buttonPreuzmi.Clicked += preuzmi;

			provjeraKorisnika();
		}

		protected void provjeraKorisnika()
		{
			if (MyGlobals.trenutni.Id == -1)
			{
				buttonPregledaj.Sensitive = false;
				buttonPreuzmi.Sensitive = false;
				buttonKupi.Sensitive = false;
			}
			else
			{
				List<long> listaNaplata = BPNaplata.DohvatiSve(MyGlobals.trenutni.Id, pok.Id);

				if (listaNaplata.Capacity == 0)
				{
					buttonPregledaj.Sensitive = false;
					buttonPreuzmi.Sensitive = false;
				}
				else
				{
					buttonKupi.Sensitive = false;
				}
			}
		}

		protected void kupi(object sender, EventArgs e)
		{
			var windowKupovina = new WindowKupi(pok.Id, pok.Cijena);
		}

		/*protected void preuzmi(object sender, EventArgs e)
		{
			var windowPreuzmi = new WindowPreuzmi();
		}*/
	}
}
