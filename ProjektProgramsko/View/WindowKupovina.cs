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

		public Button Potvrdi()
		{
			return buttonPotvrdi;
			}

		public Button Odustani()
		{
			return buttonOdustani;
		}


			

		public WindowKupovina() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();


			boxkupovina = vboxKupovina();
			boxkupovina.Add(kartica);

			RadioButton radioK = radioKartica();
			RadioButton radioP = radioPayPal();


			Button bPotvrdi = Potvrdi();
			Button bOdustani = Odustani();

			bPotvrdi.Clicked += PotvrdiNaplata;
			bOdustani.Clicked += OdustaniNaplata;

			radioK.Clicked += PrikaziKartica;
			radioP.Clicked += PrikaziPayPal;
		}

		protected void PotvrdiNaplata(object seneder, EventArgs a, ButtonsType b)
		{
			Dialog d = new MessageDialog(this, DialogFlags.Modal,
			                             MessageType.Question, 
			                             ButtonsType.OkCancel, "Želiš li potvrditi kupnju?");
			d.Run();

			d.Destroy();
		}

		protected void OdustaniNaplata(object seneder, EventArgs a)
		{
			Dialog d = new MessageDialog(this, DialogFlags.Modal,
										 MessageType.Question,
										 ButtonsType.OkCancel, "Želiš li prekinuti kupnju?");
			d.Run();

			d.Destroy();
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


