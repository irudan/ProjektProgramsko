using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetKnjiga : Gtk.Bin
	{
		public WidgetKnjiga()
		{
			this.Build();

			comboboxSortiraj.AppendText("Najčitanije");
			comboboxSortiraj.AppendText("Najprodavanije");

			comboboxTagovi.AppendText("Drama");
			comboboxTagovi.AppendText("Komedija");
			comboboxTagovi.AppendText("Sci-Fi");
		}
	}
}
