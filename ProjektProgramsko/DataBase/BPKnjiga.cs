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
			command.CommandText = String.Format(@"Insert into knjiga (broj_stranica, cijena, nakladnik, jezik, tagovi, slika_path, id_sadrzaj) 
			Values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", k.BrojStranica, k.Cijena, k.Nakladnik, k.Jezik, k.Tagovi, k.SlikaPath, k.Id);

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

				k.IdK = (int)(Int64)reader["id"];
				k.Opis = (string)reader["opis"];
				k.Naziv = (string)reader["naziv"];
				k.BrojStranica = (int)(Int64)reader["broj_stranica"];
				k.Cijena = (int)(double)reader["cijena"];
				k.Nakladnik = (string)reader["nakladnik"];
				k.Jezik = (string)reader["jezik"];
				k.Tagovi = (string)reader["tagovi"];
				k.SlikaPath = (string)reader["slika_path"];

				listaKnjiga.Add(k);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaKnjiga;
		}
	}
}
