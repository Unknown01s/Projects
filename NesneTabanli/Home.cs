using System;
namespace NesneTabanli
{
	public class Home
	{
		public int odasayisi;
		public int kapinumarasi;
		public string adres;

		public void yazdir()
		{
			Console.WriteLine("bu bir evdir");

		}
	public Home(int odasayisi, int kapinumarasi, string adres)
		{
			this.odasayisi = odasayisi;
			this.kapinumarasi = kapinumarasi;
			this.adres = adres;
		}
	public Home()
		{

		}
	}
}

