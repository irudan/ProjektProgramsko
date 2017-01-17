using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetUredivanjeAutora : Gtk.Bin
	{
		public AutorNodeStore autorPresenter = new AutorNodeStore();

		public WidgetUredivanjeAutora()
		{
			this.Build();

			buttonUredi.Clicked += urediAutor;
			buttonIzbrisi.Clicked += izbrisiAutor;

			nodeview1.NodeStore = autorPresenter;

			nodeview1.AppendColumn("Ime", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Prezime", new CellRendererText(), "text", 1);

			List<Autor> listAutori = BPAutor.DohvatiSve();

			autorPresenter.dodajAutore(listAutori);
		}

		protected void urediAutor(object sender, EventArgs a)
		{
			AutorNode autorSelected = nodeview1.NodeSelection.SelectedNode as AutorNode;
			if (autorSelected == null)
				return;

			Autor temp = new Autor();
			temp.Id = autorSelected.id;
			temp.Ime = autorSelected.ime;
			temp.Prezime = autorSelected.prezime;

			var windowAutor = new WindowUredivanjeAutora(temp);

			windowAutor.Destroyed += osvjezi;
		}

		protected void izbrisiAutor(object sender, EventArgs a)
		{
			AutorNode autorSelected = nodeview1.NodeSelection.SelectedNode as AutorNode;
			if (autorSelected == null)
				return;

			long id = autorSelected.id;

			BPAutor.Izbrisi(id);

			osvjezi(null, null);
		}

		protected void osvjezi(object sender, EventArgs a)
		{
			autorPresenter.Clear();

			List<Autor> listAutori = BPAutor.DohvatiSve();

			autorPresenter.dodajAutore(listAutori);
		}
	}
}
