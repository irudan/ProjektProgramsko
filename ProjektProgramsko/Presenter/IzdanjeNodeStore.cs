using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class IzdanjeNodeStore : Gtk.NodeStore
	{
		public IzdanjeNodeStore() : base(typeof(IzdanjeNode))
		{
		}

		public void dodajIzdanja(List<Casopis> c)
		{
			foreach (Casopis i in c)
			{
				foreach (var j in i.IzdanjeCasopis)
				{
					IzdanjeNode temp = new IzdanjeNode(i, j);
					this.AddNode(temp);
				}
			}
		}
	}
}
