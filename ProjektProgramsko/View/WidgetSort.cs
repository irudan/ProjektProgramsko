using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetSort : Gtk.Bin
	{
		public WidgetSort()
		{
			this.Build();
		}

		public ComboBox getComboBox()
		{
			return combobox1;
		}
	}
}
