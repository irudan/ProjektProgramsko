using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetDodavanjeCasopis : Gtk.Bin
	{
		public WidgetDodavanjeCasopis()
		{
			this.Build();

			buttonSpremi.Clicked += spremiCasopis;
		}

		protected void spremiCasopis(object sender, EventArgs a)
		{
			Widget[] polje = vboxEntry.Children;
			Entry entry;

			foreach (var i in polje)
			{
				entry = (Entry)i;
				if (entry.Text == "")
				{
					Dialog d = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

					d.Run();
					d.Destroy();
					return;
				}
			}

			Casopis c = new Casopis();

			c.Naziv = entryNaziv.Text;
			c.Opis = entryOpis.Text;
			c.Tagovi = entryTagovi.Text;

			BPCasopis.Spremi(c);

			foreach (var i in polje)
			{
				entry = (Entry)i;
				entry.Text = "";
			}

		}
	}
}
