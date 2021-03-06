﻿using System;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowDodavanjeAutora : Gtk.Window
	{
		public WindowDodavanjeAutora() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			buttonSpremi.Clicked += spremiAutora;
			buttonOdustani.Clicked += odustani;
		}

		protected void spremiAutora(object sender, EventArgs a)
		{
			if (entryIme.Text == "" || entryPrezime.Text == "")
			{

				Dialog d = new Gtk.MessageDialog(this, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				d.Run();
				d.Destroy();
				return;
			}

			Autor temp = new Autor();

			temp.Ime = entryIme.Text;
			temp.Prezime = entryPrezime.Text;

			BPAutor.Spremi(temp);

			this.Destroy();
		}

		protected void odustani(object sender, EventArgs a)
		{
			this.Destroy();
		}
	}
}
