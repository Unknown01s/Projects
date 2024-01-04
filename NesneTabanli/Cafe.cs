using System;
namespace NesneTabanli
{
	public class Cafe
	{
		public string yemek;
		public string caylar;
		public string kahveler;
		public string icecekler;

		public void Yazmak()
		{
			Console.WriteLine(" ");
			Console.WriteLine("hesap getiriliyor");


		}



      public Cafe(string yemek, string caylar, string kahveler, string icecekler)
		{
			this.yemek = yemek;
			this.caylar = caylar;
			this.kahveler = kahveler;
			this.icecekler = icecekler;
		}


		public Cafe()
		{

		}

		public void Yazma1()
		{


			// ?


		}


		public enum Cafeler
		{
			cay = 1,
			ayran = 2,
			ihlamur = 3,
			kusburnu = 4,
			latte = 5,
			espresso = 6,
			americano = 7,
			makarna = 8,
			pizza = 9,
			patateskofte = 10		
		}

		public enum Cafelermasa
		{

		masa1 = 1,
		masa2 = 2,
		masa3 = 3,
		masa4 = 4,
		masa5 = 5,



		}		

    }


}

