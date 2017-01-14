using System;


namespace ProjektProgramsko
{
	public partial class WindowPrijava : Gtk.Window
	{
		public WindowPrijava() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			buttonPrijavaRegistrirajse.Clicked += OtvoriRegistraciju;
		}


		protected void OtvoriRegistraciju(object sender, EventArgs a)
		{
			var WindowRegistracija = new WindowRegistracija();
		}
	}

}
