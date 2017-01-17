using System;
namespace ProjektProgramsko
{
	public class CasopisNode : Gtk.TreeNode
	{
		public long idC;
		public long id;

		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String opis;

		[Gtk.TreeNodeValue(Column = 2)]
		public String tagovi;

		public CasopisNode(Casopis c)
		{
			this.idC = c.IdC;
			this.id = c.Id;

			this.naziv = c.Naziv;
			this.opis = c.Opis;
			this.tagovi = c.Tagovi;
		}

	}
}
