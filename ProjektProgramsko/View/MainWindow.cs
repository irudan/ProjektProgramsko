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
	public WidgetProfil profil;
	public WidgetDodavanjeSadrzaja dodavanjeSadrzaja;

	public WidgetKnjigaSort tempSort;
	public ComboBox comboBoxSort;

	public VBox glavniVbox = new VBox();

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		glavniVbox = glavnimeni2.getVbox();
		pocetna = new WidgetPocetna();
		dodavanjeSadrzaja = new WidgetDodavanjeSadrzaja();
		tempSort = new WidgetKnjigaSort();

		//Button-i
		Button pocetnaButton = glavnimeni2.getPocetna();
		Button knjigaButton = glavnimeni2.getKnjige();
		Button casopisButton = glavnimeni2.getCasopis();
		Button filmButton = glavnimeni2.getFilm();
		Button profilButton = glavnimeni2.getProfil();

		Button dodavanjeButton = glavnimeni2.getDodavanje();
		RadioButton radioK = dodavanjeSadrzaja.radioKnjiga();
		RadioButton radioC = dodavanjeSadrzaja.radioCasopis();
		RadioButton radioF = dodavanjeSadrzaja.radioFilm();
		RadioButton radioI = dodavanjeSadrzaja.radioIzdanje();


		comboBoxSort = tempSort.getComboBox();

		pocetnaButton.Clicked += prikaziPocetna;
		knjigaButton.Clicked += prikaziKnjige;
		casopisButton.Clicked += prikaziCasopis;
		filmButton.Clicked += prikaziFilm;
		profilButton.Clicked += prikaziProfil;

		dodavanjeButton.Clicked += prikaziDodavanje;

		radioK.Clicked += prikaziDodavanjeKnjiga;
		radioC.Clicked += prikaziDodavanjeCasopis;
		radioF.Clicked += prikaziDodavanjeFilm;
		radioI.Clicked += prikaziDodavanjeIzdanje;


		comboBoxSort.Changed += odabirSorta;
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
		}

		Build();
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
		if(comboBoxSort.ActiveText == "Abeceda (silazno)")
		   lista.Sort((x, y) => string.Compare(y.Naziv, x.Naziv));

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
}
