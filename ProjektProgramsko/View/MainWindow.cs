using System;
using System.Collections.Generic;
using Gtk;
using ProjektProgramsko;

public partial class MainWindow : Gtk.Window
{
	public WidgetPocetna pocetna;
	public WidgetProfil profil;
	public WidgetDodavanjeSadrzaja dodavanjeSadrzaja;
	public WidgetUredivanjeSadrzaja uredivanjeSadrzaja;

	public WidgetSortKnjige knjigaSort = new WidgetSortKnjige();
	public WidgetSortFilmovi filmSort = new WidgetSortFilmovi();
	public WidgetSortCasopis casopisSort = new WidgetSortCasopis();

	public WidgetMojSadrzaj mojSadrzaj = new WidgetMojSadrzaj();

	public VBox glavniVbox = new VBox();
	public VBox sortVbox = new VBox();

	public Button profilButton;
	public Button prijavaButton;
	public Button dodavanjeButton;
	public Button uredivanjeButton;
	public Button sadrzajButton;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		glavniVbox = glavnimeni2.getVbox();
		sortVbox = glavnimeni2.getSortBox();

		pocetna = new WidgetPocetna();
		dodavanjeSadrzaja = new WidgetDodavanjeSadrzaja();
		uredivanjeSadrzaja = new WidgetUredivanjeSadrzaja();

		glavniVbox.Add(pocetna);

		//Button-i
		Button pocetnaButton = glavnimeni2.getPocetna();
		Button knjigaButton = glavnimeni2.getKnjige();
		Button casopisButton = glavnimeni2.getCasopis();
		Button filmButton = glavnimeni2.getFilm();

		profilButton = glavnimeni2.getProfil();
		prijavaButton = glavnimeni2.getPrijava();
		dodavanjeButton = glavnimeni2.getDodavanje();
		uredivanjeButton = glavnimeni2.getUredivanje();
		sadrzajButton = glavnimeni2.getSadrzaj();

		RadioButton radioK = dodavanjeSadrzaja.radioKnjiga();
		RadioButton radioC = dodavanjeSadrzaja.radioCasopis();
		RadioButton radioF = dodavanjeSadrzaja.radioFilm();
		RadioButton radioI = dodavanjeSadrzaja.radioIzdanje();

		RadioButton radioKU = uredivanjeSadrzaja.radioKnjiga();
		RadioButton radioCU = uredivanjeSadrzaja.radioCasopis();
		RadioButton radioFU = uredivanjeSadrzaja.radioFilm();
		RadioButton radioIU = uredivanjeSadrzaja.radioIzdanje();
		RadioButton radioAU = uredivanjeSadrzaja.radioAutor();


		ComboBox knjigaCombo = knjigaSort.getSort();
		ComboBox casopisCombo = casopisSort.getSort();
		ComboBox filmCombo = filmSort.getSort();

		ComboBox knjigaTag = knjigaSort.getTag();
		ComboBox casopisTag = casopisSort.getTag();
		ComboBox filmTag = filmSort.getTag();

		Entry knjigaPretraga = knjigaSort.getPretraga();
		Entry casopisPretraga = casopisSort.getPretraga();
		Entry filmPretraga = filmSort.getPretraga();

		pocetnaButton.Clicked += prikaziPocetna;
		knjigaButton.Clicked += prikaziKnjige;
		casopisButton.Clicked += prikaziCasopis;
		filmButton.Clicked += prikaziFilm;
		profilButton.Clicked += prikaziProfil;
		prijavaButton.Clicked += prikaziPrijava;

		dodavanjeButton.Clicked += prikaziDodavanje;
		uredivanjeButton.Clicked += prikaziUredivanje;

		sadrzajButton.Clicked += prikaziMojSadrzaj;

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

		knjigaTag.Changed += tagKnjiga;
		casopisTag.Changed += tagCasopis;
		filmTag.Changed += tagFilm;

		knjigaPretraga.TextDeleted += pretragaKnjiga;
		knjigaPretraga.TextInserted += pretragaKnjiga;

		casopisPretraga.TextDeleted += pretragaCasopis;
		casopisPretraga.TextInserted += pretragaCasopis;

