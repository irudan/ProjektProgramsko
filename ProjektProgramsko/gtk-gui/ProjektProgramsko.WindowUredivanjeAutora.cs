
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WindowUredivanjeAutora
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox8;

		private global::Gtk.VBox vbox14;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.VBox vbox13;

		private global::Gtk.Entry entryIme;

		private global::Gtk.Entry entryPrezime;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Button buttonOdustani;

		private global::Gtk.Fixed fixed1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WindowUredivanjeAutora
			this.Name = "ProjektProgramsko.WindowUredivanjeAutora";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowUredivanjeAutora");
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Modal = true;
			this.BorderWidth = ((uint)(10));
			// Container child ProjektProgramsko.WindowUredivanjeAutora.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vbox14 = new global::Gtk.VBox();
			this.vbox14.Name = "vbox14";
			this.vbox14.Spacing = 6;
			// Container child vbox14.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Ime:");
			this.vbox14.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label2]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child vbox14.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Prezime:");
			this.vbox14.Add(this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox14[this.label3]));
			w2.Position = 1;
			w2.Fill = false;
			this.hbox8.Add(this.vbox14);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox14]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vbox13 = new global::Gtk.VBox();
			this.vbox13.Name = "vbox13";
			this.vbox13.Spacing = 6;
			// Container child vbox13.Gtk.Box+BoxChild
			this.entryIme = new global::Gtk.Entry();
			this.entryIme.CanFocus = true;
			this.entryIme.Name = "entryIme";
			this.entryIme.IsEditable = true;
			this.entryIme.InvisibleChar = '●';
			this.vbox13.Add(this.entryIme);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.entryIme]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox13.Gtk.Box+BoxChild
			this.entryPrezime = new global::Gtk.Entry();
			this.entryPrezime.CanFocus = true;
			this.entryPrezime.Name = "entryPrezime";
			this.entryPrezime.IsEditable = true;
			this.entryPrezime.InvisibleChar = '●';
			this.vbox13.Add(this.entryPrezime);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox13[this.entryPrezime]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.hbox8.Add(this.vbox13);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vbox13]));
			w6.Position = 1;
			this.vbox3.Add(this.hbox8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox8]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonSpremi = new global::Gtk.Button();
			this.buttonSpremi.CanFocus = true;
			this.buttonSpremi.Name = "buttonSpremi";
			this.buttonSpremi.UseUnderline = true;
			this.buttonSpremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox7.Add(this.buttonSpremi);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonSpremi]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			w8.Padding = ((uint)(5));
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox7.Add(this.buttonOdustani);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonOdustani]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox7.Add(this.fixed1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.fixed1]));
			w10.Position = 2;
			this.vbox3.Add(this.hbox7);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 303;
			this.DefaultHeight = 167;
			this.Show();
		}
	}
}
