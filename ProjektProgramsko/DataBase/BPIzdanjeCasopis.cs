using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPIzdanjeCasopis
	{
		public static List<IzdanjeCasopis> DohvatiSve(long id)
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
				ic.SlikaPath = (string)reader["slika_path"];

				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			return listaIzdanja;
		}

		public static void Spremi(IzdanjeCasopis ic, long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into izdanje_casopis (datum, broj_izdanja, cijena, slika_path, id_casopis) 
												Values ('{0}', '{1}', '{2}', '{3}', '{4}')", ic.Datum, ic.BrojIzdanja, ic.Cijena, ic.SlikaPath, id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}
	}
}
