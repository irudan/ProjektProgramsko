using System;
using Gtk;

namespace ProjektProgramsko
{
	public partial class WindowPreuzmi : Gtk.Window
	{
		public string pok;

		public WindowPreuzmi(string path) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			pok = path;

			buttonSpremi.Clicked += spremi;

			FileFilter filterFolder = new FileFilter();
			filterFolder.Name = "Folders";
			filterFolder.AddPattern("*.folder");
			filechooserwidget1.AddFilter(filterFolder);
		}

		protected void spremi(object sender, EventArgs a)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy " + pok + " " + filechooserwidget1.CurrentFolder;
			process.StartInfo = startInfo;
			process.Start();

			Console.WriteLine("/C copy " + pok + " " + filechooserwidget1.CurrentFolder);

			this.Destroy();
		}
	}
}
