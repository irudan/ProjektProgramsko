using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class FilmNodeStore : Gtk.NodeStore
	{
		public FilmNodeStore() : base(typeof(FilmNode))
		{
		}

		public void dodajFilm(Film f)
		{
			FilmNode temp = new FilmNode(f);
			this.AddNode(temp);
		}

		public void dodajFilmove(List<Film> f)
		{
			foreach (Film i in f)
			{
				FilmNode temp = new FilmNode(i);
				this.AddNode(temp);
			}
		}
	}
}
