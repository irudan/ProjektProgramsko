using System;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetDodavanjeCasopis : Gtk.Bin
	{
		public WidgetDodavanjeCasopis()
		{
			this.Build();

			buttonSpremi.Clicked += spremiCasopis;
		}

		protected void spremiCasopis(object sender, EventArgs a)
		{
			Casopis c = new Casopis();

			c.Naziv = entryNaziv.Text;
			c.Opis = entryOpis.Text;
			c.Tagovi = entryTagovi.Text;

			/*string slika = filechooserbutton1.Filename;

			for (int i = slika.Length - 1; i != 0; i--)
			{
				if (slika[i] == '\\')
				{
					slika = slika.Remove(0, i + 1);
					break;
				}
			}

			c.SlikaPath = "Images/" + slika;

			spremiSliku(c.SlikaPath);*/

			BPCasopis.Spremi(c);
		}

		/*protected void spremiSliku(string slika)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = "/C copy " + filechooserbutton1.Filename + " C:\\Users\\Mateo\\Documents\\GitHub\\ProjektProgramsko\\ProjektProgramsko\\bin\\Debug\\Images";
			process.StartInfo = startInfo;
			process.Start();
		}*/
	}
}
