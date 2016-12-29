using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BP
	{
		private static SqliteConnection konekcija;

		public static void otvoriKonekciju()
		{
			string connectionString = "URI=file:BazaPodataka.db";

			konekcija = new SqliteConnection(connectionString);

			konekcija.Open();
		}

		public static void zatvoriKonekciju()
		{
			konekcija.Close();
		}

		public static SqliteCommand komanda()
		{
			SqliteCommand temp = konekcija.CreateCommand();

			return temp;
		}
	}
}
