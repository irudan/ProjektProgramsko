using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetMojSadrzaj : Gtk.Bin
	{
		public WidgetMojSadrzaj()
		{
			this.Build();

			radiobuttonKnjiga.Clicked += prikaziKnjige;
			radiobuttonIzdanje.Clicked += prikaziIzdanja;
			radiobuttonFilm.Clicked += prikaziFilmove;

			buttonPregledaj.Clicked += pregledaj;

			prikaziKnjige(null, null);
		}

		public void prikaziKnjige(object sender, EventArgs a)
		{
			KnjigaNodeStore presenter = new KnjigaNodeStore();

			List<Knjiga> lista = BPKnjiga.DohvatiMojSadrzaj();

			nodeview1.NodeStore = presenter;

			foreach (var i in nodeview1.Columns)
			{
				nodeview1.RemoveColumn(i);
			}

			nodeview1.AppendColumn("Naziv", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Broj stranica", new CellRendererText(), "text", 2);
			nodeview1.AppendColumn("Cijena", new CellRendererText(), "text", 3);
			nodeview1.AppendColumn("Nakladnik", new CellRendererText(), "text", 4);
			nodeview1.AppendColumn("Jezik", new CellRendererText(), "text", 5);
			nodeview1.AppendColumn("Tagovi", new CellRendererText(), "text", 6);

			presenter.dodajKnjige(lista);
		}

		public void prikaziIzdanja(object sender, EventArgs a)
		{
			IzdanjeNodeStore presenter = new IzdanjeNodeStore();

			List<Casopis> lista = BPCasopis.DohvatiMojSadrzaj();

			nodeview1.NodeStore = presenter;

			foreach (var i in nodeview1.Columns)
			{
				nodeview1.RemoveColumn(i);
			}

			nodeview1.AppendColumn("Naziv Casopisa", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Datum izdanja", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Broj izdanja", new CellRendererText(), "text", 2);
			nodeview1.AppendColumn("Cijena", new CellRendererText(), "text", 3);

			presenter.dodajIzdanja(lista);
		}

		public void prikaziFilmove(object sender, EventArgs a)
		{
			FilmNodeStore presenter = new FilmNodeStore();

			List<Film> lista = BPFilm.DohvatiMojSadrzaj();

			nodeview1.NodeStore = presenter;

			foreach (var i in nodeview1.Columns)
			{
				nodeview1.RemoveColumn(i);
			}

			nodeview1.AppendColumn("Naziv", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Redatelj", new CellRendererText(), "text", 2);
			nodeview1.AppendColumn("Godina", new CellRendererText(), "text", 3);
			nodeview1.AppendColumn("Trajanje", new CellRendererText(), "text", 4);
			nodeview1.AppendColumn("Cijena", new CellRendererText(), "text", 5);
			nodeview1.AppendColumn("Tagovi", new CellRendererText(), "text", 6);

			presenter.dodajFilmove(lista);
		}

		protected void pregledaj(object sender, EventArgs a)
		{
			var tip = nodeview1.NodeSelection.SelectedNode;

			if (tip is KnjigaNode)
			{
				KnjigaNode i = nodeview1.NodeSelection.SelectedNode as KnjigaNode;
				if (i == null)
					return;

				var windowPregledaj = new WindowPregledaj(i.path, i.id, i.idK);
			}
			else if (tip is FilmNode)
			{
				FilmNode i = nodeview1.NodeSelection.SelectedNode as FilmNode;
				if (i == null)
					return;

				//var windowPregledaj = new WindowPregledaj(i);
			}
			else
			{
				IzdanjeNode i = nodeview1.NodeSelection.SelectedNode as IzdanjeNode;
				if (i == null)
					return;

				var windowPregledaj = new WindowPregledaj(i.path, i.idC, i.id);
			}
		}
	}
}
