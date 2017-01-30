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

			buttonKupi.Clicked += kupi;
			buttonPregledaj.Clicked += pregledaj;

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
				List<Naplata> listaNaplata = BPNaplata.DohvatiSve(MyGlobals.trenutni.Id, pok.Id);

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

			windowKupovina.Destroyed += updateButton;
		}

		protected void pregledaj(object sender, EventArgs e)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C " + pok.VideoPath;
			process.StartInfo = startInfo;
			process.Start();
		}

		protected void updateButton(object sender, EventArgs a)
		{
			buttonKupi.Sensitive = false;
			buttonPregledaj.Sensitive = true;
			buttonPreuzmi.Sensitive = true;
		}
	}
}
