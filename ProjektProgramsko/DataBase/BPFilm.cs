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
			command.CommandText = String.Format(@"Insert into film (redatelj, godina, trajanje, cijena, tagovi, slika_path, id_sadrzaj) 
			Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", f.Redatelj, f.Godina, f.Trajanje, f.Cijena, f.Tagovi, f.SlikaPath, f.Id);

			command.ExecuteNonQuery();

			command.Dispose();

			BP.zatvoriKonekciju();
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

				f.Naziv = (string)reader["naziv"];
				f.Opis = (string)reader["opis"];
				f.Redatelj = (string)reader["redatelj"];
				f.Godina = (int)(Int64)reader["godina"];
				f.Trajanje = (int)(Int64)reader["trajanje"];
				f.Cijena = (int)(Double)reader["cijena"];
				f.Tagovi = (string)reader["tagovi"];
				f.SlikaPath = (string)reader["slika_path"];

				listaFilmovi.Add(f);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaFilmovi;
		}
	}
}
