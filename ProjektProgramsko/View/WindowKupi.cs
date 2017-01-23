using System;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowKupi : Gtk.Window
	{
		public VBox boxkupovina;

		public WidgetKartica kartica;
		public WidgetPayPal paypal;

		public long pokId;
		public double pokC;

		public WindowKupi(long id, double cijena) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			kartica = new WidgetKartica(id, cijena);
			paypal = new WidgetPayPal(id, cijena);

			boxkupovina = vboxKupovina();

			//PrikaziKartica(null, null);
			this.WindowStateEvent += PrikaziKartica;

			radiobuttonKartica.Clicked += PrikaziKartica;
			radiobuttonPayPal.Clicked += PrikaziPayPal;
		}

		protected void PrikaziKartica(object sender, EventArgs a)
		{
			izbrisiDjecu(boxkupovina);

			boxkupovina.Add(kartica);

			Build();
		}

		protected void PrikaziPayPal(object sender, EventArgs a)
		{
			izbrisiDjecu(boxkupovina);

			boxkupovina.Add(paypal);

			Build();
		}

		protected void izbrisiDjecu(VBox box)
		{
			Widget[] temp = box.Children;

			foreach (var i in temp)
				box.Remove(i);
		}

		public VBox vboxKupovina()
		{
			return vboxMain;
		}
	}
}
