using System;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPSadrzaj
	{
		public static int DohvatiId(string naziv)
		{
			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select id from sadrzaj where sadrzaj.naziv = '{0}'", naziv);

			SqliteDataReader reader = command.ExecuteReader();

			int id = new int();

			while (reader.Read())
			{
				id = (int)(Int64)reader["id"];
			}

			reader.Dispose();
			command.Dispose();

			return id;
		}
	}
}
