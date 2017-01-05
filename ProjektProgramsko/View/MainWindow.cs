using System;
using System.Collections.Generic;
using Gtk;
using Mono.Data.Sqlite;
using ProjektProgramsko;

public partial class MainWindow : Gtk.Window
{
	public GlavniMeni glavniMeni;
	public WidgetPocetna pocetna;
	public WidgetKnjiga knjige;
	public VBox glavniHbox;

	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		//Stvaranje "container-a" i dodavanje u main window
		HBox glavniContainer = new HBox();
		this.Add(glavniContainer);

		//Stvaranje custom widgeta
		glavniMeni = new GlavniMeni();
		pocetna = new WidgetPocetna();
		knjige = new WidgetKnjiga();

		//Dodavanje menia u glavni container
		glavniContainer.Add(glavniMeni);

		//Dohvacanje vrijednosti hbox-a iz widget-a glavni meni
		glavniHbox = glavniMeni.getHbox() as VBox;

		//Dodavanje widgeta pocetna u hbox iz widgeta meni
		glavniHbox.Add(pocetna);

		Build();

		Button knjigeButton = glavniMeni.getKnjige() as Button;
		Button pocetnaButton = glavniMeni.getPocetna() as Button;

		knjigeButton.Clicked += prikaziKnjige;
		pocetnaButton.Clicked += prikaziPocetna;
	}

	protected void prikaziPocetna(object sender, EventArgs a)
	{
		glavniHbox.Remove(knjige);
		glavniHbox.Add(pocetna);

		Build();
	}

	protected void prikaziKnjige(object sender, EventArgs a)
	{
		glavniHbox.Remove(pocetna);
		glavniHbox.Add(knjige);

		/*List<Knjiga> temp = BPKnjiga.DohvatiSve();

		foreach (Knjiga i in temp)
		{
			WidgetKnjiga2 nova = new WidgetKnjiga2(i);
			glavniHbox.Add(nova);
		}*/

		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
