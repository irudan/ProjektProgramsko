using System;
using System.Collections.Generic;
using Gtk;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetUredivanjeKnjiga : Gtk.Bin
	{
		public KnjigaNodeStore knjigaPresenter = new KnjigaNodeStore();

		public WidgetUredivanjeKnjiga()
		{
			this.Build();

			buttonUredi.Clicked += urediKnjiga;
			buttonIzbrisi.Clicked += izbrisiKnjiga;

			nodeview1.NodeStore = knjigaPresenter;

			nodeview1.AppendColumn("Naziv", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Broj stranica", new CellRendererText(), "text", 2);
			nodeview1.AppendColumn("Cijena", new CellRendererText(), "text", 3);
			nodeview1.AppendColumn("Nakladnik", new CellRendererText(), "text", 4);
			nodeview1.AppendColumn("Jezik", new CellRendererText(), "text", 5);
			nodeview1.AppendColumn("Tagovi", new CellRendererText(), "text", 6);

			List<Knjiga> listaKnjiga = BPKnjiga.DohvatiSve();

			knjigaPresenter.dodajKnjige(listaKnjiga);
		}

		protected void urediKnjiga(object sender, EventArgs a)
		{
			KnjigaNode knjigaSelected = nodeview1.NodeSelection.SelectedNode as KnjigaNode;
			if (knjigaSelected == null)
				return;

			Knjiga temp = BPKnjiga.DohvatiKnjiga(knjigaSelected.idK);

			var windowKnjiga = new WindowUredivanjeKnjiga(temp);

			windowKnjiga.Destroyed += osvjezi;
		}

		protected void izbrisiKnjiga(object sender, EventArgs a)
		{
			KnjigaNode knjigaSelected = nodeview1.NodeSelection.SelectedNode as KnjigaNode;
			if (knjigaSelected == null)
				return;

			long idK = knjigaSelected.idK;
			long id = knjigaSelected.id;

			BPKnjiga.Izbrisi(id, idK);

			osvjezi(null, null);
		}

		protected void osvjezi(object sender, EventArgs a)
		{
			knjigaPresenter.Clear();

			List<Knjiga> listaKnjiga = BPKnjiga.DohvatiSve();

			knjigaPresenter.dodajKnjige(listaKnjiga);
		}
	}
}
