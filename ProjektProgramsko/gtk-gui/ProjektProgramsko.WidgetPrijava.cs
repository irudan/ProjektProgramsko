
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetPrijava
	{
		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Button button1;

		private global::Gtk.VBox vbox3;

		private global::Gtk.Entry entry1;

		private global::Gtk.Entry entry2;

		private global::Gtk.Button button2;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetPrijava
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetPrijava";
			// Container child ProjektProgramsko.WidgetPrijava.Gtk.Container+ContainerChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("label1");
			this.vbox4.Add(this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label1]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("label2");
			this.vbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label2]));
			w2.Position = 1;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
			this.vbox4.Add(this.button1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.button1]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.hbox2.Add(this.vbox4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.vbox3.Add(this.entry1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.entry1]));
			w5.Position = 0;
			w5.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.entry2 = new global::Gtk.Entry();
			this.entry2.CanFocus = true;
			this.entry2.Name = "entry2";
			this.entry2.IsEditable = true;
			this.entry2.InvisibleChar = '●';
			this.vbox3.Add(this.entry2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.entry2]));
			w6.Position = 1;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.button2 = new global::Gtk.Button();
			this.button2.CanFocus = true;
			this.button2.Name = "button2";
			this.button2.UseUnderline = true;
			this.button2.Label = global::Mono.Unix.Catalog.GetString("GtkButton");
			this.vbox3.Add(this.button2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.button2]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.hbox2.Add(this.vbox3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox3]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			this.Add(this.hbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
