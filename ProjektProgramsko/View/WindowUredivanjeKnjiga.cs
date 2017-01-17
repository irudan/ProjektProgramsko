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

			FileFilter filter = new FileFilter();
			filter.Name = "Images";
			filter.AddPattern("*.jpg");
			filechooserbutton1.AddFilter(filter);
		}

		protected void spremiKnjiga(object sender, EventArgs a)
		{
			if (entryNaziv.Text == "" || entryOpis.Text == "" || entryBrojStranica.Text == "" || entryCijena.Text == "" || entryNakladnik.Text == ""
				|| entryTagovi.Text == "" || entryCijena.Text == "")
			{

				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			k.Naziv = entryNaziv.Text;
			k.Opis = entryOpis.Text;
			k.BrojStranica = int.Parse(entryBrojStranica.Text);
			k.Cijena = Double.Parse(entryCijena.Text);
			k.Nakladnik = entryNakladnik.Text;
			k.Tagovi = entryTagovi.Text;
			k.Jezik = entryJezik.Text;

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

				k.SlikaPath = "Images/" + slika;

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
			startInfo.Arguments = "/C copy " + filechooserbutton1.Filename + " C:\\Users\\Mateo\\Documents\\GitHub\\ProjektProgramsko\\ProjektProgramsko\\bin\\Debug\\Images";
			process.StartInfo = startInfo;
			process.Start();
		}
	}
}
