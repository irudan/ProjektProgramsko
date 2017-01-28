using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPFilm
	{
		public static void Spremi(Film f)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			//Umetanje podataka u tablicu sadrzaj
			command.CommandText = String.Format(@"Insert into sadrzaj (naziv, opis) Values ('{0}', '{1}')", f.Naziv, f.Opis);

			command.ExecuteNonQuery();

			//Dohvacanje id koji je stvoren prethodnim ubacivanjem podataka
			f.Id = BPSadrzaj.DohvatiId(f.Naziv);

			//Umetanje podataka u tablicu casopis
			command.CommandText = String.Format(@"Insert into film (redatelj, godina, trajanje, cijena, tagovi, slika_path, broj_prodanih, id_sadrzaj) 
			Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", f.Redatelj, f.Godina, f.Trajanje, f.Cijena, f.Tagovi, f.SlikaPath, f.BrojProdanih, f.Id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Uredi(Film f)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			//Umetanje podataka u tablicu sadrzaj
			command.CommandText = String.Format(@"Update sadrzaj set naziv = '{0}', opis = '{1}' where sadrzaj.id = '{2}'", f.Naziv, f.Opis, f.Id);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Update film set redatelj = '{0}', godina = '{1}', trajanje = '{2}', cijena = '{3}', tagovi = '{4}', slika_path = '{5}' where film.id = '{6}'", 
			                                    f.Redatelj, f.Godina, f.Trajanje, f.Cijena, f.Tagovi, f.SlikaPath, f.IdF);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static void Izbrisi(long id, long idF)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();


			command.CommandText = String.Format(@"Delete from film where id = '{0}'", idF);

			command.ExecuteNonQuery();

			command.CommandText = String.Format(@"Delete from sadrzaj where id = '{0}'", id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
		}

		public static Film DohvatiFilm(long id)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from film, sadrzaj where film.id_sadrzaj = sadrzaj.id and film.id = '{0}'", id);

			SqliteDataReader reader = command.ExecuteReader();

			Film f = new Film();

			while (reader.Read())
			{
				f.Id = (int)(Int64)reader["id_sadrzaj"];
				f.IdF = (int)(Int64)reader["id"];
				f.Naziv = (string)reader["naziv"];
				f.Opis = (string)reader["opis"];
				f.Redatelj = (string)reader["redatelj"];
				f.Godina = (int)(Int64)reader["godina"];
				f.Trajanje = (int)(Int64)reader["trajanje"];
				f.Cijena = (int)(Double)reader["cijena"];
				f.Tagovi = (string)reader["tagovi"];
				f.SlikaPath = (string)reader["slika_path"];
				f.BrojProdanih = (int)(Int64)reader["broj_prodanih"];
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return f;
		}

		public static List<Film> DohvatiSve()
		{
			List<Film> listaFilmovi = new List<Film>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = "Select * from film, sadrzaj where film.id_sadrzaj = sadrzaj.id";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Film f = new Film();

				f.Id = (int)(Int64)reader["id_sadrzaj"];
				f.IdF = (int)(Int64)reader["id"];
				f.Naziv = (string)reader["naziv"];
				f.Opis = (string)reader["opis"];
				f.Redatelj = (string)reader["redatelj"];
				f.Godina = (int)(Int64)reader["godina"];
				f.Trajanje = (int)(Int64)reader["trajanje"];
				f.Cijena = (int)(Double)reader["cijena"];
				f.Tagovi = (string)reader["tagovi"];
				f.SlikaPath = (string)reader["slika_path"];
				f.BrojProdanih = (int)(Int64)reader["broj_prodanih"];

				listaFilmovi.Add(f);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaFilmovi;
		}

		public static List<Film> DohvatiSort(string sort)
		{
			List<Film> listaFilmovi = new List<Film>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from film, sadrzaj where film.id_sadrzaj = sadrzaj.id order by {0}", sort);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Film f = new Film();

				f.Id = (int)(Int64)reader["id_sadrzaj"];
				f.IdF = (int)(Int64)reader["id"];
				f.Naziv = (string)reader["naziv"];
				f.Opis = (string)reader["opis"];
				f.Redatelj = (string)reader["redatelj"];
				f.Godina = (int)(Int64)reader["godina"];
				f.Trajanje = (int)(Int64)reader["trajanje"];
				f.Cijena = (int)(Double)reader["cijena"];
				f.Tagovi = (string)reader["tagovi"];
				f.SlikaPath = (string)reader["slika_path"];
				f.BrojProdanih = (int)(Int64)reader["broj_prodanih"];

				listaFilmovi.Add(f);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaFilmovi;
		}

		public static List<Film> DohvatiTag(string tag)
		{
			List<Film> listaFilmovi = new List<Film>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from film, sadrzaj where film.id_sadrzaj = sadrzaj.id and tagovi like '%{0}%'", tag);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Film f = new Film();

				f.Id = (int)(Int64)reader["id_sadrzaj"];
				f.IdF = (int)(Int64)reader["id"];
				f.Naziv = (string)reader["naziv"];
				f.Opis = (string)reader["opis"];
				f.Redatelj = (string)reader["redatelj"];
				f.Godina = (int)(Int64)reader["godina"];
				f.Trajanje = (int)(Int64)reader["trajanje"];
				f.Cijena = (int)(Double)reader["cijena"];
				f.Tagovi = (string)reader["tagovi"];
				f.SlikaPath = (string)reader["slika_path"];
				f.BrojProdanih = (int)(Int64)reader["broj_prodanih"];

				listaFilmovi.Add(f);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaFilmovi;
		}

		public static List<Film> Pretraga(string pretraga)
		{
			List<Film> listaFilmovi = new List<Film>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Select * from film, sadrzaj where film.id_sadrzaj = sadrzaj.id and naziv like '%{0}%'", pretraga);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Film f = new Film();

				f.Id = (int)(Int64)reader["id_sadrzaj"];
				f.IdF = (int)(Int64)reader["id"];
				f.Naziv = (string)reader["naziv"];
				f.Opis = (string)reader["opis"];
				f.Redatelj = (string)reader["redatelj"];
				f.Godina = (int)(Int64)reader["godina"];
				f.Trajanje = (int)(Int64)reader["trajanje"];
				f.Cijena = (int)(Double)reader["cijena"];
				f.Tagovi = (string)reader["tagovi"];
				f.SlikaPath = (string)reader["slika_path"];
				f.BrojProdanih = (int)(Int64)reader["broj_prodanih"];

				listaFilmovi.Add(f);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaFilmovi;
		}

		public static List<Film> DohvatiMojSadrzaj()
		{
			List<Film> listaFilmovi = new List<Film>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Select * from film, sadrzaj, naplata where film.id_sadrzaj = sadrzaj.id and sadrzaj.id = naplata.id_sadrzaj " +
			                                    "and naplata.id_korisnik = '{0}'", MyGlobals.trenutni.Id);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Film f = new Film();

				f.Id = (int)(Int64)reader["id_sadrzaj"];
				f.IdF = (int)(Int64)reader["id"];
				f.Naziv = (string)reader["naziv"];
				f.Opis = (string)reader["opis"];
				f.Redatelj = (string)reader["redatelj"];
				f.Godina = (int)(Int64)reader["godina"];
				f.Trajanje = (int)(Int64)reader["trajanje"];
				f.Cijena = (int)(Double)reader["cijena"];
				f.Tagovi = (string)reader["tagovi"];
				f.SlikaPath = (string)reader["slika_path"];
				f.BrojProdanih = (int)(Int64)reader["broj_prodanih"];

				listaFilmovi.Add(f);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaFilmovi;
		}
	}
}
