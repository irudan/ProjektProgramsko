using System;
namespace ProjektProgramsko
{
	public class IzdanjeCasopis
	{
		private DateTime godina;
		private int brojIzdanja;
		private double cijena;

		public IzdanjeCasopis()
		{
		}

		public DateTime Godina
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
	}
}
