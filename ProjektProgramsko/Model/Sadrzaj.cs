using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Sadrzaj
	{
		private long id;
		private string naziv;
		private string opis;

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

		public long Id
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
