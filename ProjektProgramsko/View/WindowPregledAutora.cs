using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowPregledAutora : Gtk.Window
	{
		public List<Autor> tempLista;
		public List<Autor> listaAutoriBP;
		public VBox vboxmain;

		public WindowPregledAutora(ref List<Autor> listaAutora, long id) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			tempLista = listaAutora;

			listaAutoriBP = BPAutor.DohvatiSve();

			List<Autor> listaOznacenihAutora = BPAutor.DohvatiAutore(id);

			foreach (var i in listaAutoriBP)
			{
				CheckButton button = new CheckButton();
				button.Label = i.Ime +" "+ i.Prezime;

				foreach (var j in listaOznacenihAutora)
				{
					if (i.Ime == j.Ime && i.Prezime == j.Prezime)
					{
						button.Active = true;
					}
				}

				vboxMain.Add(button);
			}

			buttonSpremi.Clicked += spremiAutore;
			buttonOdustani.Clicked += odustani;
			vboxmain = vboxMain;

			Build();
		}

		protected void spremiAutore(object sender, EventArgs a)
		{
			Widget []djeca = vboxmain.Children;

			int brojac = 0;

			foreach (CheckButton i in djeca)
			{
				if (i.Active)
				{
					brojac++;

					string label = i.Label;
					string []labelSplit = label.Split(new[] { ' ' }, 2);

					string ime = labelSplit[0];
					string prezime = labelSplit[1];

					long autorID = new long();

					foreach (var j in listaAutoriBP)
					{
						if (j.Prezime == prezime)
						{
							autorID = j.Id;
							break;
						}
					}

					Autor temp = new Autor(autorID, ime, prezime);

					tempLista.Add(temp);
				}
			}

			if (brojac == 0)
			{

				Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Bar jedan autor mora biti odabran!");

				d.Run();
				d.Destroy();
				return;
			}

			this.Destroy();
		}

		protected void odustani(object sender, EventArgs a)
		{
			this.Destroy();
		}
	}
}
