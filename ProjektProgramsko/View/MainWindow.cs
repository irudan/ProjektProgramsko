using System;
using System.Collections.Generic;
using Gtk;
using Mono.Data.Sqlite;
using ProjektProgramsko;

public partial class MainWindow : Gtk.Window
{
	public WidgetPocetna pocetna;
	public WidgetKnjiga knjiga;
	public WidgetDodavanjeSadrzaja dodavanjeSadrzaja;

	public WidgetKnjigaSort tempSort;
	public ComboBox comboBoxSort;

	public VBox glavniVbox;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		glavniVbox = glavnimeni2.getVbox();
		pocetna = new WidgetPocetna();
		dodavanjeSadrzaja = new WidgetDodavanjeSadrzaja();
		tempSort = new WidgetKnjigaSort();

		//Button-i
		Button knjigaButton = glavnimeni2.getKnjige();
		Button pocetnaButton = glavnimeni2.getPocetna();
		Button dodavanjeButton = glavnimeni2.getDodavanje();
		RadioButton radioK = dodavanjeSadrzaja.radioKnjiga();
		RadioButton radioC = dodavanjeSadrzaja.radioCasopis();
		RadioButton radioF = dodavanjeSadrzaja.radioFilm();


		comboBoxSort = tempSort.getComboBox();

		knjigaButton.Clicked += prikaziKnjige;
		pocetnaButton.Clicked += prikaziPocetna;
		dodavanjeButton.Clicked += prikaziDodavanje;

		radioK.Clicked += prikaziDodavanjeKnjiga;
		radioC.Clicked += prikaziDodavanjeCasopis;


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
