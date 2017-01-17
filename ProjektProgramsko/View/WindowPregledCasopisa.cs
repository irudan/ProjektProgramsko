using System;
using System.Collections.Generic;
using Gtk;
namespace ProjektProgramsko
{
	public partial class WindowPregledCasopisa : Gtk.Window
	{
		public Casopis temp;

		public WindowPregledCasopisa(Casopis odabraniCasopis) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			temp = odabraniCasopis;

			buttonSpremi.Clicked += spremiCasopis;
			buttonOdustani.Clicked += odustani;

			CasopisNodeStore casopisPresenter = new CasopisNodeStore();

			nodeview1.NodeStore = casopisPresenter;

			nodeview1.AppendColumn("Naziv", new CellRendererText(), "text", 0);
			nodeview1.AppendColumn("Opis", new CellRendererText(), "text", 1);
			nodeview1.AppendColumn("Tagovi", new CellRendererText(), "text", 2);

			List<Casopis> listaCasopisa = BPCasopis.DohvatiSve();

			foreach (var i in listaCasopisa)
			{
				casopisPresenter.dodajCasopis(i);
			}
		}

		protected void spremiCasopis(object sender, EventArgs a)
		{
			CasopisNode casopisSelected = nodeview1.NodeSelection.SelectedNode as CasopisNode;
			if (casopisSelected == null)
				return;

			temp.Id = casopisSelected.id;
			temp.IdC = casopisSelected.idC;
			temp.Naziv = casopisSelected.naziv;
			temp.Opis = casopisSelected.opis;
			temp.Tagovi = casopisSelected.tagovi;

			this.Destroy();
		}

		protected void odustani(object sender, EventArgs a)
		{
			this.Destroy();
		}
	}
}
