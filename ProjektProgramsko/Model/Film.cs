﻿using System;
namespace ProjektProgramsko
{
	public class Film : Sadrzaj
	{
		private long id;
		private string redatelj;
		private int godina;
		private int trajanje;
		private double cijena;
		private string tagovi;
		private string slikaPath;
		private string videoPath;
		private long brojProdanih;

		public Film()
		{
			brojProdanih = 0;
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

		public long IdF
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

		public string Redatelj
		{
			get
			{
				return redatelj;
			}

			set
			{
				redatelj = value;
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

		public string VideoPath
		{
			get
			{
				return videoPath;
			}

			set
			{
				videoPath = value;
			}
		}
	}
}
