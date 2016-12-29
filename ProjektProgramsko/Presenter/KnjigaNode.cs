using System;
namespace ProjektProgramsko
{
	public class KnjigaNode : Gtk.TreeNode
	{
		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String jezik;

		[Gtk.TreeNodeValue(Column = 2)]
		public String tagovi;

		public KnjigaNode(Knjiga k)
		{
			this.naziv = k.Naziv;
			this.jezik = k.Jezik;
			this.tagovi = k.Tagovi;
		}
	}
}
