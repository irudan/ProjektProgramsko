using System;
namespace ProjektProgramsko
{
	public class IzdanjeCasopis
	{
		private long id;
		private long idC;
		private string datum;
		private int brojIzdanja;
		private double cijena;
		private string slikaPath;
		private string pdfPath;
		private long brojProdanih;

		public IzdanjeCasopis()
		{
			brojProdanih = 0;
		}

		public int BrojIzdanja
		{
			get
			{
				return brojIzdanja;
			}

			set
			{
				brojIzdanja = value;
			}
		}

		public double Cijena
		{
			get
			{
				return cijena;
			}

			set
			{
				cijena = value;
			}
		}

		public string Datum
		{
			get
			{
				return datum;
			}

			set
			{
				datum = value;
			}
		}

		public string SlikaPath
		{
			get
			{
				return slikaPath;
			}

			set
			{
				slikaPath = value;
			}
		}

		public long Id
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
			}
		}

		public long BrojProdanih
		{
			get
			{
				return brojProdanih;
			}

			set
			{
				brojProdanih = value;
			}
		}

		public long IdC
		{
			get
			{
				return idC;
			}

			set
			{
				idC = value;
			}
		}

		public string PdfPath
		{
			get
			{
				return pdfPath;
			}

			set
			{
				pdfPath = value;
			}
		}
	}
}
