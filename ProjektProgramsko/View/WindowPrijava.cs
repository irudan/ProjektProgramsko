using System;
namespace ProjektProgramsko
{
	public partial class WindowPrijava : Gtk.Window
	{
		public WindowPrijava() :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();
		}
	}
}
