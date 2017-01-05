using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class GlavniMeni : Gtk.Bin
	{
		public GlavniMeni()
		{
			this.Build();
		}

		public Widget getKnjige()
		{
			return buttonKnjige;
		}

		public Widget getPocetna()
		{
			return buttonPocetna;
		}

		public Widget getHbox()//Funkcija za dohvacanje vrijednosi hbox-a
		{
			return vboxMain;
		}
	}
}
