using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Knjiga : Sadrzaj
	{
		private int id;
		private int brojStranica;
		private double cijena;
		private string nakladnik;
		private string jezik;
		private string tagovi;
		private int godina;
		private string slikaPath;

		public Knjiga()
		{
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

		public int IdK
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
	}
}
