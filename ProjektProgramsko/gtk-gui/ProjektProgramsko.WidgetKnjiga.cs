
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetKnjiga
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

		private global::Gtk.Label labelAutori;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Label label5;

		private global::Gtk.Label labelBrojStranica;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label7;

		private global::Gtk.Label labelCijena;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label label10;

		private global::Gtk.Label labelNakladnik;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label9;

		private global::Gtk.Label labelTagovi;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label8;

		private global::Gtk.Label labelJezik;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.VButtonBox vbuttonbox1;

		private global::Gtk.Button buttonKupi;

		private global::Gtk.Button buttonPreuzmi;

		private global::Gtk.Button buttonPregledaj;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetKnjiga
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetKnjiga";
			// Container child ProjektProgramsko.WidgetKnjiga.Gtk.Container+ContainerChild
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
			this.vbox1.WidthRequest = 150;
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelNaslov = new global::Gtk.Label();
			this.labelNaslov.Name = "labelNaslov";
			this.labelNaslov.Xalign = 0F;
			this.labelNaslov.LabelProp = global::Mono.Unix.Catalog.GetString("Naslov knjige");
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
			this.labelOpis.MaxWidthChars = 60;
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
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Autori:");
			this.hbox4.Add(this.label6);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label6]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.labelAutori = new global::Gtk.Label();
			this.labelAutori.Name = "labelAutori";
			this.hbox4.Add(this.labelAutori);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.labelAutori]));
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
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Broj stranica:");
			this.hbox7.Add(this.label5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.label5]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.labelBrojStranica = new global::Gtk.Label();
			this.labelBrojStranica.Name = "labelBrojStranica";
			this.labelBrojStranica.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
			this.labelBrojStranica.MaxWidthChars = 20;
			this.hbox7.Add(this.labelBrojStranica);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.labelBrojStranica]));
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
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Nakladnik:");
			this.hbox9.Add(this.label10);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label10]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.labelNakladnik = new global::Gtk.Label();
			this.labelNakladnik.Name = "labelNakladnik";
			this.labelNakladnik.LabelProp = global::Mono.Unix.Catalog.GetString("label5");
			this.labelNakladnik.MaxWidthChars = 20;
			this.hbox9.Add(this.labelNakladnik);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.labelNakladnik]));
			w16.Position = 1;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox1.Add(this.hbox9);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox9]));
			w17.Position = 5;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Tagovi:");
			this.hbox6.Add(this.label9);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label9]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.labelTagovi = new global::Gtk.Label();
			this.labelTagovi.Name = "labelTagovi";
			this.labelTagovi.LabelProp = global::Mono.Unix.Catalog.GetString("label9");
			this.hbox6.Add(this.labelTagovi);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.labelTagovi]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox1.Add(this.hbox6);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
			w20.PackType = ((global::Gtk.PackType)(1));
			w20.Position = 6;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Jezik:");
			this.hbox5.Add(this.label8);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label8]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.labelJezik = new global::Gtk.Label();
			this.labelJezik.Name = "labelJezik";
			this.labelJezik.LabelProp = global::Mono.Unix.Catalog.GetString("label9");
			this.hbox5.Add(this.labelJezik);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.labelJezik]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox1.Add(this.hbox5);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
			w23.PackType = ((global::Gtk.PackType)(1));
			w23.Position = 7;
			w23.Expand = false;
			w23.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox1.Add(this.fixed1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.fixed1]));
			w25.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbuttonbox1 = new global::Gtk.VButtonBox();
			this.vbuttonbox1.Name = "vbuttonbox1";
			this.vbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonKupi = new global::Gtk.Button();
			this.buttonKupi.CanFocus = true;
			this.buttonKupi.Name = "buttonKupi";
			this.buttonKupi.UseUnderline = true;
			this.buttonKupi.Label = global::Mono.Unix.Catalog.GetString("Kupi");
			this.vbuttonbox1.Add(this.buttonKupi);
			global::Gtk.ButtonBox.ButtonBoxChild w26 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.buttonKupi]));
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPreuzmi = new global::Gtk.Button();
			this.buttonPreuzmi.CanFocus = true;
			this.buttonPreuzmi.Name = "buttonPreuzmi";
			this.buttonPreuzmi.UseUnderline = true;
			this.buttonPreuzmi.Label = global::Mono.Unix.Catalog.GetString("Preuzmi");
			this.vbuttonbox1.Add(this.buttonPreuzmi);
			global::Gtk.ButtonBox.ButtonBoxChild w27 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.buttonPreuzmi]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child vbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonPregledaj = new global::Gtk.Button();
			this.buttonPregledaj.CanFocus = true;
			this.buttonPregledaj.Name = "buttonPregledaj";
			this.buttonPregledaj.UseUnderline = true;
			this.buttonPregledaj.Label = global::Mono.Unix.Catalog.GetString("Pregledaj");
			this.vbuttonbox1.Add(this.buttonPregledaj);
			global::Gtk.ButtonBox.ButtonBoxChild w28 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.vbuttonbox1[this.buttonPregledaj]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox1.Add(this.vbuttonbox1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbuttonbox1]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
