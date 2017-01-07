using System;
using System.Collections.Generic;

namespace ProjektProgramsko
{
	public class Korisnik
	{

		private string ime;
		private string prezime;
		private string username;
		private string password;
		private string mail;

		List<Naplata> naplata;

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

		public string Username
		{
			get
			{
				return username;
			}

			set
			{
				username = value;
			}
		}

		public string Password
		{
			get
			{
				return password;
			}

			set
			{
				password = value;
			}
		}

		public string Mail
		{
			get
			{
				return mail;
			}

			set
			{
				mail = value;
			}
		}

		public List<Naplata> Naplata
		{
			get
			{
				return naplata;
			}

			set
			{
				naplata = value;
			}
		}
	}
}
