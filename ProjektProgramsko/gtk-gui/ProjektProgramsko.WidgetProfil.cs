
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetProfil
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Image imageprofil;

		private global::Gtk.FileChooserButton filechooserbutton1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entryprofilime;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entryprofilprezime;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entryprofilkorisnickoime;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entryprofilemail;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label5;

		private global::Gtk.Button buttonpromjenalozinke;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button buttonspremi;

		private global::Gtk.Button button4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetProfil
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetProfil";
			// Container child ProjektProgramsko.WidgetProfil.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(4));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.imageprofil = new global::Gtk.Image();
			this.imageprofil.WidthRequest = 150;
			this.imageprofil.HeightRequest = 150;
			this.imageprofil.Name = "imageprofil";
			this.vbox1.Add(this.imageprofil);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.imageprofil]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.filechooserbutton1 = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select a File"), ((global::Gtk.FileChooserAction)(0)));
			this.filechooserbutton1.Name = "filechooserbutton1";
			this.vbox1.Add(this.filechooserbutton1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.filechooserbutton1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Ypad = 7;
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Ime");
			this.vbox2.Add(this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			w4.Padding = ((uint)(10));
			// Container child vbox2.Gtk.Box+BoxChild
			this.entryprofilime = new global::Gtk.Entry();
			this.entryprofilime.CanFocus = true;
			this.entryprofilime.Name = "entryprofilime";
			this.entryprofilime.IsEditable = true;
			this.entryprofilime.InvisibleChar = '●';
			this.vbox2.Add(this.entryprofilime);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entryprofilime]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Prezime");
			this.vbox2.Add(this.label2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			w6.Padding = ((uint)(5));
			// Container child vbox2.Gtk.Box+BoxChild
			this.entryprofilprezime = new global::Gtk.Entry();
			this.entryprofilprezime.CanFocus = true;
			this.entryprofilprezime.Name = "entryprofilprezime";
			this.entryprofilprezime.IsEditable = true;
			this.entryprofilprezime.InvisibleChar = '●';
			this.vbox2.Add(this.entryprofilprezime);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entryprofilprezime]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Korisničko ime");
			this.vbox2.Add(this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label3]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			w8.Padding = ((uint)(5));
			// Container child vbox2.Gtk.Box+BoxChild
			this.entryprofilkorisnickoime = new global::Gtk.Entry();
			this.entryprofilkorisnickoime.CanFocus = true;
			this.entryprofilkorisnickoime.Name = "entryprofilkorisnickoime";
			this.entryprofilkorisnickoime.IsEditable = true;
			this.entryprofilkorisnickoime.InvisibleChar = '●';
			this.vbox2.Add(this.entryprofilkorisnickoime);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entryprofilkorisnickoime]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("e-mail");
			this.vbox2.Add(this.label4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label4]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.entryprofilemail = new global::Gtk.Entry();
			this.entryprofilemail.CanFocus = true;
			this.entryprofilemail.Name = "entryprofilemail";
			this.entryprofilemail.IsEditable = true;
			this.entryprofilemail.InvisibleChar = '●';
			this.vbox2.Add(this.entryprofilemail);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.entryprofilemail]));
			w11.Position = 7;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Lozinka");
			this.hbox4.Add(this.label5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label5]));
			w12.Position = 0;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.buttonpromjenalozinke = new global::Gtk.Button();
			this.buttonpromjenalozinke.WidthRequest = 150;
			this.buttonpromjenalozinke.CanFocus = true;
			this.buttonpromjenalozinke.Name = "buttonpromjenalozinke";
			this.buttonpromjenalozinke.UseUnderline = true;
			this.buttonpromjenalozinke.Label = global::Mono.Unix.Catalog.GetString("Promijeni Lozinku");
			this.hbox4.Add(this.buttonpromjenalozinke);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.buttonpromjenalozinke]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
			w14.Position = 8;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.buttonspremi = new global::Gtk.Button();
			this.buttonspremi.WidthRequest = 100;
			this.buttonspremi.CanFocus = true;
			this.buttonspremi.Name = "buttonspremi";
			this.buttonspremi.UseUnderline = true;
			this.buttonspremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox6.Add(this.buttonspremi);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.buttonspremi]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.button4 = new global::Gtk.Button();
			this.button4.WidthRequest = 100;
			this.button4.CanFocus = true;
			this.button4.Name = "button4";
			this.button4.UseUnderline = true;
			this.button4.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox6.Add(this.button4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.button4]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.vbox2.Add(this.hbox6);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox6]));
			w17.PackType = ((global::Gtk.PackType)(1));
			w17.Position = 9;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w18.Position = 1;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
