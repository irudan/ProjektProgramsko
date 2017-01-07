using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Autor 
	{
		private string ime;
		private string prezime;

		List<AutorSadrzaj> autorsadrzaj;

		public string Ime
		{
			get
			{
				return ime;
			}

			set
			{
				ime = value;
			}
		}

		public string Prezime
		{
			get
			{
				return prezime;
			}

			set
			{
				prezime = value;
			}
		}

		public List<AutorSadrzaj> Autorsadrzaj
		{
			get
			{
				return autorsadrzaj;
			}

			set
			{
				autorsadrzaj = value;
			}
		}
	}
}
