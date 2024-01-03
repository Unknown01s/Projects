using System;
using System.Runtime.ConstrainedExecution;

namespace NesneTabanli
{
	public class Cars
	{
		public string brand;

		public int year;

        public string model;

        public void Yazdir()
        {
            //Console.WriteLine("arabanın markası " + .brand + " arabanın modeli " +.model + " arabanın yılı " + .year);
            Console.WriteLine("arabanızın geri kalan bilgilerini detaylı öğrenmek içimn sayfamızı ziyaret edin");
        }
        public Cars(string brand, string model, int year)
        {
            this.brand = brand;
            this.year = year;
            this.model = model;

        }
public Cars()
        {

        }
    }


}

