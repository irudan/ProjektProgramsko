using System;
using Gtk;
using System.Collections.Generic;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetRegistracija : Gtk.Bin
	{

		public Button Spremi()
		{
			return buttonSpremi;
		}

		public Button Odustani()
		{
			return buttonOdustani;
		}

		public WidgetRegistracija()
		{
			this.Build();


		}
	}
}
