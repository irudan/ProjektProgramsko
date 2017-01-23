using System;
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

			BP.zatvoriKonekciju();
		}

		public static List<long> DohvatiSve(long id, long idS)
		{
			List<long> listaNaplata = new List<long>();

			BP.otvoriKonekciju();

			SqliteCommand command = BP.konekcija.CreateCommand();

			command.CommandText = String.Format("Select * from naplata where id_korisnik = '{0}' and id_sadrzaj = '{1}'", id, idS);

			SqliteDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				int n = (int)(Int64)reader["id"];

				listaNaplata.Add(n);
			}

			reader.Dispose();
			command.Dispose();

			BP.zatvoriKonekciju();

			return listaNaplata;
		}
	}
}
