using System;
using System.Collections.Generic;
using Gtk;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetDodavanjeKnjiga : Gtk.Bin
	{
		public List<Autor> listaAutora = new List<Autor>();

		public WidgetDodavanjeKnjiga()
		{
			this.Build();

			buttonSpremi.Clicked += spremiKnjiga;
			buttonPregled.Clicked += pregledAutora;
			buttonDodaj.Clicked += spremiAutora;

			FileFilter filterSlika = new FileFilter();
			filterSlika.Name= "Images";
			filterSlika.AddPattern("*.jpg");
			filechooserbuttonSlika.AddFilter(filterSlika);

			FileFilter filterPdf = new FileFilter();
			filterPdf.Name = "Pdf Files";
			filterPdf.AddPattern("*.pdf");
			filechooserbuttonPdf.AddFilter(filterPdf);
		}

		protected void spremiKnjiga (object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "" || filechooserbuttonSlika.Filename == null || filechooserbuttonPdf.Filename == null)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			Knjiga k = new Knjiga();

			k.Naziv = entryNaziv.Text;
			k.Opis = entryOpis.Text;
			k.BrojStranica = int.Parse(entryBrojStranica.Text);
			k.Cijena = Double.Parse(entryCijena.Text);
			k.Nakladnik = entryNakladnik.Text;
			k.Tagovi = entryTagovi.Text;
			k.Jezik = entryJezik.Text;

			string slika = filechooserbuttonSlika.Filename;
			string pdf = filechooserbuttonPdf.Filename;

			for (int i = slika.Length - 1; i != 0; i--)
			{
				if (slika[i] == '\\')
				{
					slika = slika.Remove(0, i+1);
					break;
				}
			}

			for (int i = pdf.Length - 1; i != 0; i--)
			{
				if (pdf[i] == '\\')
				{
					pdf = pdf.Remove(0, i + 1);
					break;
				}
			}

			k.SlikaPath = "C:\\temp\\Images\\" + slika;
			k.PdfPath = "C:\\temp\\Pdf\\" + pdf;

			spremiSliku();
			spremiPdf();

			//D:\Downloads\AeKQcUf.jpg
			BPKnjiga.Spremi(k, listaAutora);

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
			startInfo.Arguments = "/C copy \""+ filechooserbuttonSlika.Filename + "\" C:\\temp\\Images";
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

		protected void pregledAutora(object sender, EventArgs a)
		{
			var windowAutori = new WindowPregledAutora(ref listaAutora, -1);
		}

		protected void spremiAutora(object sender, EventArgs a)
		{
			var windowAutori = new WindowDodavanjeAutora();
		}
	}
}
