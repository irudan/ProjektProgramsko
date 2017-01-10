using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Casopis : Sadrzaj
	{
		private int id;
		private string tagovi;
		List<IzdanjeCasopis> izdanjeCasopis;

		public Casopis()
		{
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

		public List<IzdanjeCasopis> IzdanjeCasopis
		{
			get
			{
				return izdanjeCasopis;
			}

			set
			{
				izdanjeCasopis = value;
			}
		}

		public int IdC
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
