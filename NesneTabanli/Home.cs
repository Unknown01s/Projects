using System;
namespace NesneTabanli
{
	public abstract class Home
	{
		public int odasayisi;
		public int kapinumarasi;
		public string adres;

		public abstract void yazdir();
		
	public Home(int odasayisi, int kapinumarasi, string adres)
		{
			this.odasayisi = odasayisi;
			this.kapinumarasi = kapinumarasi;
			this.adres = adres;
		}
	
	}
}

