using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowPrijava : Gtk.Window
	{
		public WindowPrijava() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			buttonRegistrirajse.Clicked += prikaziRegistracija;
		}

		protected void prikaziRegistracija(object sender, EventArgs a)
		{
			this.Destroy();

			var windowRegistracija = new WindowRegistracija();


		}	

	}
}
