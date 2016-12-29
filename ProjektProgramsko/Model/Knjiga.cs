using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Knjiga : Sadrzaj
	{
		private int id;
		private string jezik;
		private string tagovi;
		List<IzdanjeKnjiga> izdanjeKnjiga;

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

		public List<IzdanjeKnjiga> IzdanjeKnjiga
		{
			get
			{
				return izdanjeKnjiga;
			}

			set
			{
				izdanjeKnjiga = value;
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
