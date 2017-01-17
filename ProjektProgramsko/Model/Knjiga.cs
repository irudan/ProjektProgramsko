using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Knjiga : Sadrzaj
	{
		private long id;
		private int brojStranica;
		private double cijena;
		private string nakladnik;
		private string jezik;
		private string tagovi;
		private int godina;
		private string slikaPath;
		private long brojProdanih;

		public Knjiga()
		{
			brojProdanih = 0;
		}

		public string Jezik
		{
			get
			{
				return jezik;
			}

			set
			{
				jezik = value;
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

		public long IdK
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

		public string SlikaPath
		{
			get
			{
				return slikaPath;
			}

			set
			{
				slikaPath = value;
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

		public int Godina
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

		public long BrojProdanih
		{
			get
			{
				return brojProdanih;
			}

			set
			{
				brojProdanih = value;
			}
		}
	}
}
