
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetCasopis
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.Image image1;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Label labelNaslov;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label4;

		private global::Gtk.Label labelOpis;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label6;

		private global::Gtk.Label labelDatum;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label5;

		private global::Gtk.Label labelBrojIzdanja;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label7;

		private global::Gtk.Label labelCijena;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label9;

		private global::Gtk.Label labelTagovi;

		private global::Gtk.VButtonBox vbuttonbox1;

		private global::Gtk.Button button81;

		private global::Gtk.Button button82;

		private global::Gtk.Button button83;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetCasopis
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetCasopis";
			// Container child ProjektProgramsko.WidgetCasopis.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(10));
			// Container child hbox1.Gtk.Box+BoxChild
			this.image1 = new global::Gtk.Image();
			this.image1.Name = "image1";
			this.hbox1.Add(this.image1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.image1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelNaslov = new global::Gtk.Label();
			this.labelNaslov.Name = "labelNaslov";
			this.labelNaslov.Xalign = 0F;
			this.labelNaslov.LabelProp = global::Mono.Unix.Catalog.GetString("Naslov Casopisa");
			this.vbox1.Add(this.labelNaslov);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelNaslov]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Opis:");
			this.hbox3.Add(this.label4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label4]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.labelOpis = new global::Gtk.Label();
			this.labelOpis.Name = "labelOpis";
			this.labelOpis.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
			this.labelOpis.MaxWidthChars = 20;
			this.hbox3.Add(this.labelOpis);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.labelOpis]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Datum:");
			this.hbox4.Add(this.label6);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label6]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelDatum = new global::Gtk.Label();
			this.labelDatum.Name = "labelDatum";
			this.hbox4.Add(this.labelDatum);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.labelDatum]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			this.vbox1.Add(this.hbox4);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Broj izdanja:");
			this.hbox7.Add(this.label5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label5]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelBrojIzdanja = new global::Gtk.Label();
			this.labelBrojIzdanja.Name = "labelBrojIzdanja";
			this.labelBrojIzdanja.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
			this.labelBrojIzdanja.MaxWidthChars = 20;
			this.hbox7.Add(this.labelBrojIzdanja);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.labelBrojIzdanja]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox1.Add(this.hbox7);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox7]));
			w11.Position = 3;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Cijena:");
			this.hbox8.Add(this.label7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label7]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.labelCijena = new global::Gtk.Label();
			this.labelCijena.Name = "labelCijena";
			this.labelCijena.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
			this.labelCijena.MaxWidthChars = 20;
			this.hbox8.Add(this.labelCijena);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.labelCijena]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.hbox8);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox8]));
			w14.Position = 4;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Tagovi:");
			this.hbox6.Add(this.label9);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label9]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelTagovi = new global::Gtk.Label();
			this.labelTagovi.Name = "labelTagovi";
			this.labelTagovi.LabelProp = global::Mono.Unix.Catalog.GetString("label9");
			this.hbox6.Add(this.labelTagovi);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.labelTagovi]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w17.PackType = ((global::Gtk.PackType)(1));
			w17.Position = 5;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w18.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbuttonbox1 = new global::Gtk.VButtonBox();
			this.vbuttonbox1.Name = "vbuttonbox1";
			this.vbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button81 = new global::Gtk.Button();
			this.button81.CanFocus = true;
			this.button81.Name = "button81";
			this.button81.UseUnderline = true;
			this.button81.Label = global::Mono.Unix.Catalog.GetString("Kupi");
			this.vbuttonbox1.Add(this.button81);
			global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.button81]));
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button82 = new global::Gtk.Button();
			this.button82.CanFocus = true;
			this.button82.Name = "button82";
			this.button82.UseUnderline = true;
			this.button82.Label = global::Mono.Unix.Catalog.GetString("Preuzmi");
			this.vbuttonbox1.Add(this.button82);
			global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.button82]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.button83 = new global::Gtk.Button();
			this.button83.CanFocus = true;
			this.button83.Name = "button83";
			this.button83.UseUnderline = true;
			this.button83.Label = global::Mono.Unix.Catalog.GetString("Pregledaj");
			this.vbuttonbox1.Add(this.button83);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.button83]));
			w21.Position = 2;
			w21.Expand = false;
			w21.Fill = false;
			this.hbox1.Add(this.vbuttonbox1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbuttonbox1]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.button81.Clicked += new global::System.EventHandler(this.Kupi);
		}
	}
}
