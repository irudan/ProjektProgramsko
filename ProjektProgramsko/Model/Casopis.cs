﻿using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Casopis : Sadrzaj
	{
		private long id;
		private string tagovi;
		List<IzdanjeCasopis> izdanjeCasopis;

		public Casopis()
		{
			izdanjeCasopis = new List<IzdanjeCasopis>();
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

		public long IdC
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
