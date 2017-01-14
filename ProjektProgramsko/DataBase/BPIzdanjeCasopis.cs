using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPIzdanjeCasopis
	{
		public static List<IzdanjeCasopis> DohvatiSve(int id)
		{
			List<IzdanjeCasopis> listaIzdanja = new List<IzdanjeCasopis>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from izdanje_casopis where id_casopis = '{0}'", id);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				IzdanjeCasopis ic = new IzdanjeCasopis();

				ic.Datum = (int)(Int64)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];

				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			return listaIzdanja;
		}
	}
}
