using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetCasopis : Gtk.Bin
	{
		public Casopis pokC;
		public IzdanjeCasopis pokI;

		public WidgetCasopis(Casopis c, IzdanjeCasopis ic)
		{
			this.Build();

			pokC = c;
			pokI = ic;

			buttonKupi.Clicked += kupi;
			buttonPregledaj.Clicked += pregledaj;
			buttonPreuzmi.Clicked += preuzmi;

			labelNaslov.LabelProp = c.Naziv;
			labelOpis.LabelProp = c.Opis;

			labelDatum.LabelProp = ic.Datum.ToString().Insert(2, "/");
			labelBrojIzdanja.LabelProp = ic.BrojIzdanja.ToString();
			labelCijena.LabelProp = ic.Cijena.ToString();
			labelTagovi.LabelProp = c.Tagovi;
		
			var buffer = System.IO.File.ReadAllBytes(ic.SlikaPath);
			var pixbuf = new Gdk.Pixbuf(buffer);
			image1.Pixbuf = pixbuf;

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
				List<long> listaNaplata = BPNaplata.DohvatiSve(MyGlobals.trenutni.Id, pokI.Id);

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
			var windowKupovina = new WindowKupi(pokI.Id, pokI.Cijena);

			windowKupovina.Destroyed += updateButton;
		}

		protected void updateButton(object sender, EventArgs a)
		{
			buttonKupi.Sensitive = false;
			buttonPregledaj.Sensitive = true;
			buttonPreuzmi.Sensitive = true;
		}

		protected void pregledaj(object sender, EventArgs a)
		{
			var windowPregledaj = new WindowPregledaj(pokI.PdfPath, pokC.Id, pokI.Id);
		}

		protected void preuzmi(object sender, EventArgs e)
		{
			var windowPreuzmi = new WindowPreuzmi(pokI.PdfPath);
		}
	}
}
