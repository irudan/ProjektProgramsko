
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WindowUredivanjeFilm
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox11;

		private global::Gtk.VBox vbox12;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.Label label8;

		private global::Gtk.VBox vboxEntry;

		private global::Gtk.Entry entryNaziv;

		private global::Gtk.Entry entryOpis;

		private global::Gtk.Entry entryRedatelj;

		private global::Gtk.Entry entryGodina;

		private global::Gtk.Entry entryTrajanje;

		private global::Gtk.Entry entryCijena;

		private global::Gtk.Entry entryTagovi;

		private global::Gtk.HBox hbox1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label9;

		private global::Gtk.FileChooserButton filechooserbuttonSlika;

		private global::Gtk.Label label10;

		private global::Gtk.FileChooserButton filechooserbuttonVideo;

		private global::Gtk.HBox hbox7;

		private global::Gtk.Button buttonSpremi;

		private global::Gtk.Button buttonOdustani;

		private global::Gtk.Fixed fixed1;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WindowUredivanjeFilm
			this.Name = "ProjektProgramsko.WindowUredivanjeFilm";
			this.Title = global::Mono.Unix.Catalog.GetString("WindowUredivanjeFilm");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(10));
			// Container child ProjektProgramsko.WindowUredivanjeFilm.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vbox12 = new global::Gtk.VBox();
			this.vbox12.Name = "vbox12";
			this.vbox12.Spacing = 6;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Naziv:");
			this.vbox12.Add(this.label2);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label2]));
			w1.Position = 0;
			w1.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Opis:");
			this.vbox12.Add(this.label3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label3]));
			w2.Position = 1;
			w2.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Redatelj:");
			this.vbox12.Add(this.label4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label4]));
			w3.Position = 2;
			w3.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Godina:");
			this.vbox12.Add(this.label5);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label5]));
			w4.Position = 3;
			w4.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Trajanje:");
			this.vbox12.Add(this.label6);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label6]));
			w5.Position = 4;
			w5.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Cijena:");
			this.vbox12.Add(this.label7);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label7]));
			w6.Position = 5;
			w6.Fill = false;
			// Container child vbox12.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label();
			this.label8.Name = "label8";
			this.label8.Xalign = 1F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("Tagovi");
			this.vbox12.Add(this.label8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox12[this.label8]));
			w7.Position = 6;
			w7.Fill = false;
			this.hbox11.Add(this.vbox12);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.vbox12]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
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
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryNaziv]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryOpis = new global::Gtk.Entry();
			this.entryOpis.CanFocus = true;
			this.entryOpis.Name = "entryOpis";
			this.entryOpis.IsEditable = true;
			this.entryOpis.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryOpis);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryOpis]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryRedatelj = new global::Gtk.Entry();
			this.entryRedatelj.CanFocus = true;
			this.entryRedatelj.Name = "entryRedatelj";
			this.entryRedatelj.IsEditable = true;
			this.entryRedatelj.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryRedatelj);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryRedatelj]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryGodina = new global::Gtk.Entry();
			this.entryGodina.CanFocus = true;
			this.entryGodina.Name = "entryGodina";
			this.entryGodina.IsEditable = true;
			this.entryGodina.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryGodina);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryGodina]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryTrajanje = new global::Gtk.Entry();
			this.entryTrajanje.CanFocus = true;
			this.entryTrajanje.Name = "entryTrajanje";
			this.entryTrajanje.IsEditable = true;
			this.entryTrajanje.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryTrajanje);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryTrajanje]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryCijena = new global::Gtk.Entry();
			this.entryCijena.CanFocus = true;
			this.entryCijena.Name = "entryCijena";
			this.entryCijena.IsEditable = true;
			this.entryCijena.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryCijena);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryCijena]));
			w14.Position = 5;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vboxEntry.Gtk.Box+BoxChild
			this.entryTagovi = new global::Gtk.Entry();
			this.entryTagovi.CanFocus = true;
			this.entryTagovi.Name = "entryTagovi";
			this.entryTagovi.IsEditable = true;
			this.entryTagovi.InvisibleChar = '●';
			this.vboxEntry.Add(this.entryTagovi);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vboxEntry[this.entryTagovi]));
			w15.Position = 6;
			w15.Expand = false;
			w15.Fill = false;
			this.hbox11.Add(this.vboxEntry);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.vboxEntry]));
			w16.Position = 1;
			this.vbox3.Add(this.hbox11);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox11]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString("Slika:");
			this.hbox2.Add(this.label9);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label9]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.filechooserbuttonSlika = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select a File"), ((global::Gtk.FileChooserAction)(0)));
			this.filechooserbuttonSlika.Name = "filechooserbuttonSlika";
			this.hbox2.Add(this.filechooserbuttonSlika);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.filechooserbuttonSlika]));
			w19.Position = 1;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Pdf:");
			this.hbox2.Add(this.label10);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label10]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.filechooserbuttonVideo = new global::Gtk.FileChooserButton(global::Mono.Unix.Catalog.GetString("Select a File"), ((global::Gtk.FileChooserAction)(0)));
			this.filechooserbuttonVideo.Name = "filechooserbuttonVideo";
			this.hbox2.Add(this.filechooserbuttonVideo);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.filechooserbuttonVideo]));
			w21.Position = 3;
			this.hbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.hbox2]));
			w22.Position = 0;
			this.vbox3.Add(this.hbox1);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
			w23.Position = 1;
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
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbox7.Add(this.buttonOdustani);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.buttonOdustani]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox7.Add(this.fixed1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.fixed1]));
			w26.Position = 2;
			this.vbox3.Add(this.hbox7);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox7]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.Add(this.vbox3);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 326;
			this.DefaultHeight = 363;
			this.Show();
		}
	}
}
