using System;
using System.Data;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BP
	{
		private static string connectionString = "URI=file:BazaPodataka.db";

		internal static SqliteConnection konekcija = new SqliteConnection(connectionString);

		public static void otvoriKonekciju()
		{
			konekcija.Open();
		}

		public static void zatvoriKonekciju()
		{
			konekcija.Close();
		}
	}
}
