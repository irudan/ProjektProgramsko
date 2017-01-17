using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetUredivanjeSadrzaja : Gtk.Bin
	{
		public WidgetUredivanjeSadrzaja()
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

		public RadioButton radioIzdanje()
		{
			return radiobuttonIzdanje;
		}

		public RadioButton radioAutor()
		{
			return radiobuttonAutori;
		}

		public VBox radioBox()
		{
			return vbox2;
		}
	}
}
