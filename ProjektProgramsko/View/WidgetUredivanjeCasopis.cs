using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetUredivanjeCasopis : Gtk.Bin
	{
		public CasopisNodeStore casopisPresenter = new CasopisNodeStore();

		public WidgetUredivanjeCasopis()
		{
			this.Build();

			buttonUredi.Clicked += urediCasopis;
			buttonIzbrisi.Clicked += izbrisiCasopis;

			nodeview1.NodeStore = casopisPresenter;

			nodeview1.AppendColumn("Naziv", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Tagovi", new CellRendererText(), "text", 2);

			List<Casopis> listaCasopisa = BPCasopis.DohvatiSve();

			casopisPresenter.dodajCasopise(listaCasopisa);
		}

		protected void urediCasopis(object sender, EventArgs a)
		{
			CasopisNode casopisSelected = nodeview1.NodeSelection.SelectedNode as CasopisNode;
			if (casopisSelected == null)
				return;
			Casopis temp = BPCasopis.DohvatiCasopis(casopisSelected.idC);

			var windowCasopis = new WindowUredivanjeCasopis(temp);

			windowCasopis.Destroyed += osvjezi;
		}

		protected void izbrisiCasopis(object sender, EventArgs a)
		{
			CasopisNode casopisSelected = nodeview1.NodeSelection.SelectedNode as CasopisNode;
			if (casopisSelected == null)
				return;

			long idC = casopisSelected.idC;
			long id = casopisSelected.id;

			BPCasopis.Izbrisi(id, idC);

			osvjezi(null, null);
		}

		protected void osvjezi(object sender, EventArgs a)
		{
			casopisPresenter.Clear();

			List<Casopis> listaCasopisa = BPCasopis.DohvatiSve();

			casopisPresenter.dodajCasopise(listaCasopisa);
		}
	}
}
