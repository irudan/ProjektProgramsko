using System;
namespace ProjektProgramsko
{
	public class PayPal : Naplata
	{
		private string user;

		public PayPal()
		{
		}

		public string User
		{
			get
			{
				return user;
			}

			set
			{
				user = value;
			}
		}
	}
}