		filmPretraga.TextDeleted += pretragaFilm;
		filmPretraga.TextInserted += pretragaFilm;

		Build();

		/*MyGlobals.trenutni.Id = 9;
		MyGlobals.trenutni.Username = "admin";*/

		provjeraKorisnik();
	}
	protected void prikaziPocetna(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		glavniVbox.Add(pocetna);

		Build();

		provjeraKorisnik();
	}

	protected void prikaziPrijava(object sender, EventArgs a)	
	{
		Button temp = sender as Button;

		if (temp.Label == "Odjavi se")
		{
			MyGlobals.trenutni = new Korisnik();
			temp.Label = "Prijavi se";
			provjeraKorisnik();
			return;
		}

		var windowPrijavljivanje = new WindowPrijavljivanje();

		windowPrijavljivanje.Destroyed += pozivProvjera;
	}

	protected void pozivProvjera(object sender, EventArgs a)
	{
		provjeraKorisnik();
	}

	//Funkcija za prikaz knjige
	protected void prikaziKnjige(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		sortVbox.Add(knjigaSort);

		knjigaSort.postaviPrazno();

		List<Knjiga> temp = BPKnjiga.DohvatiSve();

		foreach (Knjiga i in temp)
		{
			WidgetKnjiga knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);
		}

		Build();

		provjeraKorisnik();
	}

	//Funkcija za prikaz casopisa
	protected void prikaziCasopis(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		sortVbox.Add(casopisSort);

		casopisSort.postaviPrazno();

		List<IzdanjeCasopis> temp = BPIzdanjeCasopis.DohvatiSve();

		foreach (IzdanjeCasopis i in temp)
		{
			Casopis c = BPCasopis.DohvatiCasopis(i.IdC);

			WidgetCasopis casopis = new WidgetCasopis(c, i);
			glavniVbox.Add(casopis);
		}

		Build();

		provjeraKorisnik();
	}

	//Funkcija za prikaz filma
	protected void prikaziFilm(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		sortVbox.Add(filmSort);

		filmSort.postaviPrazno();

		List<Film> temp = BPFilm.DohvatiSve();

		foreach (Film i in temp)
		{
			WidgetFilm film = new WidgetFilm(i);
			glavniVbox.Add(film);
		}

		Build();

		provjeraKorisnik();
	}


	protected void prikaziProfil(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		profil = new WidgetProfil();

		glavniVbox.Add(profil);

		Build();

		provjeraKorisnik();
	}

	//Funkcija za prikaz meni-a za dodavanje
	protected void prikaziDodavanje(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		glavniVbox.Add(dodavanjeSadrzaja);

		Build();
	}

	//Funkcija za prikaz meni-a za uredivanje
	protected void prikaziUredivanje(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		glavniVbox.Add(uredivanjeSadrzaja);

		Build();
	}

	protected void prikaziMojSadrzaj(object sender, EventArgs a)
	{
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		glavniVbox.Add(mojSadrzaj);

		Build();

		provjeraKorisnik();
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
			default:
				lista = BPKnjiga.DohvatiSve();
				break;
		}
		
		izbrisiDjecu(glavniVbox);
		izbrisiDjecu(sortVbox);

		sortVbox.Add(knjigaSort);

		foreach (Knjiga i in lista)
		{
			WidgetKnjiga knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);
		}

		Build();

		provjeraKorisnik();
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
		izbrisiDjecu(sortVbox);

		sortVbox.Add(casopisSort);

		foreach (IzdanjeCasopis i in lista)
		{
			Casopis c = BPCasopis.DohvatiCasopis(i.IdC);

			WidgetCasopis casopis = new WidgetCasopis(c, i);
			glavniVbox.Add(casopis);
		}

		Build();

		provjeraKorisnik();
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
		izbrisiDjecu(sortVbox);

		sortVbox.Add(filmSort);

		foreach (Film i in lista)
		{
			WidgetFilm film = new WidgetFilm(i);
			glavniVbox.Add(film);
		}

		Build();

		provjeraKorisnik();
	}

	protected void tagKnjiga(object sender, EventArgs a)
	{
		List<Knjiga> lista = new List<Knjiga>();

		ComboBox comboBoxSort = sender as ComboBox;

		lista = BPKnjiga.DohvatiTag(comboBoxSort.ActiveText);

		izbrisiDjecu(glavniVbox);

		sortVbox.Add(knjigaSort);

		foreach (Knjiga i in lista)
		{
			WidgetKnjiga knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);
		}

		Build();

		provjeraKorisnik();
	}

	protected void tagCasopis(object sender, EventArgs a)
	{
		List<IzdanjeCasopis> lista = new List<IzdanjeCasopis>();

		ComboBox comboBoxSort = sender as ComboBox;

		lista = BPIzdanjeCasopis.DohvatiTag(comboBoxSort.ActiveText);

		izbrisiDjecu(glavniVbox);

		sortVbox.Add(casopisSort);

		foreach (IzdanjeCasopis i in lista)
		{
			Casopis c = BPCasopis.DohvatiCasopis(i.IdC);

			WidgetCasopis casopis = new WidgetCasopis(c, i);
			glavniVbox.Add(casopis);
		}

		Build();

		provjeraKorisnik();
	}

	protected void tagFilm(object sender, EventArgs a)
	{
		List<Film> lista = new List<Film>();

		ComboBox comboBoxSort = sender as ComboBox;

		lista = BPFilm.DohvatiTag(comboBoxSort.ActiveText);

		izbrisiDjecu(glavniVbox);

		sortVbox.Add(filmSort);

		foreach (Film i in lista)
		{
			WidgetFilm film = new WidgetFilm(i);
			glavniVbox.Add(film);
		}

		Build();

		provjeraKorisnik();
	}

	protected void pretragaKnjiga(object sender, EventArgs a)
	{
		List<Knjiga> lista = new List<Knjiga>();

		Entry entry = sender as Entry;

		lista = BPKnjiga.Pretraga(entry.Text);

		izbrisiDjecu(glavniVbox);

		//glavniVbox.Add(knjigaSort);
		sortVbox.Add(knjigaSort);

		foreach (Knjiga i in lista)
		{
			WidgetKnjiga knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);
		}

		Build();

		provjeraKorisnik();
	}

	protected void pretragaCasopis(object sender, EventArgs a)
	{
		List<IzdanjeCasopis> lista = new List<IzdanjeCasopis>();

		Entry entry = sender as Entry;

		lista = BPIzdanjeCasopis.Pretraga(entry.Text);

		izbrisiDjecu(glavniVbox);

		sortVbox.Add(casopisSort);

		foreach (IzdanjeCasopis i in lista)
		{
			Casopis c = BPCasopis.DohvatiCasopis(i.IdC);

			WidgetCasopis casopis = new WidgetCasopis(c, i);
			glavniVbox.Add(casopis);
		}

		Build();

		provjeraKorisnik();
	}

	protected void pretragaFilm(object sender, EventArgs a)
	{
		List<Film> lista = new List<Film>();

		Entry entry = sender as Entry;

		lista = BPFilm.Pretraga(entry.Text);

		izbrisiDjecu(glavniVbox);

		sortVbox.Add(filmSort);

		foreach (Film i in lista)
		{
			WidgetFilm film = new WidgetFilm(i);
			glavniVbox.Add(film);
		}

		Build();

		provjeraKorisnik();
	}

	protected void provjeraKorisnik()
	{
		//Skrivanje buttona
		if (MyGlobals.trenutni.Id == -1)
		{
			dodavanjeButton.Visible = false;
			uredivanjeButton.Visible = false;
			profilButton.Visible = false;
			sadrzajButton.Visible = false;
		}
		else if (MyGlobals.trenutni.Id != -1 && MyGlobals.trenutni.Username != "admin")
		{
			dodavanjeButton.Visible = false;
			uredivanjeButton.Visible = false;
			profilButton.Visible = true;
			sadrzajButton.Visible = true;
			prijavaButton.Label = "Odjavi se";
		}
		else 
		{
			dodavanjeButton.Visible = true;
			uredivanjeButton.Visible = true;
			profilButton.Visible = true;
			sadrzajButton.Visible = true;
			prijavaButton.Label = "Odjavi se";
		}
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
}
