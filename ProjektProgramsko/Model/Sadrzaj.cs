using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Sadrzaj
	{
		private string naziv;

		List<Naplata> naplata;


		public string Naziv
		{
			get
			{
				return naziv;
			}

			set
			{
				naziv = value;
			}
		}

		public List<Naplata> Naplata
		{
			get
			{
				return naplata;
			}

			set
			{
				naplata = value;
			}
		}
	}
}
