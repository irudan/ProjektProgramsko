
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetDodavanjeSadrzaja
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hboxMain;

		private global::Gtk.RadioButton radiobuttonKnjiga;

		private global::Gtk.RadioButton radiobuttonCasopis;

		private global::Gtk.RadioButton radiobuttonFilm;

		private global::Gtk.VBox vbox4;

		private global::ProjektProgramsko.WidgetDodavanjeKnjiga widgetdodavanjeknjiga1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetDodavanjeSadrzaja
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetDodavanjeSadrzaja";
			// Container child ProjektProgramsko.WidgetDodavanjeSadrzaja.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hboxMain = new global::Gtk.HBox();
			this.hboxMain.Name = "hboxMain";
			this.hboxMain.Spacing = 6;
			// Container child hboxMain.Gtk.Box+BoxChild
			this.radiobuttonKnjiga = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Knjiga"));
			this.radiobuttonKnjiga.CanFocus = true;
			this.radiobuttonKnjiga.Name = "radiobuttonKnjiga";
			this.radiobuttonKnjiga.Active = true;
			this.radiobuttonKnjiga.DrawIndicator = true;
			this.radiobuttonKnjiga.UseUnderline = true;
			this.radiobuttonKnjiga.Group = new global::GLib.SList(global::System.IntPtr.Zero);
			this.hboxMain.Add(this.radiobuttonKnjiga);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hboxMain[this.radiobuttonKnjiga]));
			w1.Position = 0;
			// Container child hboxMain.Gtk.Box+BoxChild
			this.radiobuttonCasopis = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Časopis"));
			this.radiobuttonCasopis.CanFocus = true;
			this.radiobuttonCasopis.Name = "radiobuttonCasopis";
			this.radiobuttonCasopis.DrawIndicator = true;
			this.radiobuttonCasopis.UseUnderline = true;
			this.radiobuttonCasopis.Group = this.radiobuttonKnjiga.Group;
			this.hboxMain.Add(this.radiobuttonCasopis);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hboxMain[this.radiobuttonCasopis]));
			w2.Position = 1;
			// Container child hboxMain.Gtk.Box+BoxChild
			this.radiobuttonFilm = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Film"));
			this.radiobuttonFilm.CanFocus = true;
			this.radiobuttonFilm.Name = "radiobuttonFilm";
			this.radiobuttonFilm.DrawIndicator = true;
			this.radiobuttonFilm.UseUnderline = true;
			this.radiobuttonFilm.Group = this.radiobuttonKnjiga.Group;
			this.hboxMain.Add(this.radiobuttonFilm);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hboxMain[this.radiobuttonFilm]));
			w3.Position = 2;
			this.vbox1.Add(this.hboxMain);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hboxMain]));
			w4.Position = 0;
			w4.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.widgetdodavanjeknjiga1 = new global::ProjektProgramsko.WidgetDodavanjeKnjiga();
			this.widgetdodavanjeknjiga1.Events = ((global::Gdk.EventMask)(256));
			this.widgetdodavanjeknjiga1.Name = "widgetdodavanjeknjiga1";
			this.vbox4.Add(this.widgetdodavanjeknjiga1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.widgetdodavanjeknjiga1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			this.vbox1.Add(this.vbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox4]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
