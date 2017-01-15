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

		public WindowPregledAutora(ref List<Autor> listaAutora) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			tempLista = listaAutora;

			listaAutoriBP = BPAutor.DohvatiSve();

			foreach (var i in listaAutoriBP)
			{
				CheckButton button = new CheckButton();
				button.Label = i.Ime +" "+ i.Prezime;

				vboxMain.Add(button);
			}

			buttonSpremi.Clicked += spremiAutore;
			vboxmain = vboxMain;

			Build();
		}

		protected void spremiAutore(object sender, EventArgs a)
		{
			Widget []djeca = vboxmain.Children;

			foreach (CheckButton i in djeca)
			{
				if (i.Active)
				{
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

			this.Destroy();
		}
	}
}
