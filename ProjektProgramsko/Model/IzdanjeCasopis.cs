using System;
namespace ProjektProgramsko
{
	public class IzdanjeCasopis
	{
		private int datum;
		private int brojIzdanja;
		private double cijena;

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
	}
}
