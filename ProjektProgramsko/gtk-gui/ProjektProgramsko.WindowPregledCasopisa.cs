
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WindowPregledCasopisa
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.NodeView nodeview1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Button buttonOdustani;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WindowPregledCasopisa
			this.Name = "ProjektProgramsko.WindowPregledCasopisa";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowPregledCasopisa");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProjektProgramsko.WindowPregledCasopisa.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.nodeview1 = new global::Gtk.NodeView();
			this.nodeview1.CanFocus = true;
			this.nodeview1.Name = "nodeview1";
			this.GtkScrolledWindow.Add(this.nodeview1);
			this.vbox1.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonSpremi = new global::Gtk.Button();
			this.buttonSpremi.CanFocus = true;
			this.buttonSpremi.Name = "buttonSpremi";
			this.buttonSpremi.UseUnderline = true;
			this.buttonSpremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox2.Add(this.buttonSpremi);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonSpremi]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			w3.Padding = ((uint)(5));
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox2.Add(this.buttonOdustani);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.buttonOdustani]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w5.Position = 1;
			w5.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
		}
	}
}
