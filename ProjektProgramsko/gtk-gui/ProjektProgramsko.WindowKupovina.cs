
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WindowKupovina
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.RadioButton radiobuttonkartica;

		private global::Gtk.RadioButton radiobuttonpaypal;

		private global::Gtk.VBox vbox5;

		private global::ProjektProgramsko.WidgetKartica widgetkartica2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WindowKupovina
			this.Name = "ProjektProgramsko.WindowKupovina";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowKupovina");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.AllowGrow = false;
			this.DefaultWidth = 200;
			this.DefaultHeight = 200;
			// Container child ProjektProgramsko.WindowKupovina.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.radiobuttonkartica = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Plaćanje karticom"));
			this.radiobuttonkartica.CanFocus = true;
			this.radiobuttonkartica.Name = "radiobuttonkartica";
			this.radiobuttonkartica.DrawIndicator = true;
			this.radiobuttonkartica.UseUnderline = true;
			this.radiobuttonkartica.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox2.Add(this.radiobuttonkartica);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.radiobuttonkartica]));
			w1.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.radiobuttonpaypal = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("PayPal"));
			this.radiobuttonpaypal.CanFocus = true;
			this.radiobuttonpaypal.Name = "radiobuttonpaypal";
			this.radiobuttonpaypal.DrawIndicator = true;
			this.radiobuttonpaypal.UseUnderline = true;
			this.radiobuttonpaypal.Group = this.radiobuttonkartica.Group;
			this.hbox2.Add(this.radiobuttonpaypal);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.radiobuttonpaypal]));
			w2.Position = 1;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.widgetkartica2 = new global::ProjektProgramsko.WidgetKartica();
			this.widgetkartica2.Events = ((global::Gdk.EventMask)(256));
			this.widgetkartica2.Name = "widgetkartica2";
			this.vbox5.Add(this.widgetkartica2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.widgetkartica2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox2.Add(this.vbox5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.vbox5]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Show();
			this.radiobuttonkartica.Clicked += new global::System.EventHandler(this.Kartica);
			this.radiobuttonpaypal.Clicked += new global::System.EventHandler(this.PayPal);
		}
	}
}
