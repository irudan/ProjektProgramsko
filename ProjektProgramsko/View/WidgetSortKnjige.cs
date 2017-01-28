using System;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetSortKnjige : Gtk.Bin
	{
		public WidgetSortKnjige()
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
			return entry1;
		}
	}
}
