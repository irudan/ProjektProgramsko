
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetKartica
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox2;

		private global::Gtk.VBox vbox4;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.VBox vboxEntry;

		private global::Gtk.Entry entryBrKartice;

		private global::Gtk.Entry entryDatum;

		private global::Gtk.Entry entryIme;

		private global::Gtk.Entry entryPrezime;

		private global::Gtk.HButtonBox hbuttonbox1;

		private global::Gtk.Button buttonPotvrdi;

		private global::Gtk.Button buttonOdustani;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetKartica
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetKartica";
			// Container child ProjektProgramsko.WidgetKartica.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			this.vbox3.BorderWidth = ((uint)(10));
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Broj kartice:");
			this.vbox4.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label2]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Datum isteka:");
			this.vbox4.Add(this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label3]));
			w2.Position = 1;
			w2.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Ime vlasnika:");
			this.vbox4.Add(this.label4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label4]));
			w3.Position = 2;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Prezime vlasnika:");
			this.vbox4.Add(this.label5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label5]));
			w4.Position = 3;
			w4.Fill = false;
			this.hbox2.Add(this.vbox4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox4]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vboxEntry = new global::Gtk.VBox();
			this.vboxEntry.Name = "vboxEntry";
			this.vboxEntry.Spacing = 6;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryBrKartice = new global::Gtk.Entry();
			this.entryBrKartice.CanFocus = true;
			this.entryBrKartice.Name = "entryBrKartice";
			this.entryBrKartice.IsEditable = true;
			this.entryBrKartice.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryBrKartice);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryBrKartice]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryDatum = new global::Gtk.Entry();
			this.entryDatum.CanFocus = true;
			this.entryDatum.Name = "entryDatum";
			this.entryDatum.IsEditable = true;
			this.entryDatum.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryDatum);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryDatum]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryIme = new global::Gtk.Entry();
			this.entryIme.CanFocus = true;
			this.entryIme.Name = "entryIme";
			this.entryIme.IsEditable = true;
			this.entryIme.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryIme);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryIme]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryPrezime = new global::Gtk.Entry();
			this.entryPrezime.CanFocus = true;
			this.entryPrezime.Name = "entryPrezime";
			this.entryPrezime.IsEditable = true;
			this.entryPrezime.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryPrezime);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryPrezime]));
			w9.Position = 3;
			w9.Expand = false;
			w9.Fill = false;
			this.hbox2.Add(this.vboxEntry);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vboxEntry]));
			w10.Position = 1;
			this.vbox3.Add(this.hbox2);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox();
			this.hbuttonbox1.Name = "hbuttonbox1";
			this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPotvrdi = new global::Gtk.Button();
			this.buttonPotvrdi.CanFocus = true;
			this.buttonPotvrdi.Name = "buttonPotvrdi";
			this.buttonPotvrdi.UseUnderline = true;
			this.buttonPotvrdi.Label = global::Mono.Unix.Catalog.GetString("Potvrdi");
			this.hbuttonbox1.Add(this.buttonPotvrdi);
			global::Gtk.ButtonBox.ButtonBoxChild w12 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonPotvrdi]));
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbuttonbox1.Add(this.buttonOdustani);
			global::Gtk.ButtonBox.ButtonBoxChild w13 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonOdustani]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox3.Add(this.hbuttonbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbuttonbox1]));
			w14.PackType = ((global::Gtk.PackType)(1));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
