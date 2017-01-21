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

			labelNaslov.LabelProp = k.Naziv;
			labelOpis.LabelProp = k.Opis;
			labelBrojStranica.LabelProp = k.BrojStranica.ToString();
			labelCijena.LabelProp = k.Cijena.ToString() + " kn";
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
		}

		protected void kupi(object sender, EventArgs a)
		{
			var windowKupovina = new WindowKupovina();
		}

		protected void pregledaj(object sender, EventArgs a)
		{
			var windowPregledaj = new WindowPregledaj(pok.PdfPath, pok.Id, pok.IdK);
		}
	}
}
