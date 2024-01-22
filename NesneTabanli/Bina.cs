using System;
namespace NesneTabanli
{
	public class Bina
	{
		private int binano;
		public string Binaadi { get; set; }
		
		private string adres;
		public int Sum { get; set; }

		public void Yazdir1()
		{
			Console.WriteLine("");
			Console.WriteLine("zil çalınıyor");


		}


		public int getBinano()
		{
			return binano;
		}

		public void setBinano(int binano)
		{
			if (binano > 0)
			{
                this.binano = binano;
            }
			else
			{
				Console.WriteLine("bina numarası 1 den küçük olamaz");
			}
			
		}

		public void Yazdir()
		{
			Console.WriteLine(" ");
			Console.WriteLine("binamıza hoşgeldiniz");
			
		}

		public string getAdres()
		{
			return adres;
		}

		public void setAdres(string adres)
		{
			this.adres = adres;
		}

        public Bina(int binano, string binaadi, string adres)
		{
			this.binano = binano;
			this.Binaadi = binaadi;
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

