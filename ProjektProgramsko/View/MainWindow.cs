using System;
using System.Collections.Generic;
using Gtk;
using Mono.Data.Sqlite;
using System.Linq;
using ProjektProgramsko;

public partial class MainWindow : Gtk.Window
{
	public WidgetPocetna pocetna;
	public WidgetKnjiga knjiga;
	public WidgetCasopis casopis;
	public WidgetFilm film;
	public WidgetProfil profil;
	public WidgetDodavanjeSadrzaja dodavanjeSadrzaja;
	public WidgetUredivanjeSadrzaja uredivanjeSadrzaja;

	public WidgetSort knjigaSort = new WidgetSort();
	public WidgetSort filmSort = new WidgetSort();
	public WidgetSort casopisSort = new WidgetSort();

	public ComboBox knjigaCombo;
	public ComboBox casopisCombo;
	public ComboBox filmCombo;

	public ComboBox comboBoxSort;

	public VBox glavniVbox = new VBox();

	public List<WidgetKnjiga> listaKnjiga;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		glavniVbox = glavnimeni2.getVbox();
		pocetna = new WidgetPocetna();
		profil = new WidgetProfil();
		dodavanjeSadrzaja = new WidgetDodavanjeSadrzaja();
		uredivanjeSadrzaja = new WidgetUredivanjeSadrzaja();

		glavniVbox.Add(pocetna);

		//Button-i
		Button pocetnaButton = glavnimeni2.getPocetna();
		Button knjigaButton = glavnimeni2.getKnjige();
		Button casopisButton = glavnimeni2.getCasopis();
		Button filmButton = glavnimeni2.getFilm();
		Button profilButton = glavnimeni2.getProfil();
		Button prijavaButton = glavnimeni2.getPrijava();

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


		ComboBox knjigaCombo = knjigaSort.getComboBox();
		ComboBox casopisCombo = casopisSort.getComboBox();
		ComboBox filmCombo = filmSort.getComboBox();

		pocetnaButton.Clicked += prikaziPocetna;
		knjigaButton.Clicked += prikaziKnjige;
		casopisButton.Clicked += prikaziCasopis;
		filmButton.Clicked += prikaziFilm;
		profilButton.Clicked += prikaziProfil;
		prijavaButton.Clicked += prikaziPrijava;

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


		knjigaCombo.Changed += sortKnjiga;
		casopisCombo.Changed += sortCasopis;
		filmCombo.Changed += sortFilm;

		Build();
	}

	protected void prikaziPocetna(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(pocetna);

		Build();
	}

	protected void prikaziPrijava(object sender, EventArgs a)
	{
		var windowPrijava = new WindowPrijava();
	}



	//Funkcija za prikaz knjige
	protected void prikaziKnjige(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(knjigaSort);

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

		glavniVbox.Add(casopisSort);

		List<IzdanjeCasopis> temp = BPIzdanjeCasopis.DohvatiSve();

		foreach (IzdanjeCasopis i in temp)
		{
			Casopis c = BPCasopis.DohvatiCasopis(i.IdC);

			casopis = new WidgetCasopis(c, i);
			glavniVbox.Add(casopis);
		}

		Build();
	}

	//Funkcija za prikaz filma
	protected void prikaziFilm(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(filmSort);

		List<Film> temp = BPFilm.DohvatiSve();

		foreach (Film i in temp)
		{
			film = new WidgetFilm(i);
			glavniVbox.Add(film);
		}

		Build();
	}


	protected void prikaziProfil(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(profil);

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
	 //Funkcija za sortiranje knjiga
	protected void sortKnjiga(object sender, EventArgs a)
	{
		List<Knjiga> lista = new List<Knjiga>();

		ComboBox comboBoxSort = sender as ComboBox;

		switch (comboBoxSort.ActiveText)
		{
			case "Abeceda (uzlazno)":
				lista = BPKnjiga.DohvatiSort("naziv");
				break;
			case "Abeceda (silazno)":
				lista = BPKnjiga.DohvatiSort("naziv desc");
				break;
			case "Cijena (uzlazno)":
				lista = BPKnjiga.DohvatiSort("cijena");
				break;
			case "Cijena (silazno)":
				lista = BPKnjiga.DohvatiSort("cijena desc");
				break;
			case "Najprodavanije":
				lista = BPKnjiga.DohvatiSort("broj_prodanih");
				break;
			case "Najnovije":
				lista = BPKnjiga.DohvatiSort("id desc");
				break;
		}
		
		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(knjigaSort);

		foreach (Knjiga i in lista)
		{
			knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);

			/*Button kupi = knjiga.getKupi();
			kupi.Clicked += test;*/
		}

		Build();
	}

	protected void sortCasopis(object sender, EventArgs a)
	{
		List<IzdanjeCasopis> lista = new List<IzdanjeCasopis>();

		ComboBox comboBoxSort = sender as ComboBox;

		switch (comboBoxSort.ActiveText)
		{
			case "Abeceda (uzlazno)":
				lista = BPIzdanjeCasopis.DohvatiSort("sadrzaj.naziv");
				break;
			case "Abeceda (silazno)":
				lista = BPIzdanjeCasopis.DohvatiSort("sadrzaj.naziv desc");
				break;
			case "Cijena (uzlazno)":
				lista = BPIzdanjeCasopis.DohvatiSort("izdanje_casopis.cijena");
				break;
			case "Cijena (silazno)":
				lista = BPIzdanjeCasopis.DohvatiSort("izdanje_casopis.cijena desc");
				break;
			case "Najprodavanije":
				lista = BPIzdanjeCasopis.DohvatiSort("izdanje_casopis.broj_prodanih");
				break;
			case "Najnovije":
				lista = BPIzdanjeCasopis.DohvatiSort("izdanje_casopis.id desc");
				break;
		}

		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(casopisSort);

		foreach (IzdanjeCasopis i in lista)
		{
			Casopis c = BPCasopis.DohvatiCasopis(i.IdC);

			casopis = new WidgetCasopis(c, i);
			glavniVbox.Add(casopis);
		}

		Build();
	}

	protected void sortFilm(object sender, EventArgs a)
	{
		List<Film> lista = new List<Film>();

		ComboBox comboBoxSort = sender as ComboBox;

		switch (comboBoxSort.ActiveText)
		{
			case "Abeceda (uzlazno)":
				lista = BPFilm.DohvatiSort("naziv");
				break;
			case "Abeceda (silazno)":
				lista = BPFilm.DohvatiSort("naziv desc");
				break;
			case "Cijena (uzlazno)":
				lista = BPFilm.DohvatiSort("cijena");
				break;
			case "Cijena (silazno)":
				lista = BPFilm.DohvatiSort("cijena desc");
				break;
			case "Najprodavanije":
				lista = BPFilm.DohvatiSort("broj_prodanih");
				break;
			case "Najnovije":
				lista = BPFilm.DohvatiSort("id desc");
				break;
		}

		izbrisiDjecu(glavniVbox);

		glavniVbox.Add(filmSort);

		foreach (Film i in lista)
		{
			film = new WidgetFilm(i);
			glavniVbox.Add(film);

			/*Button kupi = knjiga.getKupi();
			kupi.Clicked += test;*/
		}

		Build();
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
