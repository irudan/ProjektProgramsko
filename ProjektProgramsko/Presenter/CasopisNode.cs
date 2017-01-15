using System;
namespace ProjektProgramsko
{
	public class CasopisNode : Gtk.TreeNode
	{
		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String opis;

		[Gtk.TreeNodeValue(Column = 2)]
		public String tagovi;

		public long id;

		public CasopisNode(Casopis c)
		{
			this.naziv = c.Naziv;
			this.opis = c.Opis;
			this.tagovi = c.Tagovi;
			this.id = c.IdC;
		}

	}
}
