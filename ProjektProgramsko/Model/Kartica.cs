using System;
namespace ProjektProgramsko
{
	public class Kartica : Naplata
	{
		private string brojkartice;
		private DateTime datumisteka;
		private string imevlasnika;
		private string prezimevlasnika;

		public Kartica()
		{
		}

		public string Brojkartice
		{
			get
			{
				return brojkartice;
			}

			set
			{
				brojkartice = value;
			}
		}

		public DateTime Datumisteka
		{
			get
			{
				return datumisteka;
			}

			set
			{
				datumisteka = value;
			}
		}

		public string Imevlasnika
		{
			get
			{
				return imevlasnika;
			}

			set
			{
				imevlasnika = value;
			}
		}

		public string Prezimevlasnika
		{
			get
			{
				return prezimevlasnika;
			}

			set
			{
				prezimevlasnika = value;
			}
		}
	}
}
