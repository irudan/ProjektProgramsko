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

		public Button getKnjige()
		{
			return buttonKnjige;
		}

		public Button getPocetna()
		{
			return buttonPocetna;
		}

		public VBox getVbox()//Funkcija za dohvacanje vrijednosi hbox-a
		{
			return vboxMain;
		}
	}
}
