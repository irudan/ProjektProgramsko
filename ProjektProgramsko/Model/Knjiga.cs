using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Knjiga : Sadrzaj
	{
		private string jezik;
		private string tagovi;
		List<Izdanje> izdanjeCasopis;

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
	}
}
