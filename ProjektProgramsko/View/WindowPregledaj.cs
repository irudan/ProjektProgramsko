using System;
using NReco.PdfRenderer;
using iTextSharp.text.pdf;
using Gtk;
using System.IO;

namespace ProjektProgramsko
{
	public partial class WindowPregledaj : Gtk.Window
	{
		public WindowPregledaj(string pdfPath, long idS, long id) :
				base(Gtk.WindowType.Toplevel)
		{
			this.Build();

			bool flag = false;

			DirectoryInfo d = new DirectoryInfo("C:\\temp");
			FileInfo[] Files = d.GetFiles("*.jpg");
			string str = "";
			foreach (FileInfo file in Files)
			{
				str = file.Name;

				if (str == String.Format("{0}{1}1.jpg", idS, id))
				{
					flag = true;
					break;
				}
			}

			string ppath = pdfPath;
			PdfReader pdfReader = new PdfReader(ppath);
			int numberOfPages = pdfReader.NumberOfPages;

			if (!flag)
			{
				var pdfFile = pdfPath;
				var pdfToImg = new NReco.PdfRenderer.PdfToImageConverter();
				pdfToImg.ScaleTo = 800;

				for (int i = 1; i <= numberOfPages; i++)
				{
					pdfToImg.GenerateImage(pdfFile, i,
										   ImageFormat.Jpeg, String.Format(@"C:\temp\{0}{1}.jpg", id, i));
				}

			}


			for (int i = 1; i <= numberOfPages; i++)
			{
				Image temp = new Image();

				var buffer = System.IO.File.ReadAllBytes(String.Format(@"C:\temp\{0}{1}.jpg", id, i));
				var pixbuf = new Gdk.Pixbuf(buffer);
				temp.Pixbuf = pixbuf;

				vbox1.Add(temp);
			}

			Build();
		}
	}
}
