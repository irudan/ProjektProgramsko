using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPAutor
	{
		public static void Spremi(Autor a)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into autor (ime, prezime) Values ('{0}', '{1}')", a.Ime, a.Prezime);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Uredi(Autor a)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Update autor set ime = '{0}', prezime = '{1}' where autor.id = '{2}'", a.Ime, a.Prezime, a.Id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Izbrisi(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Delete from autor where autor.id = '{0}'", id);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Delete from autorknjiga where autorknjiga.id_autor = '{0}'", id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static List<Autor> DohvatiSve()
		{
			List<Autor> listaAutora = new List<Autor>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from autor";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Autor a = new Autor();

				a.Id = (int)(Int64)reader["id"];
				a.Ime = (string)reader["ime"];
				a.Prezime = (string)reader["prezime"];

				listaAutora.Add(a);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaAutora;
		}

		public static List<Autor> DohvatiAutore(long id)
		{
			List<Autor> listaAutora = new List<Autor>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select ime, prezime from autor, autorknjiga where id_knjiga = '{0}' And id_autor = autor.id", id);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Autor a = new Autor();

				a.Ime = (string)reader["ime"];
				a.Prezime = (string)reader["prezime"];

				listaAutora.Add(a);
			}


			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaAutora;
		}
	}
}
