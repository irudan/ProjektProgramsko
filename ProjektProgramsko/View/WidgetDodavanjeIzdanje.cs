using System;
using System.Collections.Generic;

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
		}

		protected void spremiIzdanje(object sender, EventArgs a)
		{
			IzdanjeCasopis ic = new IzdanjeCasopis();

			ic.Datum = int.Parse(entryMjesec.Text) * 1000 + int.Parse(entryGodina.Text);
			ic.BrojIzdanja = int.Parse(entryIzdanja.Text);
			ic.Cijena = double.Parse(entryCijena.Text);

			string slika = filechooserbutton1.Filename;

			for (int i = slika.Length - 1; i != 0; i--)
			{
				if (slika[i] == '\\')
				{
					slika = slika.Remove(0, i + 1);
					break;
				}
			}

			ic.SlikaPath = "Images/" + slika;

			spremiSliku(ic.SlikaPath);

			BPIzdanjeCasopis.Spremi(ic, odabraniCasopis.IdC);
		}

		protected void odaberiCasopis(object sender, EventArgs a)
		{
			var windowCasopisi = new WindowPregledCasopisa(odabraniCasopis);
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
