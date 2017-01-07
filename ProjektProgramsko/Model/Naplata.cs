using System;
namespace ProjektProgramsko
{
	public class Naplata
	{
		private string brnaplate;
		private double iznos;

		public string Brnaplate
		{
			get
			{
				return brnaplate;
			}

			set
			{
				brnaplate = value;
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
