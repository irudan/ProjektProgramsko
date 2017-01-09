using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPKnjiga
	{
		public static void Spremi(Knjiga k)
		{
		}

		/*public static Knjiga Dohvati(long id)
		{
		}*/

		public static List<Knjiga> DohvatiSve()
		{
			List<Knjiga> listaKnjiga = new List<Knjiga>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from knjiga, sadrzaj where knjiga.id_sadrzaj = sadrzaj.id";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Knjiga k = new Knjiga();

				k.Id = (int)(Int64)reader["id"];
				k.Naziv = (string)reader["naziv"];
				k.Jezik = (string)reader["jezik"];
				k.Tagovi = (string)reader["tagovi"];

				listaKnjiga.Add(k);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaKnjiga;
		}
	}
}
