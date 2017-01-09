using System;
using System.Collections.Generic;
using Gtk;
using Mono.Data.Sqlite;
using ProjektProgramsko;

public partial class MainWindow : Gtk.Window
{
	public WidgetPocetna pocetna;
	public WidgetKnjiga knjiga;
	public VBox glavniVbox;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();

		glavniVbox = glavnimeni2.getVbox();
		pocetna = new WidgetPocetna();


		Button knjigaButton = glavnimeni2.getKnjige() as Button;
		Button pocetnaButton = glavnimeni2.getPocetna() as Button;

		knjigaButton.Clicked += prikaziKnjige;
		pocetnaButton.Clicked += prikaziPocetna;
	}

	protected void prikaziPocetna(object sender, EventArgs a)
	{
		izbrisiDjecu();

		glavniVbox.Add(pocetna);

		Build();
	}

	protected void prikaziKnjige(object sender, EventArgs a)
	{
		izbrisiDjecu();

		List<Knjiga> temp = BPKnjiga.DohvatiSve();

		foreach (Knjiga i in temp)
		{
			knjiga = new WidgetKnjiga(i);
			glavniVbox.Add(knjiga);
		}

		Build();
	}

	protected void izbrisiDjecu()
	{
		Widget[] temp = glavniVbox.Children;

		foreach (var i in temp)
			glavniVbox.Remove(i);
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
