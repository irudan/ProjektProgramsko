
// This file has been generated by the GUI designer. Do not modify.
namespace ProjektProgramsko
{
	public partial class WidgetPayPal
	{
		private global::Gtk.VBox vbox4;

		private global::Gtk.HButtonBox hbuttonbox1;

		private global::Gtk.Button buttonPotvrdi;

		private global::Gtk.Button buttonOdustani;

		private global::Gtk.Fixed fixed1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VBox vbox2;

		private global::Gtk.Label label6;

		private global::Gtk.Label label7;

		private global::Gtk.VBox vbox1;

		private global::Gtk.Entry entryKorIme;

		private global::Gtk.Entry entryLozinka;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProjektProgramsko.WidgetPayPal
			global::Stetic.BinContainer.Attach(this);
			this.Name = "ProjektProgramsko.WidgetPayPal";
			// Container child ProjektProgramsko.WidgetPayPal.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox4.BorderWidth = ((uint)(10));
			// Container child vbox4.Gtk.Box+BoxChild
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
			global::Gtk.ButtonBox.ButtonBoxChild w1 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonPotvrdi]));
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOdustani = new global::Gtk.Button();
			this.buttonOdustani.CanFocus = true;
			this.buttonOdustani.Name = "buttonOdustani";
			this.buttonOdustani.UseUnderline = true;
			this.buttonOdustani.Label = global::Mono.Unix.Catalog.GetString("Odustani");
			this.hbuttonbox1.Add(this.buttonOdustani);
			global::Gtk.ButtonBox.ButtonBoxChild w2 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1[this.buttonOdustani]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox4.Add(this.hbuttonbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbuttonbox1]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.vbox4.Add(this.fixed1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.fixed1]));
			w4.PackType = ((global::Gtk.PackType)(1));
			w4.Position = 1;
			w4.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Korisničko ime:");
			this.vbox2.Add(this.label6);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label6]));
			w5.Position = 0;
			w5.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label();
			this.label7.Name = "label7";
			this.label7.Xalign = 1F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString("Lozinka");
			this.vbox2.Add(this.label7);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label7]));
			w6.Position = 1;
			w6.Fill = false;
			this.hbox1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox2]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryKorIme = new global::Gtk.Entry();
			this.entryKorIme.CanFocus = true;
			this.entryKorIme.Name = "entryKorIme";
			this.entryKorIme.IsEditable = true;
			this.entryKorIme.InvisibleChar = '●';
			this.vbox1.Add(this.entryKorIme);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryKorIme]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.entryLozinka = new global::Gtk.Entry();
			this.entryLozinka.CanFocus = true;
			this.entryLozinka.Name = "entryLozinka";
			this.entryLozinka.IsEditable = true;
			this.entryLozinka.Visibility = false;
			this.entryLozinka.InvisibleChar = '●';
			this.vbox1.Add(this.entryLozinka);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.entryLozinka]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			this.hbox1.Add(this.vbox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox1]));
			w10.Position = 1;
			this.vbox4.Add(this.hbox1);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
			w11.PackType = ((global::Gtk.PackType)(1));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.Add(this.vbox4);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
