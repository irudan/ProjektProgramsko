using System;
namespace ProjektProgramsko
{
	public class IzdanjeCasopis
	{
		private DateTime godina;
		private int brojIzdanja;
		private string nakladnik;
		private double cijena;

		public IzdanjeCasopis()
		{
		}

		public DateTime Godina
		{
			get
			{
				return godina;
			}

			set
			{
				godina = value;
			}
		}

		public int BrojIzdanja
		{
			get
			{
				return brojIzdanja;
			}

			set
			{
				brojIzdanja = value;
			}
		}

		public string Nakladnik
		{
			get
			{
				return nakladnik;
			}

			set
			{
				nakladnik = value;
			}
		}

		public double Cijena
		{
			get
			{
				return cijena;
			}

			set
			{
				cijena = value;
			}
		}
	}
}
