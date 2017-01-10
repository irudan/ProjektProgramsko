using System;
using Gtk;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetDodavanjeSadrzaja : Gtk.Bin
	{
		public WidgetDodavanjeSadrzaja()
		{
			this.Build();
		}

		public RadioButton radioKnjiga()
		{
			return radiobuttonKnjiga;
		}

		public RadioButton radioCasopis()
		{
			return radiobuttonCasopis;
		}

		public RadioButton radioFilm()
		{
			return radiobuttonFilm;
		}

		public VBox radioBox()
		{
			return vbox4;
		}
	}
}
