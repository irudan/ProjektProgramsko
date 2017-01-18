using System;
namespace ProjektProgramsko
{
	public partial class WindowRegistracija : Gtk.Window
	{
		public WindowRegistracija() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();


		}

		protected void Odustani(object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}
