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

		public Widget test()//Funkcija za dohvacanje vrijednosi hbox-a
		{
			return hboxMain;
		}
	}
}
