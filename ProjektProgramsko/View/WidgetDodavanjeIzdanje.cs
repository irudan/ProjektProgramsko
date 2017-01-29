using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetDodavanjeIzdanje : Gtk.Bin
	{
		public Casopis odabraniCasopis = new Casopis();

		public WidgetDodavanjeIzdanje()
		{
			this.Build();

			buttonSpremi.Clicked += spremiIzdanje;
			buttonOdabirCasopis.Clicked += odaberiCasopis;

			FileFilter filterSlika = new FileFilter();
			filterSlika.Name = "Images";
			filterSlika.AddPattern("*.jpg");
			filechooserbuttonSlika.AddFilter(filterSlika);

			FileFilter filterPdf = new FileFilter();
			filterPdf.Name = "Pdf Files";
			filterPdf.AddPattern("*.pdf");
			filechooserbuttonPdf.AddFilter(filterPdf);
		}

		protected void spremiIzdanje(object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "" || entryGodina.Text == "" || entryMjesec.Text =="" || filechooserbuttonSlika.Filename == null || odabraniCasopis.Naziv == null || filechooserbuttonPdf == null)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			IzdanjeCasopis ic = new IzdanjeCasopis();

			//ic.Id = odabraniCasopis.Id;
			ic.Datum = entryMjesec.Text + entryGodina.Text;
			ic.BrojIzdanja = int.Parse(entryIzdanja.Text);
			ic.Cijena = double.Parse(entryCijena.Text);

			string slika = filechooserbuttonSlika.Filename;
			string pdf = filechooserbuttonPdf.Filename;

			for (int i = slika.Length - 1; i != 0; i--)
			{
				if (slika[i] == '\\')
				{
					slika = slika.Remove(0, i + 1);
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

			ic.SlikaPath = "C:\\temp\\Images\\" + slika;
			ic.PdfPath = "C:\\temp\\Pdf\\" + pdf;

			spremiSliku();
			spremiPdf();

			BPIzdanjeCasopis.Spremi(ic, odabraniCasopis.IdC);

			foreach (var i in polje)
			{
				entry = (Entry)i;
				entry.Text = "";
			}
			entryMjesec.Text = "";
			entryGodina.Text = "";

			odabraniCasopis = new Casopis();
		}

		protected void odaberiCasopis(object sender, EventArgs a)
		{
			var windowCasopisi = new WindowPregledCasopisa(odabraniCasopis);
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
