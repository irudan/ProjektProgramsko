using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetDodavanjeFilm : Gtk.Bin
	{
		public WidgetDodavanjeFilm()
		{
			this.Build();

			buttonSpremi.Clicked += spremiFilm;

			FileFilter filter = new FileFilter();
			filter.AddPattern("*.jpg");
			filechooserbutton1.AddFilter(filter);
		}

		protected void spremiFilm(object sender, EventArgs a)
		{
			Film f = new Film();

			f.Naziv = entryNaziv.Text;
			f.Opis = entryOpis.Text;
			f.Redatelj = entryRedatelj.Text;
			f.Godina = int.Parse(entryGodina.Text);
			f.Trajanje = int.Parse(entryTrajanje.Text);
			f.Cijena = int.Parse(entryCijena.Text);
			f.Tagovi = entryTagovi.Text;

			string slika = filechooserbutton1.Filename;

			for (int i = slika.Length - 1; i != 0; i--)
			{
				if (slika[i] == '\\')
				{
					slika = slika.Remove(0, i + 1);
					break;
				}
			}

			f.SlikaPath = "Images/" + slika;

			spremiSliku(f.SlikaPath);

			//D:\Downloads\AeKQcUf.jpg
			BPFilm.Spremi(f);
		}

		protected void spremiSliku(string slika)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy " + filechooserbutton1.Filename + " C:\\Users\\Mateo\\Documents\\GitHub\\ProjektProgramsko\\ProjektProgramsko\\bin\\Debug\\Images";
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
