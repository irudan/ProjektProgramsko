using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Autor
	{
		private int id;
		private string ime;
		private string prezime;

		public Autor()
		{
		}

		public Autor(int Id, string Ime, string Prezime)
		{
			id = Id;
			ime = Ime;
			prezime = Prezime;
		}

		public int Id
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
	}
}
