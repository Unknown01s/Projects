using System;
namespace NesneTabanli
{
	public class Telephone : Headphones
	{
		public string model;
		public string brand;
		public int syear;

		//int one = 1;
		//int two = 2;
		//int three = 3;


		public void Yazdir()
		{
			Console.WriteLine(" ");
			Console.WriteLine(" daha fazla bilgi için websitemizi ziyaret edin ");
		}

		public Telephone(string model, string brand, int syear) : base(brand,model,syear)
		{
			this.brand = brand;
			this.model = model;
			this.syear = syear;

			this.Model = Model;// Headphones değişkeni 
		}
		public Telephone()
		{

		}

		public enum Telefonlar
		{
			pro = 1,
			pro2 = 2,
			pro3 = 3,
		}

        public override void vir1()
        {
			Console.WriteLine("bu bir Telephone voididir");
        }


		

    }
	

}

