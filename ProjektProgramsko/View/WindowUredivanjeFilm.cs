using System;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowUredivanjeFilm : Gtk.Window
	{
		public Film f;

		public WindowUredivanjeFilm(Film arg) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			f = arg;

			entryNaziv.Text = f.Naziv;
			entryOpis.Text = f.Opis;
			entryRedatelj.Text = f.Redatelj;
			entryGodina.Text = f.Godina.ToString();
			entryTrajanje.Text = f.Trajanje.ToString();
			entryCijena.Text = f.Cijena.ToString();
			entryTagovi.Text = f.Tagovi;

			buttonSpremi.Clicked += spremiFilm;
			buttonOdustani.Clicked += odustani;

			FileFilter filter = new FileFilter();
			filter.Name = "Images";
			filter.AddPattern("*.jpg");
			filechooserbuttonSlika.AddFilter(filter);
		}

		protected void spremiFilm(object sender, EventArgs a)
		{
			if (entryNaziv.Text == "" || entryOpis.Text == "" || entryRedatelj.Text == "" || entryGodina.Text == "" || entryTrajanje.Text == ""
			    || entryCijena.Text == "" || entryTagovi.Text == "")
			{

				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			f.Naziv = entryNaziv.Text;
			f.Opis = entryOpis.Text;
			f.Redatelj = entryRedatelj.Text;
			f.Godina = int.Parse(entryGodina.Text);
			f.Trajanje = int.Parse(entryTrajanje.Text);
			f.Cijena = int.Parse(entryCijena.Text);
			f.Tagovi = entryTagovi.Text;

			if (filechooserbuttonVideo.Filename != null)
			{
				string pdf = filechooserbuttonVideo.Filename;

				for (int i = pdf.Length - 1; i != 0; i--)
				{
					if (pdf[i] == '\\')
					{
						pdf = pdf.Remove(0, i + 1);
						break;
					}
				}

				f.VideoPath = "C:\\temp\\Video\\" + pdf;

				spremiVideo();
			}

			if (filechooserbuttonSlika.Filename != null)
			{
				string slika = filechooserbuttonSlika.Filename;

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
			}

			BPFilm.Uredi(f);

			this.Destroy();
		}

		protected void odustani(object sender, EventArgs a)
		{
			this.Destroy();
		}

		protected void spremiSliku(string slika)
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
