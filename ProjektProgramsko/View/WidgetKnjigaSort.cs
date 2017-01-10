using System;
using Gtk;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetKnjigaSort : Gtk.Bin
	{
		public WidgetKnjigaSort()
		{
			this.Build();

			combobox1.AppendText("Abeceda (silazno)");
			combobox1.AppendText("Abeceda (uzlazno)");
		}

		public ComboBox getComboBox()
		{
			return combobox1;
		}
	}
}
