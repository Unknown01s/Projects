using System;
namespace NesneTabanli
{
	public class Computer
	{
		public string Brand;// değişken tanımlama 
		public string Software;
		public int Price;
		public int ram;
		public static string madeof;

		public void yazdir()
		{

			switch (Brand)
			{

				case "Apple":

					Console.WriteLine("MacBook Air");

					break;


				case "Asus":
					Console.WriteLine("VivoBook X5");

					break;

			}

			Console.WriteLine("bilgisayarınızın özelliklerine erişmek için lütfen daha fazla bilgi giriniz");

		}


		public static void yazdirs()
		{

			Console.WriteLine("bu bir static fonksiyondur");
		}




		public Computer(string Brand,string Software,int Price)
		{
			this.Brand = Brand;
			this.Software = Software;
			this.Price = Price;
		}

		public Computer()
		{

		}


		public void setram()
		{
			this.ram = 16;

		}

		public int getram()
		{
			return ram;
		}


		public virtual void yazdirvis()
		{
			Console.WriteLine("test 1-2");

		}

	
	

	}
}

