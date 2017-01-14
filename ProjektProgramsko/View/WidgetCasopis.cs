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

			//string temp = ic.Datum.ToString();
			if (ic != null)
			{
				labelDatum.LabelProp = ic.Datum.ToString().Insert(2, "/");
				labelBrojIzdanja.LabelProp = ic.BrojIzdanja.ToString();
				labelCijena.LabelProp = ic.Cijena.ToString();
			}
			/*var buffer = System.IO.File.ReadAllBytes(c.SlikaPath);
			var pixbuf = new Gdk.Pixbuf(buffer);
			image1.Pixbuf = pixbuf;*/
		}
	}
}
