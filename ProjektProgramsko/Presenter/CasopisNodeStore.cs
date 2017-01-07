using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class CasopisNodeStore : Gtk.NodeStore
	{
		public CasopisNodeStore() : base(typeof(CasopisNode))
		{
		}

		public void dodajCasopis(Casopis c)
		{
			CasopisNode temp = new CasopisNode(c);
			this.AddNode(temp);
		}

		public void dodajCasopis(List<Casopis> c)
		{
			foreach (Casopis i in c)
			{
				CasopisNode temp = new CasopisNode(i);
				this.AddNode(temp);
			}
		}
	}
}
