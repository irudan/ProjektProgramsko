using System;
namespace ProjektProgramsko
{
	public class Naplata
	{
		private long id;
		private double iznos;

		public Naplata()
		{
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

		public double Iznos
		{
			get
			{
				return iznos;
			}

			set
			{
				iznos = value;
			}
		}
	}
}
