using System;
namespace ProjektProgramsko
{
	public class CasopisNode : Gtk.TreeNode
	{
		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;


		[Gtk.TreeNodeValue(Column = 1)]
		public String tagovi;

		public CasopisNode(Casopis c)
		{
			this.naziv = c.Naziv;
			this.tagovi = c.Tagovi;
		}

	}
}
