using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPCasopis
	{
		public static void Spremi(Casopis c)
		{ 
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

				c.Id = (int)(Int64)reader["id"];
				c.Naziv = (string)reader["naziv"];
				c.Tagovi = (string)reader["tagovi"];

				listaCasopis.Add(c);
			}

			reader.Dispose();
			command.Dispose();

			return listaCasopis;
		}
	}
}
