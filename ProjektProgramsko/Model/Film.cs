using System;
namespace ProjektProgramsko
{
	public class Film : Sadrzaj
	{
		private int id;
		private DateTime godina;
		private int trajanje;
		private double cijena;
		private string tagovi;
		private string opis;

		public Film()
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

		public int Trajanje
		{
			get
			{
				return trajanje;
			}

			set
			{
				trajanje = value;
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

		public string Tagovi
		{
			get
			{
				return tagovi;
			}

			set
			{
				tagovi = value;
			}
		}

		public string Opis
		{
			get
			{
				return opis;
			}

			set
			{
				opis = value;
			}
		}

		public int Id
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
			}
		}
	}
}
