using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetSortCasopis : Gtk.Bin
	{
		public WidgetSortCasopis()
		{
			this.Build();
		}

		public void postaviPrazno()
		{
			comboboxSort.Active = -1;
			comboboxTag.Active = -1;
		}

		public ComboBox getSort()
		{
			return comboboxSort;
		}

		public ComboBox getTag()
		{
			return comboboxTag;
		}

		public Entry getPretraga()
		{
			return entry2;
		}
	}
}
