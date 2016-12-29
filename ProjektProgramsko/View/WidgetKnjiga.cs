using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetKnjiga : Gtk.Bin
	{
		public KnjigaNodeStore knjigaPresenter = new KnjigaNodeStore();

		public WidgetKnjiga()
		{
			this.Build();

			comboboxSortiraj.AppendText("Najčitanije");
			comboboxSortiraj.AppendText("Najprodavanije");

			comboboxTagovi.AppendText("Drama");
			comboboxTagovi.AppendText("Komedija");
			comboboxTagovi.AppendText("Sci-Fi");


			nodeview1.NodeStore = knjigaPresenter;

			nodeview1.AppendColumn("Naziv", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Jezik", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Tagovi", new CellRendererText(), "text", 2);

			List < Knjiga > knjige = BPKnjiga.DohvatiSve();
			knjigaPresenter.dodajKnjige(knjige);
		}
	}
}
