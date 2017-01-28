using System;
namespace ProjektProgramsko
{
	public class KnjigaNode : Gtk.TreeNode
	{
		public long idK;
		public long id;
		public string path;

		[Gtk.TreeNodeValue(Column = 0)]
		public String naziv;

		[Gtk.TreeNodeValue(Column = 1)]
		public String opis;

		[Gtk.TreeNodeValue(Column = 2)]
		public String brojStranica;

		[Gtk.TreeNodeValue(Column = 3)]
		public String cijena;

		[Gtk.TreeNodeValue(Column = 4)]
		public String nakladnik;

		[Gtk.TreeNodeValue(Column = 5)]
		public String jezik;

		[Gtk.TreeNodeValue(Column = 6)]
		public String tagovi;

		public KnjigaNode(Knjiga k)
		{
			this.id = k.Id;
			this.idK = k.IdK;
			this.path = k.PdfPath;

			this.naziv = k.Naziv;
			this.opis = k.Opis;
			this.brojStranica = k.BrojStranica.ToString();
			this.cijena = k.Cijena.ToString();
			this.nakladnik = k.Nakladnik;
			this.jezik = k.Jezik;
			this.tagovi = k.Tagovi;
		}
	}
}
