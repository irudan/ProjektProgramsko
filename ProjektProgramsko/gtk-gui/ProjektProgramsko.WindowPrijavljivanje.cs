
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WindowPrijavljivanje
	{
		private global::Gtk.VBox vbox1;

		private global::ProjektProgramsko.WidgetPrijava widgetprijava1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WindowPrijavljivanje
			this.Name = "ProjektProgramsko.WindowPrijavljivanje";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowPrijavljivanje");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child ProjektProgramsko.WindowPrijavljivanje.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.widgetprijava1 = new global::ProjektProgramsko.WidgetPrijava();
			this.widgetprijava1.Events = ((global::Gdk.EventMask)(256));
			this.widgetprijava1.Name = "widgetprijava1";
			this.vbox1.Add(this.widgetprijava1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.widgetprijava1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
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
