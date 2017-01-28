using System;
namespace ProjektProgramsko
{
	public class FilmNode : Gtk.TreeNode
	{
		public long idF;
		public long id;
		public string path;

		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String opis;

		[Gtk.TreeNodeValue(Column = 2)]
		public String redatelj;

		[Gtk.TreeNodeValue(Column = 3)]
		public String godina;

		[Gtk.TreeNodeValue(Column = 4)]
		public String trajanje;

		[Gtk.TreeNodeValue(Column = 5)]
		public String cijena;

		[Gtk.TreeNodeValue(Column = 6)]
		public String tagovi;

		public FilmNode(Film f)
		{
			this.idF = f.IdF;
			this.id = f.Id;
			this.path = "";

			this.naziv = f.Naziv;
			this.opis = f.Opis;
			this.redatelj = f.Redatelj;
			this.godina = f.Godina.ToString();
			this.trajanje = f.Trajanje.ToString();
			this.cijena = f.Cijena.ToString();
			this.tagovi = f.Tagovi;
		}
	}
}
