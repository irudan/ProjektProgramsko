
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetSortKnjige
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label3;

		private global::Gtk.ComboBox comboboxSort;

		private global::Gtk.ComboBox comboboxTag;

		private global::Gtk.Label label4;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Entry entry1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetSortKnjige
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetSortKnjige";
			// Container child ProjektProgramsko.WidgetSortKnjige.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Sortiraj po:");
			this.hbox5.Add(this.label3);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label3]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.comboboxSort = global::Gtk.ComboBox.NewText();
			this.comboboxSort.AppendText(global::Mono.Unix.Catalog.GetString("Abeceda (uzlazno)"));
			this.comboboxSort.AppendText(global::Mono.Unix.Catalog.GetString("Abeceda (silazno)"));
			this.comboboxSort.AppendText(global::Mono.Unix.Catalog.GetString("Cijena (uzlazno)"));
			this.comboboxSort.AppendText(global::Mono.Unix.Catalog.GetString("Cijena (silazno)"));
			this.comboboxSort.AppendText(global::Mono.Unix.Catalog.GetString("Najprodavanije"));
			this.comboboxSort.AppendText(global::Mono.Unix.Catalog.GetString("Najnovije"));
			this.comboboxSort.Name = "comboboxSort";
			this.hbox5.Add(this.comboboxSort);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.comboboxSort]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.comboboxTag = global::Gtk.ComboBox.NewText();
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Roman"));
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Drama"));
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Triler"));
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Povijest"));
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Muzika"));
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Horor"));
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Sci-Fi"));
			this.comboboxTag.AppendText(global::Mono.Unix.Catalog.GetString("Biografija"));
			this.comboboxTag.Name = "comboboxTag";
			this.hbox5.Add(this.comboboxTag);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.comboboxTag]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Tagovi:");
			this.hbox5.Add(this.label4);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label4]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 3;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.hbox1.Add(this.entry1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.entry1]));
			w6.Position = 0;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
