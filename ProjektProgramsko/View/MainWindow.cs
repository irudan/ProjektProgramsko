using System;
using System.Collections.Generic;
using Gtk;
using Mono.Data.Sqlite;
using ProjektProgramsko;

public partial class MainWindow : Gtk.Window
{
	public WidgetPocetna pocetna;
	public WidgetKnjiga knjiga;
	public WidgetCasopis casopis;
	public WidgetFilm film;
	public WidgetDodavanjeSadrzaja dodavanjeSadrzaja;
	public WidgetUredivanjeSadrzaja uredivanjeSadrzaja;

	public WidgetKnjigaSort tempSort;
	public ComboBox comboBoxSort;

	public VBox glavniVbox;

	public List<WidgetKnjiga> listaKnjiga;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		glavniVbox = glavnimeni2.getVbox();
		pocetna = new WidgetPocetna();
		dodavanjeSadrzaja = new WidgetDodavanjeSadrzaja();
		tempSort = new WidgetKnjigaSort();
		uredivanjeSadrzaja = new WidgetUredivanjeSadrzaja();

		glavniVbox.Add(pocetna);

		//Button-i
		Button pocetnaButton = glavnimeni2.getPocetna();
		Button knjigaButton = glavnimeni2.getKnjige();
		Button casopisButton = glavnimeni2.getCasopis();
		Button filmButton = glavnimeni2.getFilm();

		Button dodavanjeButton = glavnimeni2.getDodavanje();
		Button uredivanjeButton = glavnimeni2.getUredivanje();

		RadioButton radioK = dodavanjeSadrzaja.radioKnjiga();
		RadioButton radioC = dodavanjeSadrzaja.radioCasopis();
		RadioButton radioF = dodavanjeSadrzaja.radioFilm();
		RadioButton radioI = dodavanjeSadrzaja.radioIzdanje();

		RadioButton radioKU = uredivanjeSadrzaja.radioKnjiga();
		RadioButton radioCU = uredivanjeSadrzaja.radioCasopis();
		RadioButton radioFU = uredivanjeSadrzaja.radioFilm();
		RadioButton radioIU = uredivanjeSadrzaja.radioIzdanje();
		RadioButton radioAU = uredivanjeSadrzaja.radioAutor();


		comboBoxSort = tempSort.getComboBox();

		pocetnaButton.Clicked += prikaziPocetna;
		knjigaButton.Clicked += prikaziKnjige;
		casopisButton.Clicked += prikaziCasopis;
		filmButton.Clicked += prikaziFilm;

		dodavanjeButton.Clicked += prikaziDodavanje;
		uredivanjeButton.Clicked += prikaziUredivanje;

		radioK.Clicked += prikaziDodavanjeKnjiga;
		radioC.Clicked += prikaziDodavanjeCasopis;
		radioF.Clicked += prikaziDodavanjeFilm;
		radioI.Clicked += prikaziDodavanjeIzdanje;

		radioKU.Clicked += prikaziUredivanjeKnjiga;
		radioCU.Clicked += prikaziUredivanjeCasopis;
		radioFU.Clicked += prikaziUredivanjeFilm;
		radioIU.Clicked += prikaziUredivanjeIzdanje;
		radioAU.Clicked += prikaziUredivanjeAutor;


		comboBoxSort.Changed += odabirSorta;

