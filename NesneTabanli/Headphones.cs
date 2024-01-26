using System;
namespace NesneTabanli
{
	public class Headphones
	{
		public string brand { get; set; }
		public string Model;
		private int Price;
		public string frequency;
		private int Hz;

		public void setfrequency(string frequency)
		{
			this.frequency = frequency;

		}

		public string getfrequency()
		{
			return frequency;
		}


		public void setHz(int Hz)
		{
			

			if (Hz < 0)
			{
				Console.WriteLine("please enter the reedable value");
			}
			else
			{
                this.Hz = Hz;
            }
		}


		public int getHz()
		{
			return Hz;

		}




	public string getModel()
		{
			return Model;

		}

		public void setModel(string model)
		{
			this.Model = model;

		}

		public void setPrice(int price)
		{
			this.Price = price;


		}

		public int getPrice()
		{
			return Price;
		}




		public Headphones()
		{

		}

		public Headphones (string brand, string model, int price)
		{
			this.brand = brand;
			this.Model = Model;
			this.Price = Price;

		}


		public enum siralama
		{

			apple = 1,
			samsung =2,
			huawei=3,
			xiomi=4

		}

		public virtual void vir1()
		{

			Console.WriteLine("bu bir Headphones clası voididir");
		}


	}
}

