using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPIzdanjeCasopis
	{
		public static void Spremi(IzdanjeCasopis ic, long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into izdanje_casopis (datum, broj_izdanja, cijena, slika_path, pdf_path, broj_prodanih, id_casopis) 
												Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", ic.Datum, ic.BrojIzdanja, ic.Cijena, ic.SlikaPath, ic.PdfPath,
			                                    ic.BrojProdanih, id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Uredi(IzdanjeCasopis ic, long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			if (id != 0)
			{
				command.CommandText = String.Format(@"Update izdanje_casopis set datum = '{0}', broj_izdanja = '{1}', cijena = '{2}', slika_path = '{3}', pdf_path = '{4}' 
				id_casopis = '{5}' where izdanje_casopis.id = '{6}'", ic.Datum, ic.BrojIzdanja, ic.Cijena, ic.SlikaPath, ic.PdfPath, id, ic.Id);
			}
			else
			{
				command.CommandText = String.Format(@"Update izdanje_casopis set datum = '{0}', broj_izdanja = '{1}', cijena = '{2}', slika_path = '{3}', pdf_path = '{4}'
												where izdanje_casopis.id = '{5}'", ic.Datum, ic.BrojIzdanja, ic.Cijena, ic.SlikaPath, ic.PdfPath, ic.Id);
			}


			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Izbrisi(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();


			command.CommandText = String.Format(@"Delete from izdanje_casopis where id = '{0}'", id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static IzdanjeCasopis DohvatiIzdanje(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from izdanje_casopis where id = '{0}'", id);

			SqliteDataReader reader = command.ExecuteReader();

			IzdanjeCasopis ic = new IzdanjeCasopis();

			while (reader.Read())
			{
				ic.Id = (int)(Int64)reader["id"];
				ic.Datum = (string)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];
				ic.SlikaPath = (string)reader["slika_path"];
				ic.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
				ic.IdC = (int)(Int64)reader["id_casopis"];
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return ic;
		}

		public static List<IzdanjeCasopis> DohvatiSve(long id)
		{
			List<IzdanjeCasopis> listaIzdanja = new List<IzdanjeCasopis>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from izdanje_casopis where id_casopis = '{0}'", id);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				IzdanjeCasopis ic = new IzdanjeCasopis();

				ic.Id = (int)(Int64)reader["id"];
				ic.Datum = (string)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];
				ic.SlikaPath = (string)reader["slika_path"];
				ic.PdfPath = (string)reader["pdf_path"];
				ic.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
				ic.IdC = (int)(Int64)reader["id_casopis"];


				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			return listaIzdanja;
		}

		public static List<IzdanjeCasopis> DohvatiSve()
		{
			BP.otvoriKonekciju();

			List<IzdanjeCasopis> listaIzdanja = new List<IzdanjeCasopis>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from izdanje_casopis";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				IzdanjeCasopis ic = new IzdanjeCasopis();

				ic.Id = (int)(Int64)reader["id"];
				ic.Datum = (string)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];
				ic.SlikaPath = (string)reader["slika_path"];
				ic.PdfPath = (string)reader["pdf_path"];
				ic.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
				ic.IdC = (int)(Int64)reader["id_casopis"];


				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaIzdanja;
		}

		public static List<IzdanjeCasopis> DohvatiSort(string sort)
		{
			BP.otvoriKonekciju();

			List<IzdanjeCasopis> listaIzdanja = new List<IzdanjeCasopis>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from izdanje_casopis, casopis, sadrzaj where izdanje_casopis.id_casopis = casopis.id and casopis.id_sadrzaj = sadrzaj.id
												 order by {0}", sort);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				IzdanjeCasopis ic = new IzdanjeCasopis();

				ic.Id = (int)(Int64)reader["id"];
				ic.Datum = (string)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];
				ic.SlikaPath = (string)reader["slika_path"];
				ic.PdfPath = (string)reader["pdf_path"];
				ic.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
				ic.IdC = (int)(Int64)reader["id_casopis"];


				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaIzdanja;
		}

		public static List<IzdanjeCasopis> DohvatiTag(string tag)
		{
			BP.otvoriKonekciju();

			List<IzdanjeCasopis> listaIzdanja = new List<IzdanjeCasopis>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from izdanje_casopis, casopis, sadrzaj where izdanje_casopis.id_casopis = casopis.id and casopis.id_sadrzaj = sadrzaj.id 
												 and tagovi like '%{0}%'", tag);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				IzdanjeCasopis ic = new IzdanjeCasopis();

				ic.Id = (int)(Int64)reader["id"];
				ic.Datum = (string)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];
				ic.SlikaPath = (string)reader["slika_path"];
				ic.PdfPath = (string)reader["pdf_path"];
				ic.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
				ic.IdC = (int)(Int64)reader["id_casopis"];


				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaIzdanja;
		}

		public static List<IzdanjeCasopis> Pretraga(string pretraga)
		{
			BP.otvoriKonekciju();

			List<IzdanjeCasopis> listaIzdanja = new List<IzdanjeCasopis>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from izdanje_casopis, casopis, sadrzaj where izdanje_casopis.id_casopis = casopis.id and casopis.id_sadrzaj = sadrzaj.id 
												 and naziv like '%{0}%'", pretraga);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				IzdanjeCasopis ic = new IzdanjeCasopis();

				ic.Id = (int)(Int64)reader["id"];
				ic.Datum = (string)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];
				ic.SlikaPath = (string)reader["slika_path"];
				ic.PdfPath = (string)reader["pdf_path"];
				ic.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
				ic.IdC = (int)(Int64)reader["id_casopis"];


				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaIzdanja;
		}

		public static List<IzdanjeCasopis> DohvatiMojSadrzaj(long id)
		{
			List<IzdanjeCasopis> listaIzdanja = new List<IzdanjeCasopis>();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from izdanje_casopis, naplata where id_casopis = '{0}' and naplata.id_sadrzaj = izdanje_casopis.id and 
			naplata.id_korisnik = '{1}'", id, MyGlobals.trenutni.Id);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				IzdanjeCasopis ic = new IzdanjeCasopis();

				ic.Id = (int)(Int64)reader["id"];
				ic.Datum = (string)reader["datum"];
				ic.BrojIzdanja = (int)(Int64)reader["broj_izdanja"];
				ic.Cijena = (int)(double)reader["cijena"];
				ic.SlikaPath = (string)reader["slika_path"];
				ic.PdfPath = (string)reader["pdf_path"];
				ic.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
				ic.IdC = (int)(Int64)reader["id_casopis"];


				listaIzdanja.Add(ic);
			}

			reader.Dispose();
			command.Dispose();

			return listaIzdanja;
		}
	}
}
