using System;
using Gtk;
using System.Collections.Generic;
namespace ProjektProgramsko
{
	public partial class WindowPrijavljivanje : Gtk.Window
	{

		public WidgetPrijava prijava = new WidgetPrijava();
		public WidgetRegistracija registracija = new WidgetRegistracija();

		public HBox glavni = new HBox();

		protected void izbrisiDjecu(HBox box)
		{
			Widget[] temp = box.Children;

			foreach (var i in temp)
				box.Remove(i);
		}


		public WindowPrijavljivanje() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			glavni = widgetprijava1.getHbox();

			Button Registriraj = widgetprijava1.Registrirajse();

			Registriraj.Clicked += getRegistracija;

			glavni.Add(prijava);

		}

		protected void getRegistracija(object sender, EventArgs a)
		{
			izbrisiDjecu(glavni);

			glavni.Add(registracija);

			Build();
		}

	}
}
