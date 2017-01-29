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
			filechooserbuttonSlika.AddFilter(filter);

			/*FileFilter filterPdf = new FileFilter();
			filterPdf.Name = "Pdf Files";
			filterPdf.AddPattern("*.pdf");
			filechooserbuttonPdf.AddFilter(filterPdf);*/
		}

		protected void spremiFilm(object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "" || filechooserbuttonSlika.Filename == null || filechooserbuttonVideo.Filename == null)
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

			string slika = filechooserbuttonSlika.Filename;
			string video = filechooserbuttonVideo.Filename;

			for (int i = slika.Length - 1; i != 0; i--)
			{
				if (slika[i] == '\\')
				{
					slika = slika.Remove(0, i + 1);
					break;
				}
			}

			for (int i = video.Length - 1; i != 0; i--)
			{
				if (video[i] == '\\')
				{
					video = video.Remove(0, i + 1);
					break;
				}
			}

			f.SlikaPath = "C:\\temp\\Images\\" + slika;
			f.VideoPath = "C:\\temp\\Video\\" + video;


			spremiSliku();
			spremiVideo();

			//D:\Downloads\AeKQcUf.jpg
			BPFilm.Spremi(f);

			foreach (var i in polje)
			{
				entry = (Entry)i;
				entry.Text = "";
			}
		}

		protected void spremiSliku()
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy \"" + filechooserbuttonSlika.Filename + "\" C:\\temp\\Images";
			process.StartInfo = startInfo;
			process.Start();
		}

		protected void spremiVideo()
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy \"" + filechooserbuttonVideo.Filename + "\" C:\\temp\\Video";
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
