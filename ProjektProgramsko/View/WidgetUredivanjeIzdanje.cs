using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetUredivanjeIzdanje : Gtk.Bin
	{
		public IzdanjeNodeStore izdanjePresenter = new IzdanjeNodeStore();

		public WidgetUredivanjeIzdanje()
		{
			this.Build();

			buttonUredi.Clicked += urediIzdanje;
			buttonIzbrisi.Clicked += izbrisiIzdanje;

			nodeview1.NodeStore = izdanjePresenter;

			nodeview1.AppendColumn("Naziv Casopisa", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Datum izdanja", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Broj izdanja", new CellRendererText(), "text", 2);
			nodeview1.AppendColumn("Cijena", new CellRendererText(), "text", 3);

			List<Casopis> listaCasopisa = BPCasopis.DohvatiSve();

			izdanjePresenter.dodajIzdanja(listaCasopisa);
		}

		protected void urediIzdanje(object sender, EventArgs a)
		{
			IzdanjeNode izdanjeSelected = nodeview1.NodeSelection.SelectedNode as IzdanjeNode;
			if (izdanjeSelected == null)
				return;
			IzdanjeCasopis temp = BPIzdanjeCasopis.DohvatiIzdanje(izdanjeSelected.id);

			var windowFilm = new WindowUredivanjeIzdanje(temp);

			windowFilm.Destroyed += osvjezi;
		}

		protected void izbrisiIzdanje(object sender, EventArgs a)
		{
			IzdanjeNode izdanjeSelected = nodeview1.NodeSelection.SelectedNode as IzdanjeNode;
			if (izdanjeSelected == null)
				return;

			long id = izdanjeSelected.id;

			BPIzdanjeCasopis.Izbrisi(id);

			osvjezi(null, null);
		}

		protected void osvjezi(object sender, EventArgs a)
		{
			izdanjePresenter.Clear();

			List<Casopis> listaCasopisa = BPCasopis.DohvatiSve();

			izdanjePresenter.dodajIzdanja(listaCasopisa);
		}
	}
}
