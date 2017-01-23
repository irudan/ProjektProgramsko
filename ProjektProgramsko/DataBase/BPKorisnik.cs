using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
namespace ProjektProgramsko
{
	public static class BPKorisnik
	{
		public static List<Korisnik> DohvatiSve()
		{
			List<Korisnik> listaKorisnika = new List<Korisnik>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from korisnik";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Korisnik k = new Korisnik();

				k.Id = (int)(Int64)reader["id"];
				k.Ime = (string)reader["ime"];
				k.Prezime = (string)reader["prezime"];
				k.Username = (string)reader["username"];
				k.Password = (string)reader["password"];
				k.Mail = (string)reader["mail"];

				listaKorisnika.Add(k);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaKorisnika;
		}

		public static void Spremi(Korisnik k)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Insert into korisnik (ime, prezime, username, password, mail) Values('{0}', '{1}', '{2}', '{3}', '{4}')",
			                                    k.Ime, k.Prezime, k.Username, k.Password, k.Mail);

			command.ExecuteNonQuery();
			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Uredi(Korisnik k)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Update korisnik set ime = '{0}', prezime = '{1}', username = '{2}', password = '{3}', mail = '{4}' where id = '{5}'", 
			                                    k.Ime, k.Prezime, k.Username, k.Password, k.Mail, k.Id);

			command.ExecuteNonQuery();
			command.Dispose();

			BP.zatvoriKonekciju();
		}
	}
}
