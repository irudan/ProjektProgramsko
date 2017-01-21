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
			filter.Name = "Images";
			filter.AddPattern("*.jpg");
			filechooserbutton1.AddFilter(filter);
		}

		protected void spremiFilm(object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "" || filechooserbutton1.Filename == null)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

					d.Run();
					d.Destroy();
					return;
				}
			}

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

			f.SlikaPath = "C:\\temp\\Images\\" + slika;

			spremiSliku(f.SlikaPath);

			//D:\Downloads\AeKQcUf.jpg
			BPFilm.Spremi(f);

			foreach (var i in polje)
			{
				entry = (Entry)i;
				entry.Text = "";
			}
		}

		protected void spremiSliku(string slika)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy " + filechooserbutton1.Filename + " C:\\temp\\Images";
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
