using System;
using Gtk;
namespace ProjektProgramsko
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class WidgetPayPal : Gtk.Bin
	{
		public long pokId;
		public double pokC;

		public WidgetPayPal(long id, double cijena)
		{
			this.Build();

			pokId = id;
			pokC = cijena;

			buttonPotvrdi.Clicked += potvrdiNaplata;
			buttonOdustani.Clicked += odustaniNaplata;
		}

		protected void potvrdiNaplata(object seneder, EventArgs a)
		{
			if (entryKorIme.Text == "" || entryLozinka.Text == "")
			{

				Dialog upozorenje = new Gtk.MessageDialog((Window)this.Toplevel, DialogFlags.Modal, MessageType.Warning, ButtonsType.Ok, "Sva polja moraju biti unesena!");

				upozorenje.Run();
				upozorenje.Destroy();
				return;
			}

			Dialog d = new MessageDialog((Window)this.Toplevel, DialogFlags.Modal,
										 MessageType.Question,
			                             ButtonsType.YesNo, "Želiš li potvrditi kupnju?");

			ResponseType result = (ResponseType)d.Run();

			if (result == ResponseType.Yes)
			{
				PayPal p = new PayPal();

				p.Iznos = pokC;
				p.User = entryKorIme.Text;

				BPNaplata.spremiPayPal(p, pokId, MyGlobals.trenutni.Id);
				d.Destroy();
				potvrda();
			}
			else
				d.Destroy();
		}

		protected void odustaniNaplata(object seneder, EventArgs a)
		{
			this.Toplevel.Destroy();
		}

		protected void potvrda()
		{
			Dialog d = new MessageDialog((Window)this.Toplevel, DialogFlags.Modal,
			                             MessageType.Info,
			                             ButtonsType.Ok, "Transakcija uspješno provedena");

			d.Run();
			d.Destroy();

			this.Toplevel.Destroy();
		}
	}
}
