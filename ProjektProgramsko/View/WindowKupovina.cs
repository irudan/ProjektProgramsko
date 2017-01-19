using System;
using System.Collections.Generic;
using Gtk;
namespace ProjektProgramsko
{


	public partial class WindowKupovina : Gtk.Window
	{
		
		public VBox boxkupovina = new VBox();

		public WidgetKartica kartica = new WidgetKartica();
		public WidgetPayPal paypal = new WidgetPayPal();


		public VBox vboxKupovina()
		{
			return vbox5;
		}

		public RadioButton radioKartica()
		{
			return radiobuttonkartica;
		}

		public RadioButton radioPayPal()
		{
			return radiobuttonpaypal;
		}

		public WindowKupovina() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();


			boxkupovina = vboxKupovina();
			boxkupovina.Add(kartica);

			RadioButton radioK = radioKartica();
			RadioButton radioP = radioPayPal();

			radioK.Clicked += PrikaziKartica;
			radioP.Clicked += PrikaziPayPal;
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
	}
}


