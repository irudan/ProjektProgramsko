using System;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetCasopis : Gtk.Bin
	{
		public WidgetCasopis(Casopis c, IzdanjeCasopis ic)
		{
			this.Build();

			labelNaslov.LabelProp = c.Naziv;
			labelOpis.LabelProp = c.Opis;

			labelDatum.LabelProp = ic.Datum.ToString().Insert(2, "/");
			labelBrojIzdanja.LabelProp = ic.BrojIzdanja.ToString();
			labelCijena.LabelProp = ic.Cijena.ToString();
			labelTagovi.LabelProp = c.Tagovi;
		
			var buffer = System.IO.File.ReadAllBytes(ic.SlikaPath);
			var pixbuf = new Gdk.Pixbuf(buffer);
			image1.Pixbuf = pixbuf;

			buttonKupi.Clicked += Kupi;
		}

		protected void Kupi(object sender, EventArgs e)
		{
			var windowKupovina = new WindowKupovina();
		}
	}
}
