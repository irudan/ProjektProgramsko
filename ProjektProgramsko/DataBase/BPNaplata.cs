﻿using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

namespace ProjektProgramsko
{
	public static class BPNaplata 
	{
		public static void spremiKartica(Kartica k, long idS, long idK)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into naplata (iznos, id_korisnik, id_sadrzaj) Values ('{0}', '{1}', '{2}')", 
			                                    k.Iznos, idK, idS);
			
			command.ExecuteNonQuery();

			long idNaplata = new long();

			command.CommandText = "Select id from naplata order by id desc";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				idNaplata = (int)(Int64)reader["id"];
				break;
			}

			reader.Dispose();


			command.CommandText = String.Format(@"Insert into kartica (broj_kartice, datum_isteka, ime_vlasnika, prezime_vlasnika, id_naplata) 
			Values ('{0}', '{1}', '{2}', '{3}', '{4}')", k.Brojkartice, k.Datumisteka, k.Imevlasnika, k.Prezimevlasnika, idNaplata);

			command.ExecuteNonQuery();

			command.Dispose();

			povecajProdano(idS);

			BP.zatvoriKonekciju();
		}

		public static void spremiPayPal(PayPal p, long idS, long idK)
		{
			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Insert into naplata (iznos, id_korisnik, id_sadrzaj) Values ('{0}', '{1}', '{2}')",
												p.Iznos, idK, idS);

			command.ExecuteNonQuery();

			long idNaplata = new long();

			command.CommandText = "Select id from naplata order by id desc";

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				idNaplata = (int)(Int64)reader["id"];
				break;
			}

			reader.Dispose();


			command.CommandText = String.Format(@"Insert into paypal (username, id_naplata) 
			Values ('{0}', '{1}')", p.User, idNaplata);

			command.ExecuteNonQuery();

			command.Dispose();

			povecajProdano(idS);

			BP.zatvoriKonekciju();
		}

		public static List<Naplata> DohvatiSve(long id, long idS)
		{
			List<Naplata> listaNaplata = new List<Naplata>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Select * from naplata where id_korisnik = '{0}' and id_sadrzaj = '{1}'", id, idS);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Naplata n = new Naplata();

				n.Id = (int)(Int64)reader["id"];

				listaNaplata.Add(n);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaNaplata;
		}

		public static void povecajProdano(long idS)
		{
			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format(@"Update knjiga set broj_prodanih = broj_prodanih + 1 where id_sadrzaj = '{0}'", idS);

			command.ExecuteNonQuery();


			command.CommandText = String.Format(@"Update film set broj_prodanih = broj_prodanih + 1 where id_sadrzaj = '{0}'", idS);

			command.ExecuteNonQuery();


			command.CommandText = String.Format(@"Update izdanje_casopis set broj_prodanih = broj_prodanih + 1 where id = '{0}'", idS);

			command.ExecuteNonQuery();


			command.Dispose();
		}
	}
}
