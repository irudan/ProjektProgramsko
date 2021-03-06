﻿using System;
namespace ProjektProgramsko
{
	public class IzdanjeNode : Gtk.TreeNode
	{
		public long id;
		public long idC;
		public string path;

		[Gtk.TreeNodeValue(Column = 0)]
		public String nazivCasopisa;

		[Gtk.TreeNodeValue(Column = 1)]
		public String datum;

		[Gtk.TreeNodeValue(Column = 2)]
		public String brojIzdanja;

		[Gtk.TreeNodeValue(Column = 3)]
		public String cijena;

		public IzdanjeNode(Casopis c, IzdanjeCasopis i)
		{
			this.id = i.Id;
			this.idC = c.IdC;
			this.path = i.PdfPath;


			this.nazivCasopisa = c.Naziv;
			this.datum = i.Datum;
			this.brojIzdanja = i.BrojIzdanja.ToString();
			this.cijena = i.Cijena.ToString();
		}
	}
}
