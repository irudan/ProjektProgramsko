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

		public static List<Autor> DohvatiAutore(Knjiga k)
		{
			List<Autor> listaAutora = new List<Autor>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select ime, prezime from autor, autorknjiga where id_knjiga = '{0}' And id_autor = autor.id", k.IdK);

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
