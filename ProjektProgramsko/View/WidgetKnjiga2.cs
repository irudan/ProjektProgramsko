using System;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetKnjiga2 : Gtk.Bin
	{
		public WidgetKnjiga2(Knjiga k)
		{
			this.Build();

			label1.Text = k.Naziv;
		}
	}
}
