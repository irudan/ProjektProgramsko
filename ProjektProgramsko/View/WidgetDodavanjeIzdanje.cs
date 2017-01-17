﻿using System;
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

			FileFilter filter = new FileFilter();
			filter.Name = "Images";
			filter.AddPattern("*.jpg");
			filechooserbutton1.AddFilter(filter);
		}

		protected void spremiIzdanje(object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "" || entryGodina.Text == "" || entryMjesec.Text =="" || filechooserbutton1.Filename == null || odabraniCasopis.Naziv == null)
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			IzdanjeCasopis ic = new IzdanjeCasopis();

			ic.Datum = entryMjesec.Text + entryGodina.Text;
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
