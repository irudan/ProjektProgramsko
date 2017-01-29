using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetKnjiga : Gtk.Bin
	{
		public KnjigaNodeStore knjigaPresenter = new KnjigaNodeStore();
		public Knjiga pok;

		public WidgetKnjiga(Knjiga k)
		{
			this.Build();

			pok = k;

			buttonKupi.Clicked += kupi;
			buttonPregledaj.Clicked += pregledaj;
			buttonPreuzmi.Clicked += preuzmi;

			labelNaslov.LabelProp = k.Naziv;
			labelOpis.LabelProp = k.Opis;
			labelBrojStranica.LabelProp = k.BrojStranica.ToString();
			labelCijena.LabelProp = k.Cijena + " kn";
			labelNakladnik.LabelProp = k.Nakladnik;
			labelJezik.LabelProp = k.Jezik;
			labelTagovi.LabelProp = k.Tagovi;

			List<Autor> listaAutora = BPAutor.DohvatiAutore(k.IdK);

			foreach (var i in listaAutora)
			{
				labelAutori.LabelProp += i.Ime + " " + i.Prezime + ", ";
			}

			if (listaAutora.Capacity != 0)
				labelAutori.LabelProp = labelAutori.LabelProp.Remove(labelAutori.LabelProp.Length - 2);

			var buffer = System.IO.File.ReadAllBytes(k.SlikaPath);
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

		protected void kupi(object sender, EventArgs a)
		{
			var windowKupovina = new WindowKupi(pok.Id, pok.Cijena);

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
			var windowPregledaj = new WindowPregledaj(pok.PdfPath, pok.Id, pok.IdK);
		}

		protected void preuzmi(object sender, EventArgs e)
		{
			var windowPreuzmi = new WindowPreuzmi(pok.PdfPath);
		}
	}
}
