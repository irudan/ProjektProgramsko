
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetRegistracija
	{
		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Image imageRegistracija;

		private global::Gtk.FileChooserButton filechooserbuttonSlika;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entryIme;

		private global::Gtk.Label label2;

		private global::Gtk.Entry entryPrezime;

		private global::Gtk.Label label3;

		private global::Gtk.Entry entryKorisnickoIme;

		private global::Gtk.Label label4;

		private global::Gtk.Entry entryEmail;

		private global::Gtk.Label label5;

		private global::Gtk.Entry entryLozinka;

		private global::Gtk.Label label6;

		private global::Gtk.Entry entryPotvrdiLozinku;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Button buttonOdustani;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetRegistracija
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetRegistracija";
			// Container child ProjektProgramsko.WidgetRegistracija.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			this.hbox1.BorderWidth = ((uint)(10));
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.imageRegistracija = new global::Gtk.Image();
			this.imageRegistracija.WidthRequest = 150;
			this.imageRegistracija.HeightRequest = 150;
			this.imageRegistracija.Name = "imageRegistracija";
			this.vbox2.Add(this.imageRegistracija);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.imageRegistracija]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.filechooserbuttonSlika = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select a File"), ((global::Gtk.FileChooserAction)(0)));
			this.filechooserbuttonSlika.Name = "filechooserbuttonSlika";
			this.vbox2.Add(this.filechooserbuttonSlika);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.filechooserbuttonSlika]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Ime:");
			this.vbox1.Add(this.label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryIme = new global::Gtk.Entry();
			this.entryIme.CanFocus = true;
			this.entryIme.Name = "entryIme";
			this.entryIme.IsEditable = true;
			this.entryIme.InvisibleChar = '●';
			this.vbox1.Add(this.entryIme);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryIme]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Prezime:");
			this.vbox1.Add(this.label2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label2]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryPrezime = new global::Gtk.Entry();
			this.entryPrezime.CanFocus = true;
			this.entryPrezime.Name = "entryPrezime";
			this.entryPrezime.IsEditable = true;
			this.entryPrezime.InvisibleChar = '●';
			this.vbox1.Add(this.entryPrezime);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryPrezime]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Korisničko ime:");
			this.vbox1.Add(this.label3);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label3]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryKorisnickoIme = new global::Gtk.Entry();
			this.entryKorisnickoIme.CanFocus = true;
			this.entryKorisnickoIme.Name = "entryKorisnickoIme";
			this.entryKorisnickoIme.IsEditable = true;
			this.entryKorisnickoIme.InvisibleChar = '●';
			this.vbox1.Add(this.entryKorisnickoIme);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryKorisnickoIme]));
			w9.Position = 5;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("e-mail");
			this.vbox1.Add(this.label4);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label4]));
			w10.Position = 6;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryEmail = new global::Gtk.Entry();
			this.entryEmail.CanFocus = true;
			this.entryEmail.Name = "entryEmail";
			this.entryEmail.IsEditable = true;
			this.entryEmail.InvisibleChar = '●';
			this.vbox1.Add(this.entryEmail);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryEmail]));
			w11.Position = 7;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Lozinka");
			this.vbox1.Add(this.label5);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label5]));
			w12.Position = 8;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryLozinka = new global::Gtk.Entry();
			this.entryLozinka.CanFocus = true;
			this.entryLozinka.Name = "entryLozinka";
			this.entryLozinka.IsEditable = true;
			this.entryLozinka.InvisibleChar = '●';
			this.vbox1.Add(this.entryLozinka);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryLozinka]));
			w13.Position = 9;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Potvrdi Lozinku");
			this.vbox1.Add(this.label6);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.label6]));
			w14.Position = 10;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryPotvrdiLozinku = new global::Gtk.Entry();
			this.entryPotvrdiLozinku.CanFocus = true;
			this.entryPotvrdiLozinku.Name = "entryPotvrdiLozinku";
			this.entryPotvrdiLozinku.IsEditable = true;
			this.entryPotvrdiLozinku.InvisibleChar = '●';
			this.vbox1.Add(this.entryPotvrdiLozinku);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryPotvrdiLozinku]));
			w15.Position = 11;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonSpremi = new global::Gtk.Button();
			this.buttonSpremi.WidthRequest = 75;
			this.buttonSpremi.CanFocus = true;
			this.buttonSpremi.Name = "buttonSpremi";
			this.buttonSpremi.UseUnderline = true;
			this.buttonSpremi.Label = global::Mono.Unix.Catalog.GetString("Spremi");
			this.hbox3.Add(this.buttonSpremi);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonSpremi]));
			w16.Position = 0;
			w16.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.WidthRequest = 75;
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox3.Add(this.buttonOdustani);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.buttonOdustani]));
			w17.Position = 1;
			w17.Fill = false;
			this.vbox1.Add(this.hbox3);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox3]));
			w18.Position = 12;
			w18.Expand = false;
			w18.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w19.Position = 1;
			w19.Expand = false;
			w19.Fill = false;
			this.Add(this.hbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
