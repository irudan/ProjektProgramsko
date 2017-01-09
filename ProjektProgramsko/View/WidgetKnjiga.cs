using System;
using System.Collections.Generic;
using Gtk;

namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetKnjiga : Gtk.Bin
	{
		public KnjigaNodeStore knjigaPresenter = new KnjigaNodeStore();

		public WidgetKnjiga(Knjiga k)
		{
			this.Build();

			label1.LabelProp = k.Naziv;

			var buffer = System.IO.File.ReadAllBytes("Images/test.jpg");
			var pixbuf = new Gdk.Pixbuf(buffer);
			image1.Pixbuf = pixbuf;
		}
	}
}
