using System;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetFilm : Gtk.Bin
	{
		public WidgetFilm(Film f)
		{
			this.Build();

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
		}

		protected void Kupi(object sender, EventArgs e)
		{
			var windowKupovina = new WindowKupovina();
		}
	}
}
