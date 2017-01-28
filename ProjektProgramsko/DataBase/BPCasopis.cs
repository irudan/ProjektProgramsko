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

		public static void Uredi(Casopis c)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			//Umetanje podataka u tablicu sadrzaj
			command.CommandText = String.Format(@"Update sadrzaj set naziv = '{0}', opis = '{1}' where sadrzaj.id = '{2}'", c.Naziv, c.Opis, c.Id);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Update casopis set tagovi = '{0}' where casopis.id = '{1}'", c.Tagovi, c.IdC);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Izbrisi(long id, long idC)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();


			command.CommandText = String.Format(@"Delete from izdanje_casopis where id_casopis = '{0}'", idC);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Delete from casopis where id = '{0}'", idC);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Delete from sadrzaj where id = '{0}'", id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static Casopis DohvatiCasopis(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from casopis, sadrzaj where casopis.id_sadrzaj = sadrzaj.id and casopis.id = '{0}'", id);

			SqliteDataReader reader = command.ExecuteReader();

			Casopis c = new Casopis();

			while (reader.Read())
			{
				c.Id = (int)(Int64)reader["id_sadrzaj"];
				c.IdC = (int)(Int64)reader["id"];
				c.Naziv = (string)reader["naziv"];
				c.Opis = (string)reader["opis"];
				c.Tagovi = (string)reader["tagovi"];


				c.IzdanjeCasopis = BPIzdanjeCasopis.DohvatiSve(c.IdC);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return c;
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

				c.Id = (int)(Int64)reader["id_sadrzaj"];
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

		public static List<Casopis> DohvatiMojSadrzaj()
		{
			List<Casopis> listaCasopis = new List<Casopis>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from casopis, sadrzaj where casopis.id_sadrzaj = sadrzaj.id";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Casopis c = new Casopis();

				c.Id = (int)(Int64)reader["id_sadrzaj"];
				c.IdC = (int)(Int64)reader["id"];
				c.Naziv = (string)reader["naziv"];
				c.Opis = (string)reader["opis"];
				c.Tagovi = (string)reader["tagovi"];


				c.IzdanjeCasopis = BPIzdanjeCasopis.DohvatiMojSadrzaj(c.IdC);

				listaCasopis.Add(c);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaCasopis;
		}
	}
}
