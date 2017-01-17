using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetUredivanjeFilm : Gtk.Bin
	{
		public FilmNodeStore filmPresenter = new FilmNodeStore();

		public WidgetUredivanjeFilm()
		{
			this.Build();

			buttonUredi.Clicked += urediFilm;
			buttonIzbrisi.Clicked += izbrisiFilm;

			nodeview1.NodeStore = filmPresenter;

			nodeview1.AppendColumn("Naziv", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Redatelj", new CellRendererText(), "text", 2);
			nodeview1.AppendColumn("Godina", new CellRendererText(), "text", 3);
			nodeview1.AppendColumn("Trajanje", new CellRendererText(), "text", 4);
			nodeview1.AppendColumn("Cijena", new CellRendererText(), "text", 5);
			nodeview1.AppendColumn("Tagovi", new CellRendererText(), "text", 6);

			List<Film> listaFilm = BPFilm.DohvatiSve();

			filmPresenter.dodajFilmove(listaFilm);
		}

		protected void urediFilm(object sender, EventArgs a)
		{
			FilmNode filmSelected = nodeview1.NodeSelection.SelectedNode as FilmNode;
			if (filmSelected == null)
				return;
			Film temp = BPFilm.DohvatiFilm(filmSelected.idF);

			var windowFilm = new WindowUredivanjeFilm(temp);

			windowFilm.Destroyed += osvjezi;
		}

		protected void izbrisiFilm(object sender, EventArgs a)
		{
			FilmNode filmSelected = nodeview1.NodeSelection.SelectedNode as FilmNode;
			if (filmSelected == null)
				return;

			long idF = filmSelected.idF;
			long id = filmSelected.id;

			BPFilm.Izbrisi(id, idF);

			osvjezi(null, null);
		}

		protected void osvjezi(object sender, EventArgs a)
		{
			filmPresenter.Clear();

			List<Film> listaFilm = BPFilm.DohvatiSve();

			filmPresenter.dodajFilmove(listaFilm);
		}
	}
}
