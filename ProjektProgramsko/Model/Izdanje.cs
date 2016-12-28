using System;
namespace ProjektProgramsko
{
	public class Izdanje
	{
		private DateTime godina;
		private int brojStranica;
		private string nakladnik;
		private double cijena;

		public Izdanje()
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

		public int BrojStranica
		{
			get
			{
				return brojStranica;
			}

			set
			{
				brojStranica = value;
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
