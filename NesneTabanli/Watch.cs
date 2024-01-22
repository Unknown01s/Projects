using System;
namespace NesneTabanli
{
	public class Watch
	{
        public string Brand;
        public string Type;
        public int Pressure { get; set; }
        private int price;



        public void setBrand(string Brand)
        {
            this.Brand = Brand;

        }
        public void setType(string Type)
        {
            this.Type = Type;

        }
        public void setprice(int price)
        {
            this.price =price;

        }


        public string getBrand()
        {
            return Brand;
        }
        public string getType()
        {
            return Type;
        }
        public int getprice()
        {
            return price;
        }

        public enum Watchs
        {
            seiko = 1,
            tissot =2,
        

        }

           



    }
}

