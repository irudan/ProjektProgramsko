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

			FileFilter filter = new FileFilter();
			filter.Name= "Images";
			filter.AddPattern("*.jpg");
			filechooserbutton1.AddFilter(filter);
		}

		protected void spremiKnjiga (object sender, EventArgs a)
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

			Knjiga k = new Knjiga();

			k.Naziv = entryNaziv.Text;
			k.Opis = entryOpis.Text;
			k.BrojStranica = int.Parse(entryBrojStranica.Text);
			k.Cijena = Double.Parse(entryCijena.Text);
			k.Nakladnik = entryNakladnik.Text;
			k.Tagovi = entryTagovi.Text;
			k.Jezik = entryJezik.Text;

			string slika = filechooserbutton1.Filename;

			for (int i = slika.Length - 1; i != 0; i--)
			{
				if (slika[i] == '\\')
				{
					slika = slika.Remove(0, i+1);
					break;
				}
			}

			k.SlikaPath = "Images/" + slika;

			spremiSliku(k.SlikaPath);

			//D:\Downloads\AeKQcUf.jpg
			BPKnjiga.Spremi(k, listaAutora);

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
			startInfo.Arguments = "/C copy "+ filechooserbutton1.Filename +" C:\\Users\\Mateo\\Documents\\GitHub\\ProjektProgramsko\\ProjektProgramsko\\bin\\Debug\\Images";
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
