
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WindowKupi
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.RadioButton radiobuttonKartica;

		private global::Gtk.RadioButton radiobuttonPayPal;

		private global::Gtk.VBox vboxMain;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WindowKupi
			this.Name = "ProjektProgramsko.WindowKupi";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowKupi");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.BorderWidth = ((uint)(10));
			// Container child ProjektProgramsko.WindowKupi.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radiobuttonKartica = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Plaćanje karticom"));
			this.radiobuttonKartica.CanFocus = true;
			this.radiobuttonKartica.Name = "radiobuttonKartica";
			this.radiobuttonKartica.DrawIndicator = true;
			this.radiobuttonKartica.UseUnderline = true;
			this.radiobuttonKartica.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hbox1.Add(this.radiobuttonKartica);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radiobuttonKartica]));
			w1.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.radiobuttonPayPal = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Plaćanje PayPal-om"));
			this.radiobuttonPayPal.CanFocus = true;
			this.radiobuttonPayPal.Name = "radiobuttonPayPal";
			this.radiobuttonPayPal.DrawIndicator = true;
			this.radiobuttonPayPal.UseUnderline = true;
			this.radiobuttonPayPal.Group = this.radiobuttonKartica.Group;
			this.hbox1.Add(this.radiobuttonPayPal);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.radiobuttonPayPal]));
			w2.Position = 1;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vboxMain = new global::Gtk.VBox();
			this.vboxMain.Name = "vboxMain";
			this.vboxMain.Spacing = 6;
			this.vbox1.Add(this.vboxMain);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vboxMain]));
			w4.Position = 1;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 338;
			this.DefaultHeight = 262;
			this.Show();
		}
	}
}