		Build();
	}

	protected void prikaziPocetna(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(pocetna);

		Build();
	}

	//Funkcija za prikaz knjige
	protected void prikaziKnjige(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(tempSort);

		List<Knjiga> temp = BPKnjiga.DohvatiSve();

		foreach (Knjiga i in temp)
		{
			knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);

			/*Button kupi = knjiga.getKupi();
			kupi.Clicked += test;*/
		}

		Build();
	}

	protected void test(object sender, EventArgs a)
	{
		Button temp = sender as Button;
		temp.Label = "ajmoo";
	}

	//Funkcija za prikaz casopisa
	protected void prikaziCasopis(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(tempSort);

		List<Casopis> temp = BPCasopis.DohvatiSve();

		foreach (Casopis i in temp)
		{
			foreach (var j in i.IzdanjeCasopis)
			{
				casopis = new WidgetCasopis(i, j);
				glavniVbox.Add(casopis);
			}
		}

		Build();
	}

	//Funkcija za prikaz filma
	protected void prikaziFilm(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(tempSort);

		List<Film> temp = BPFilm.DohvatiSve();

		foreach (Film i in temp)
		{
			film = new WidgetFilm(i);
			glavniVbox.Add(film);
		}

		Build();
	}

	//Funkcija za prikaz meni-a za dodavanje
	protected void prikaziDodavanje(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(dodavanjeSadrzaja);

		Build();
	}

	//Funkcija za prikaz meni-a za uredivanje
	protected void prikaziUredivanje(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(uredivanjeSadrzaja);

		Build();
	}

	//Funkcija za dodavanje knjige
	protected void prikaziDodavanjeKnjiga(object sender, EventArgs a)
	{
		WidgetDodavanjeKnjiga temp = new WidgetDodavanjeKnjiga();

		VBox radiobox = dodavanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za dodavanje casopisa
	protected void prikaziDodavanjeCasopis(object sender, EventArgs a)
	{
		WidgetDodavanjeCasopis temp = new WidgetDodavanjeCasopis();

		VBox radiobox = dodavanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za dodavanje filma
	protected void prikaziDodavanjeFilm(object sender, EventArgs a)
	{
		WidgetDodavanjeFilm temp = new WidgetDodavanjeFilm();

		VBox radiobox = dodavanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za dodavanje izdanja
	protected void prikaziDodavanjeIzdanje(object sender, EventArgs a)
	{
		WidgetDodavanjeIzdanje temp = new WidgetDodavanjeIzdanje();

		VBox radiobox = dodavanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za uredivanje knjige
	protected void prikaziUredivanjeKnjiga(object sender, EventArgs a)
	{
		WidgetUredivanjeKnjiga temp = new WidgetUredivanjeKnjiga();

		VBox radiobox = uredivanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za uredivanje casopisa
	protected void prikaziUredivanjeCasopis(object sender, EventArgs a)
	{
		WidgetUredivanjeCasopis temp = new WidgetUredivanjeCasopis();

		VBox radiobox = uredivanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za uredivanje filma
	protected void prikaziUredivanjeFilm(object sender, EventArgs a)
	{
		WidgetUredivanjeFilm temp = new WidgetUredivanjeFilm();

		VBox radiobox = uredivanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za uredivanje izdanja
	protected void prikaziUredivanjeIzdanje(object sender, EventArgs a)
	{
		WidgetUredivanjeIzdanje temp = new WidgetUredivanjeIzdanje();

		VBox radiobox = uredivanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	//Funkcija za uredivanje autora
	protected void prikaziUredivanjeAutor(object sender, EventArgs a)
	{
		WidgetUredivanjeAutora temp = new WidgetUredivanjeAutora();

		VBox radiobox = uredivanjeSadrzaja.radioBox();

		izbrisiDjecu(radiobox);

		radiobox.Add(temp);

		this.Build();
	}

	protected void odabirSorta(object sender, EventArgs a)
	{
		List<Knjiga> temp = BPKnjiga.DohvatiSve();

		sortirajKnjige(temp);

		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(tempSort);

		foreach (Knjiga i in temp)
		{
			knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);
		}

		Build();
	}

	//Funkcija za sortiranje knjiga
	protected void sortirajKnjige(List<Knjiga> lista)
	{
		if(comboBoxSort.ActiveText == "Abeceda (uzlazno)")
		   lista.Sort((x, y) => string.Compare(x.Naziv, y.Naziv));

		return;
	}

	protected void izbrisiDjecu(VBox box)
	{
		Widget[] temp = box.Children;

		foreach (var i in temp)
			box.Remove(i);
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	public MainWindow getId()
	{
		return this;
	}
}
