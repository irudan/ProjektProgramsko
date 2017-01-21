using System;
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

			buttonPregledaj.Clicked += pregledaj;
			buttonKupi.Clicked += kupi;

			labelNaslov.LabelProp = c.Naziv;
			labelOpis.LabelProp = c.Opis;

			labelDatum.LabelProp = ic.Datum.ToString().Insert(2, "/");
			labelBrojIzdanja.LabelProp = ic.BrojIzdanja.ToString();
			labelCijena.LabelProp = ic.Cijena.ToString();
			labelTagovi.LabelProp = c.Tagovi;
		
			var buffer = System.IO.File.ReadAllBytes(ic.SlikaPath);
			var pixbuf = new Gdk.Pixbuf(buffer);
			image1.Pixbuf = pixbuf;

		}

		protected void kupi(object sender, EventArgs e)
		{
			var windowKupovina = new WindowKupovina();
		}

		protected void pregledaj(object sender, EventArgs a)
		{
			var windowPregledaj = new WindowPregledaj(pokI.PdfPath, pokC.Id, pokI.Id);
		}
	}
}
