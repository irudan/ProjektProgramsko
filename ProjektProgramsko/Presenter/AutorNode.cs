using System;
namespace ProjektProgramsko
{
	public class AutorNode : Gtk.TreeNode
	{
		public long id;

		[Gtk.TreeNodeValue(Column = 0)]
		public String ime;

		[Gtk.TreeNodeValue(Column = 1)]
		public String prezime;

		public AutorNode(Autor a)
		{
			this.id = a.Id;

			this.ime = a.Ime;
			this.prezime = a.Prezime;
		}
	}
}
