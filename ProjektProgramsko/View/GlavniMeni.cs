using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class GlavniMeni : Gtk.Bin
	{

		public GlavniMeni()
		{
			this.Build();
		}


		public Button getKnjige()
		{
			return buttonKnjige;
		}

		public Button getCasopis()
		{
			return buttonCasopisi;
		}

		public Button getFilm()
		{
			return buttonFilmovi;
		}

		public Button getPocetna()
		{
			return buttonPocetna;
		}

		public Button getDodavanje()
		{
			return buttonDodavanje;
		}

		public Button getUredivanje()
		{
			return buttonUredivanje;
		}

		public Button getPretrazi()
		{
			return buttonPretraga;
		}

		public VBox getVbox()
		{
			return vboxMain;
		}
	}
}
