using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class AutorNodeStore : Gtk.NodeStore
	{
		public AutorNodeStore() : base(typeof(AutorNode))
		{
		}

		public void dodajAutore(List<Autor> a)
		{
			foreach (Autor i in a)
			{
				AutorNode temp = new AutorNode(i);
				this.AddNode(temp);
			}
		}
	}
}
