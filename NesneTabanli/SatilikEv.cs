using System;
namespace NesneTabanli
{
	public class SatilikEv : Home
	{


		public SatilikEv(int odasayisi,int kapinumrasi,string adres) : base(odasayisi, kapinumrasi, adres)
		{

		}


        public override void yazdir()
        {


			Console.WriteLine("bu bir satılık evdir");


        }



    }
}

