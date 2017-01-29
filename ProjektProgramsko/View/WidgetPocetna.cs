using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetPocetna : Gtk.Bin
	{
		public WidgetPocetna()
		{
			this.Build();

			List<Knjiga> listaK = BPKnjiga.DohvatiSort("broj_prodanih");
			List<Film> listaF = BPFilm.DohvatiSort("broj_prodanih");
			List<IzdanjeCasopis> listaI = BPIzdanjeCasopis.DohvatiSort("izdanje_casopis.broj_prodanih");

			//Knjige
			var buffer = System.IO.File.ReadAllBytes(listaK[0].SlikaPath);
			var pixbuf = new Gdk.Pixbuf(buffer);
			image1.Pixbuf = pixbuf;
			label1.Text = listaK[0].Naziv;

			buffer = System.IO.File.ReadAllBytes(listaK[1].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image2.Pixbuf = pixbuf;
			label2.Text = listaK[1].Naziv;

			buffer = System.IO.File.ReadAllBytes(listaK[2].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image3.Pixbuf = pixbuf;
			label3.Text = listaK[2].Naziv;

			buffer = System.IO.File.ReadAllBytes(listaK[3].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image4.Pixbuf = pixbuf;
			label4.Text = listaK[3].Naziv;

			//Casopisi
			Casopis c = BPCasopis.DohvatiCasopis(listaI[0].IdC);
			buffer = System.IO.File.ReadAllBytes(listaI[0].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image5.Pixbuf = pixbuf;
			label5.Text = c.Naziv + " Br." + listaI[0].BrojIzdanja;

			c = BPCasopis.DohvatiCasopis(listaI[1].IdC);
			buffer = System.IO.File.ReadAllBytes(listaI[1].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image6.Pixbuf = pixbuf;
			label6.Text = c.Naziv + " Br." + listaI[1].BrojIzdanja;

			c = BPCasopis.DohvatiCasopis(listaI[2].IdC);
			buffer = System.IO.File.ReadAllBytes(listaI[2].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image7.Pixbuf = pixbuf;
			label7.Text = c.Naziv + " Br." + listaI[2].BrojIzdanja;

			c = BPCasopis.DohvatiCasopis(listaI[3].IdC);
			buffer = System.IO.File.ReadAllBytes(listaI[3].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image8.Pixbuf = pixbuf;
			label8.Text = c.Naziv + " Br." + listaI[3].BrojIzdanja;

			//Filmovi
			buffer = System.IO.File.ReadAllBytes(listaF[0].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image9.Pixbuf = pixbuf;
			label9.Text = listaF[0].Naziv;

			buffer = System.IO.File.ReadAllBytes(listaF[1].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image10.Pixbuf = pixbuf;
			label10.Text = listaF[1].Naziv;

			buffer = System.IO.File.ReadAllBytes(listaF[2].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image11.Pixbuf = pixbuf;
			label11.Text = listaF[2].Naziv;

			buffer = System.IO.File.ReadAllBytes(listaF[3].SlikaPath);
			pixbuf = new Gdk.Pixbuf(buffer);
			image12.Pixbuf = pixbuf;
			label12.Text = listaF[3].Naziv;
		}
	}
}
