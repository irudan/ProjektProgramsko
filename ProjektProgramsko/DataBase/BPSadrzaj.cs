using System;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPSadrzaj
	{
		public static long DohvatiId()
		{
			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select id from sadrzaj order by id desc";

			SqliteDataReader reader = command.ExecuteReader();

			long id = new int();

			while (reader.Read())
			{
				id = (int)(Int64)reader["id"];
				break;
			}

			reader.Dispose();
			command.Dispose();

			return id;
		}
	}
}
