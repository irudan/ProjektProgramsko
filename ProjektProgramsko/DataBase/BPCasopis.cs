using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPCasopis
	{
		public static void Spremi(Casopis c)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			//Umetanje podataka u tablicu sadrzaj
			command.CommandText = String.Format(@"Insert into sadrzaj (naziv, opis) Values ('{0}', '{1}')", c.Naziv, c.Opis);

			command.ExecuteNonQuery();

			//Dohvacanje id koji je stvoren prethodnim ubacivanjem podataka
			c.Id = BPSadrzaj.DohvatiId(c.Naziv);

			//Umetanje podataka u tablicu casopis
			command.CommandText = String.Format(@"Insert into casopis (tagovi, id_sadrzaj) 
			Values ('{0}', '{1}')", c.Tagovi, c.Id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}
	
		public static List<Casopis> DohvatiSve()
		{
			List<Casopis> listaCasopis = new List<Casopis>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from casopis, sadrzaj where casopis.id_sadrzaj = sadrzaj.id";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Casopis c = new Casopis();

				c.IdC = (int)(Int64)reader["id"];
				c.Naziv = (string)reader["naziv"];
				c.Opis = (string)reader["opis"];
				c.Tagovi = (string)reader["tagovi"];

				c.IzdanjeCasopis = BPIzdanjeCasopis.DohvatiSve(c.IdC);

				listaCasopis.Add(c);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaCasopis;
		}
	}
}
