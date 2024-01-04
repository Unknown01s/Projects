using System;
namespace NesneTabanli
{
	public class Bina
	{
		public int binano;
		public string binaadi;
		public string adres;
		public int sum;

		public void Yazdir1()
		{
			Console.WriteLine("");
			Console.WriteLine("zil çalınıyor");


		}





		public void Yazdir()
		{
			Console.WriteLine(" ");
			Console.WriteLine("binamıza hoşgeldiniz");
			
		}




        public Bina(int binano, string binaadi, string adres)
		{
			this.binano = binano;
			this.binaadi = binaadi;
			this.adres = adres;

		}

		public Bina()
		{

		}

		public enum daireler
		{
			daire = 1,
			daire2 = 2,
			daire3 = 3,
			daire4 = 4,
			daire5 = 5,
			daire6 = 6
		}

    }
	
	
}

