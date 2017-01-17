using System;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowUredivanjeIzdanje : Gtk.Window
	{
		public IzdanjeCasopis ic;
		public Casopis odabraniCasopis = new Casopis();

		public WindowUredivanjeIzdanje(IzdanjeCasopis arg) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			ic = arg;

			buttonSpremi.Clicked += spremiIzdanje;
			buttonOdustani.Clicked += odustani;
			buttonOdabirCasopis.Clicked += odaberiCasopis;

			entryMjesec.Text = ic.Datum.Substring(0, 2);
			entryGodina.Text = ic.Datum.Substring(2);
			entryIzdanja.Text = ic.BrojIzdanja.ToString();
			entryCijena.Text = ic.Cijena.ToString();

			FileFilter filter = new FileFilter();
			filter.Name = "Images";
			filter.AddPattern("*.jpg");
			filechooserbutton1.AddFilter(filter);
		}

		protected void spremiIzdanje(object sender, EventArgs a)
		{
			if (entryGodina.Text == "" || entryMjesec.Text == "" || entryCijena.Text == "" || entryIzdanja.Text == "" || odabraniCasopis.Naziv == null)
			{

				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			ic.Datum = entryMjesec.Text + entryGodina.Text;
			ic.BrojIzdanja = int.Parse(entryIzdanja.Text);
			ic.Cijena = double.Parse(entryCijena.Text);

			if (filechooserbutton1.Filename != null)
			{
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
			}

			BPIzdanjeCasopis.Uredi(ic, odabraniCasopis.IdC);
		}

		protected void odaberiCasopis(object sender, EventArgs a)
		{
			var windowCasopisi = new WindowPregledCasopisa(odabraniCasopis);
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
			startInfo.Arguments = "/C copy " + filechooserbutton1.Filename + " C:\\Users\\Mateo\\Documents\\GitHub\\ProjektProgramsko\\ProjektProgramsko\\bin\\Debug\\Images";
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
