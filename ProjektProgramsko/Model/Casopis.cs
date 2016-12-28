using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Casopis : Sadrzaj
	{
		private string tagovi;
		List<Izdanje> izdanjeCasopis;

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
	}
}
