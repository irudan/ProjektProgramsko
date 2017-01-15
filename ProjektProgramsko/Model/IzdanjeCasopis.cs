using System;
namespace ProjektProgramsko
{
	public class IzdanjeCasopis
	{
		private int datum;
		private int brojIzdanja;
		private double cijena;
		private string slikaPath;

		public IzdanjeCasopis()
		{
		}

		public int BrojIzdanja
		{
			get
			{
				return brojIzdanja;
			}

			set
			{
				brojIzdanja = value;
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

		public int Datum
		{
			get
			{
				return datum;
			}

			set
			{
				datum = value;
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
	}
}
