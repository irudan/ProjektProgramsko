
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WindowUredivanjeCasopis
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox5;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label5;

		private global::Gtk.VBox vboxEntry;

		private global::Gtk.Entry entryNaziv;

		private global::Gtk.Entry entryOpis;

		private global::Gtk.Entry entryTagovi;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Button buttonOdustani;

		private global::Gtk.Fixed fixed1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WindowUredivanjeCasopis
			this.Name = "ProjektProgramsko.WindowUredivanjeCasopis";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowUredivanjeCasopis");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(10));
			// Container child ProjektProgramsko.WindowUredivanjeCasopis.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Naziv:");
			this.vbox5.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label2]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Opis:");
			this.vbox5.Add(this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label3]));
			w2.Position = 1;
			w2.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Tagovi");
			this.vbox5.Add(this.label5);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label5]));
			w3.Position = 2;
			w3.Fill = false;
			this.hbox2.Add(this.vbox5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox5]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vboxEntry = new global::Gtk.VBox();
			this.vboxEntry.Name = "vboxEntry";
			this.vboxEntry.Spacing = 6;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryNaziv = new global::Gtk.Entry();
			this.entryNaziv.CanFocus = true;
			this.entryNaziv.Name = "entryNaziv";
			this.entryNaziv.IsEditable = true;
			this.entryNaziv.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryNaziv);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryNaziv]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryOpis = new global::Gtk.Entry();
			this.entryOpis.CanFocus = true;
			this.entryOpis.Name = "entryOpis";
			this.entryOpis.IsEditable = true;
			this.entryOpis.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryOpis);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryOpis]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryTagovi = new global::Gtk.Entry();
			this.entryTagovi.CanFocus = true;
			this.entryTagovi.Name = "entryTagovi";
			this.entryTagovi.IsEditable = true;
			this.entryTagovi.MaxLength = 64;
			this.entryTagovi.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryTagovi);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryTagovi]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			this.hbox2.Add(this.vboxEntry);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vboxEntry]));
			w8.Position = 1;
			this.vbox3.Add(this.hbox2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
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
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonSpremi]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			w10.Padding = ((uint)(5));
			// Container child hbox7.Gtk.Box+BoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox7.Add(this.buttonOdustani);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonOdustani]));
			w11.Position = 1;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox7.Add(this.fixed1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.fixed1]));
			w12.Position = 2;
			this.vbox3.Add(this.hbox7);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 304;
			this.DefaultHeight = 196;
			this.Show();
		}
	}
}
