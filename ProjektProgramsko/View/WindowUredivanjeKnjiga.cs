using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowUredivanjeKnjiga : Gtk.Window
	{
		public List<Autor> listaAutora = new List<Autor>();
		public Knjiga k;

		public WindowUredivanjeKnjiga(Knjiga arg) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			k = arg;

			entryNaziv.Text = k.Naziv;
			entryOpis.Text = k.Opis;
			entryBrojStranica.Text = k.BrojStranica.ToString();
			entryCijena.Text = k.Cijena.ToString();
			entryNakladnik.Text = k.Nakladnik;
			entryJezik.Text = k.Jezik;
			entryTagovi.Text = k.Tagovi;

			buttonSpremi.Clicked += spremiKnjiga;
			buttonOdustani.Clicked += odustani;
			buttonDodaj.Clicked += spremiAutora;
			buttonPregled.Clicked += pregledAutora;

			FileFilter filterSlika = new FileFilter();
			filterSlika.Name = "Images";
			filterSlika.AddPattern("*.jpg");
			filechooserbuttonSlika.AddFilter(filterSlika);

			FileFilter filterPdf = new FileFilter();
			filterPdf.Name = "Pdf Files";
			filterPdf.AddPattern("*.pdf");
			filechooserbuttonPdf.AddFilter(filterPdf);
		}

		protected void spremiKnjiga(object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "")
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			k.Naziv = entryNaziv.Text;
			k.Opis = entryOpis.Text;
			k.BrojStranica = int.Parse(entryBrojStranica.Text);
			k.Cijena = Double.Parse(entryCijena.Text);
			k.Nakladnik = entryNakladnik.Text;
			k.Tagovi = entryTagovi.Text;
			k.Jezik = entryJezik.Text;

			if (filechooserbuttonPdf.Filename != null)
			{
				string pdf = filechooserbuttonPdf.Filename;

				for (int i = pdf.Length - 1; i != 0; i--)
				{
					if (pdf[i] == '\\')
					{
						pdf = pdf.Remove(0, i + 1);
						break;
					}
				}

				k.PdfPath = "C:\\temp\\Pdf\\" + pdf;

				spremiPdf();
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

				k.SlikaPath = "C:\\temp\\Images\\" + slika;

				spremiSliku(k.SlikaPath);
			}

			BPKnjiga.Uredi(k, listaAutora);

			this.Destroy();
		}

		protected void pregledAutora(object sender, EventArgs a)
		{
			var windowAutori = new WindowPregledAutora(ref listaAutora, k.IdK);
		}

		protected void spremiAutora(object sender, EventArgs a)
		{
			var windowAutori = new WindowDodavanjeAutora();
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

		protected void spremiPdf()
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy \"" + filechooserbuttonPdf.Filename + "\" C:\\temp\\Pdf";
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
