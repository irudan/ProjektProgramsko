using System;
using Gtk;
using System.Collections.Generic;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetPrijava : Gtk.Bin
	{
		public Button Potvrdi()
		{
			return buttonOdustani;
		}

		public Button Odustani()
		{
			return buttonOdustani;
		}

		public Button Registrirajse()
		{
			return buttonRegistrirajse;
		}

		public HBox getHbox()
		{
			return hbox2;
		}


		public WidgetPrijava()
		{
			this.Build();

		}



	}
}
