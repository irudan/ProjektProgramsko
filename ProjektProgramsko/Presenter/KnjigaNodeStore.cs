using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class KnjigaNodeStore : Gtk.NodeStore
	{
		public KnjigaNodeStore() : base(typeof(KnjigaNode))
		{
		}

		public void dodajKnjiga(Knjiga k)
		{
			KnjigaNode temp = new KnjigaNode(k);
			this.AddNode(temp);
		}

		public void dodajKnjige(List <Knjiga> k)
		{
			foreach (Knjiga i in k)
			{
				KnjigaNode temp = new KnjigaNode(i);
				this.AddNode(temp);
			}
		}
	}
}
