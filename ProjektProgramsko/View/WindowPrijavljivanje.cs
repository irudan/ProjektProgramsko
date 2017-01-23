using System;
using Gtk;
using System.Collections.Generic;
namespace ProjektProgramsko
{
	public partial class WindowPrijavljivanje : Gtk.Window
	{

		public WidgetPrijava prijava;
		public WidgetRegistracija registracija = new WidgetRegistracija();

		public VBox glavni = new VBox();

		public WindowPrijavljivanje() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			prijava = new WidgetPrijava();

			glavni = glavniBox();

			glavni.Add(prijava);

			Button registracijaButton = prijava.getReg();
			Button natragButton = registracija.getNatrag();

			registracijaButton.Clicked += prikaziRegistracija;
			natragButton.Clicked += prikaziPrijava;

			Build();
		}

		protected void prikaziRegistracija(object sender, EventArgs a)
		{
			izbrisiDjecu(glavni);

			glavni.Add(registracija);

			Build();

			registracija.Destroyed += prikaziPrijava;
		}

		protected void prikaziPrijava(object sender, EventArgs a)
		{
			izbrisiDjecu(glavni);

			glavni.Add(prijava);

			Build();
		}

		protected VBox glavniBox()
		{
			return vboxMain;
		}

		protected void izbrisiDjecu(VBox box)
		{
			Widget[] temp = box.Children;

			foreach (var i in temp)
				box.Remove(i);
		}


	}
}
