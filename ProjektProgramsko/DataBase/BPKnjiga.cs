using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPKnjiga
	{
		public static void Spremi(Knjiga k, List<Autor> listaAutora)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			//Umetanje podataka u tablicu sadrzaj
			command.CommandText = String.Format(@"Insert into sadrzaj (naziv, opis) Values ('{0}', '{1}')", k.Naziv, k.Opis);

			command.ExecuteNonQuery();

			//Dohvacanje id koji je stvoren prethodnim ubacivanjem podataka
			k.Id = BPSadrzaj.DohvatiId(k.Naziv);

			//Umetanje podataka u tablicu knjiga
			command.CommandText = String.Format(@"Insert into knjiga (broj_stranica, cijena, nakladnik, jezik, tagovi, slika_path, pdf_path, broj_prodanih, id_sadrzaj) 
			Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", k.BrojStranica, k.Cijena, k.Nakladnik, k.Jezik, k.Tagovi, k.SlikaPath, k.PdfPath, k.BrojProdanih, k.Id);

			command.ExecuteNonQuery();

			BPKnjiga.DohvatiId(k);

			//Umetanje podataka vezanih za autora/e knjige
			foreach (var i in listaAutora)
			{
				command.CommandText = String.Format(@"Insert into AutorKnjiga (id_autor, id_knjiga) Values ('{0}', '{1}')", i.Id, k.IdK);

				command.ExecuteNonQuery();
			}

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Uredi(Knjiga k, List<Autor> listaAutora)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			//Umetanje podataka u tablicu sadrzaj
			command.CommandText = String.Format(@"Update sadrzaj set naziv = '{0}', opis = '{1}' where id = '{2}'", k.Naziv, k.Opis, k.Id);
			Console.WriteLine(k.Id);

			command.ExecuteNonQuery();

			//Umetanje podataka u tablicu knjiga
			command.CommandText = String.Format(@"Update knjiga set broj_stranica = '{0}', cijena = '{1}', nakladnik = '{2}', jezik = '{3}', tagovi = '{4}', slika_path = '{5}',
			 pdf_path = '{6}' where id = '{7}'", k.BrojStranica, k.Cijena, k.Nakladnik, k.Jezik, k.Tagovi, k.SlikaPath, k.PdfPath, k.IdK);

			command.ExecuteNonQuery();

			if (listaAutora.Capacity == 0)
			{
				command.Dispose();
				BP.zatvoriKonekciju();
				return;
			}

			command.CommandText = String.Format(@"Delete from autorknjiga where id_knjiga = '{0}'", k.IdK);

			command.ExecuteNonQuery();

			//Umetanje podataka vezanih za autora/e knjige
			foreach (var i in listaAutora)
			{
				command.CommandText = String.Format(@"Insert into AutorKnjiga (id_autor, id_knjiga) Values ('{0}', '{1}')", i.Id, k.IdK);

				command.ExecuteNonQuery();
			}

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Izbrisi(long id, long idK)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();


			command.CommandText = String.Format(@"Delete from autorknjiga where id_knjiga = '{0}'", idK);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Delete from knjiga where id = '{0}'", idK);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Delete from sadrzaj where id = '{0}'", id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void DohvatiId(Knjiga k)
		{
			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select knjiga.id from knjiga, sadrzaj where sadrzaj.naziv = '{0}' and sadrzaj.id = knjiga.id_sadrzaj", k.Naziv);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				k.IdK = (int)(Int64)reader["id"];
			}

			reader.Dispose();
			command.Dispose();
		}

		public static Knjiga DohvatiKnjiga(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from knjiga, sadrzaj where sadrzaj.id = knjiga.id_sadrzaj and knjiga.id = '{0}'", id);

			SqliteDataReader reader = command.ExecuteReader();

			Knjiga k = new Knjiga();

			while (reader.Read())
			{
				k.Id = (int)(Int64)reader["id_sadrzaj"];
				k.IdK = (int)(Int64)reader["id"];
				k.Opis = (string)reader["opis"];
				k.Naziv = (string)reader["naziv"];
				k.BrojStranica = (int)(Int64)reader["broj_stranica"];
				k.Cijena = (int)(double)reader["cijena"];
				k.Nakladnik = (string)reader["nakladnik"];
				k.Jezik = (string)reader["jezik"];
				k.Tagovi = (string)reader["tagovi"];
				k.SlikaPath = (string)reader["slika_path"];
				k.PdfPath = (string)reader["pdf_path"];
				k.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return k;
		}

		public static List<Knjiga> DohvatiSve()
		{
			List<Knjiga> listaKnjiga = new List<Knjiga>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from knjiga, sadrzaj where knjiga.id_sadrzaj = sadrzaj.id";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Knjiga k = new Knjiga();

				k.Id = (int)(Int64)reader["id_sadrzaj"];
				k.IdK = (int)(Int64)reader["id"];
				k.Opis = (string)reader["opis"];
				k.Naziv = (string)reader["naziv"];
				k.BrojStranica = (int)(Int64)reader["broj_stranica"];
				k.Cijena = (int)(double)reader["cijena"];
				k.Nakladnik = (string)reader["nakladnik"];
				k.Jezik = (string)reader["jezik"];
				k.Tagovi = (string)reader["tagovi"];
				k.SlikaPath = (string)reader["slika_path"];
				k.PdfPath = (string)reader["pdf_path"];
				k.BrojProdanih = (int)(Int64)reader["broj_prodanih"];

				listaKnjiga.Add(k);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaKnjiga;
		}

		public static List<Knjiga> DohvatiSort(string sort)
		{
			List<Knjiga> listaKnjiga = new List<Knjiga>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from knjiga, sadrzaj where knjiga.id_sadrzaj = sadrzaj.id order by {0}", sort);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Knjiga k = new Knjiga();

				k.IdK = (int)(Int64)reader["id"];
				k.Opis = (string)reader["opis"];
				k.Naziv = (string)reader["naziv"];
				k.BrojStranica = (int)(Int64)reader["broj_stranica"];
				k.Cijena = (int)(double)reader["cijena"];
				k.Nakladnik = (string)reader["nakladnik"];
				k.Jezik = (string)reader["jezik"];
				k.Tagovi = (string)reader["tagovi"];
				k.SlikaPath = (string)reader["slika_path"];
				k.PdfPath = (string)reader["pdf_path"];
				k.BrojProdanih = (int)(Int64)reader["broj_prodanih"];

				listaKnjiga.Add(k);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaKnjiga;
		}
	}
}
