
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetDodavanjeFilm
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entryNaziv;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entryOpis;

		private global::Gtk.HBox hbox5;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entryRedatelj;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Label label5;

		private global::Gtk.Entry entryGodina;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label6;

		private global::Gtk.Entry entryTrajanje;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Label label7;

		private global::Gtk.Entry entryCijena;

		private global::Gtk.HBox hbox10;

		private global::Gtk.Label label8;

		private global::Gtk.Entry entryTagovi;

		private global::Gtk.HBox hbox1;

		private global::Gtk.FileChooserButton filechooserbutton1;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Fixed fixed1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetDodavanjeFilm
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetDodavanjeFilm";
			// Container child ProjektProgramsko.WidgetDodavanjeFilm.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Naziv:");
			this.hbox3.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label2]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.entryNaziv = new global::Gtk.Entry();
			this.entryNaziv.CanFocus = true;
			this.entryNaziv.Name = "entryNaziv";
			this.entryNaziv.IsEditable = true;
			this.entryNaziv.InvisibleChar = '●';
			this.hbox3.Add(this.entryNaziv);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.entryNaziv]));
			w2.Position = 1;
			this.vbox3.Add(this.hbox3);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox3]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Opis:");
			this.hbox4.Add(this.label3);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label3]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.entryOpis = new global::Gtk.Entry();
			this.entryOpis.CanFocus = true;
			this.entryOpis.Name = "entryOpis";
			this.entryOpis.IsEditable = true;
			this.entryOpis.InvisibleChar = '●';
			this.hbox4.Add(this.entryOpis);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.entryOpis]));
			w5.Position = 1;
			this.vbox3.Add(this.hbox4);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Redatelj:");
			this.hbox5.Add(this.label4);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label4]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.entryRedatelj = new global::Gtk.Entry();
			this.entryRedatelj.CanFocus = true;
			this.entryRedatelj.Name = "entryRedatelj";
			this.entryRedatelj.IsEditable = true;
			this.entryRedatelj.InvisibleChar = '●';
			this.hbox5.Add(this.entryRedatelj);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.entryRedatelj]));
			w8.Position = 1;
			this.vbox3.Add(this.hbox5);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox5]));
			w9.Position = 2;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Godina:");
			this.hbox6.Add(this.label5);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label5]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.entryGodina = new global::Gtk.Entry();
			this.entryGodina.CanFocus = true;
			this.entryGodina.Name = "entryGodina";
			this.entryGodina.IsEditable = true;
			this.entryGodina.InvisibleChar = '●';
			this.hbox6.Add(this.entryGodina);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.entryGodina]));
			w11.Position = 1;
			this.vbox3.Add(this.hbox6);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox6]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Trajanje:");
			this.hbox8.Add(this.label6);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label6]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.entryTrajanje = new global::Gtk.Entry();
			this.entryTrajanje.CanFocus = true;
			this.entryTrajanje.Name = "entryTrajanje";
			this.entryTrajanje.IsEditable = true;
			this.entryTrajanje.InvisibleChar = '●';
			this.hbox8.Add(this.entryTrajanje);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.entryTrajanje]));
			w14.Position = 1;
			this.vbox3.Add(this.hbox8);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox8]));
			w15.Position = 4;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Cijena:");
			this.hbox9.Add(this.label7);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.label7]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.entryCijena = new global::Gtk.Entry();
			this.entryCijena.CanFocus = true;
			this.entryCijena.Name = "entryCijena";
			this.entryCijena.IsEditable = true;
			this.entryCijena.InvisibleChar = '●';
			this.hbox9.Add(this.entryCijena);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.entryCijena]));
			w17.Position = 1;
			this.vbox3.Add(this.hbox9);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox9]));
			w18.Position = 5;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox10 = new global::Gtk.HBox();
			this.hbox10.Name = "hbox10";
			this.hbox10.Spacing = 6;
			// Container child hbox10.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Tagovi");
			this.hbox10.Add(this.label8);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.label8]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox10.Gtk.Box+BoxChild
			this.entryTagovi = new global::Gtk.Entry();
			this.entryTagovi.CanFocus = true;
			this.entryTagovi.Name = "entryTagovi";
			this.entryTagovi.IsEditable = true;
			this.entryTagovi.InvisibleChar = '●';
			this.hbox10.Add(this.entryTagovi);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox10[this.entryTagovi]));
			w20.Position = 1;
			this.vbox3.Add(this.hbox10);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox10]));
			w21.Position = 6;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.filechooserbutton1 = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select a File"), ((global::Gtk.FileChooserAction)(0)));
			this.filechooserbutton1.Name = "filechooserbutton1";
			this.hbox1.Add(this.filechooserbutton1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.filechooserbutton1]));
			w22.Position = 0;
			this.vbox3.Add(this.hbox1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
			w23.Position = 7;
			w23.Expand = false;
			w23.Fill = false;
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
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonSpremi]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			w24.Padding = ((uint)(5));
			// Container child hbox7.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox7.Add(this.fixed1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.fixed1]));
			w25.Position = 1;
			this.vbox3.Add(this.hbox7);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
			w26.Position = 8;
			w26.Expand = false;
			w26.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}