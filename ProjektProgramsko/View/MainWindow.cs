using System;
using Gtk;
using Mono.Data.Sqlite;
using ProjektProgramsko;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		//Stvaranje hboxa u koji stavljamo ostale widgete
		HBox glavniContainer = new HBox();

		//Stvaranje instance custom widgeta koji sluzi kao meni
		GlavniMeni mainMenu = new GlavniMeni();

		//Dodavanje hbox u nas window
		this.Add(glavniContainer);

		//Dodavanje menia u glavni container
		glavniContainer.Add(mainMenu);

		//Dohvacanje vrijednosti hbox-a iz widget-a glavni meni
		var temp = new HBox();
		temp = mainMenu.test() as HBox;

		//Stvaranje novog custom widgeta koji sluzi kao pocetna
		WidgetPocetna pocetna = new WidgetPocetna();

		//Dodavanje widgeta pocetna u hbox iz widgeta meni
		temp.Add(pocetna);

		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}
}
