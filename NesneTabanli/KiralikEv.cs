using System;
namespace NesneTabanli
{
	public class KiralikEv : Home
	{

public int KiraBedeli { get; set; }


		public KiralikEv(int odasayisi,int kapinumarasi,string adres):base(odasayisi,kapinumarasi,adres)
		{




		}
		public override void yazdir()
		{
			Console.WriteLine("bu bir kiralık evdir");

		}

    }
}

