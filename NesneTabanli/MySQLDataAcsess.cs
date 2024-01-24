using System;
namespace NesneTabanli
{
    public class MySQLDataAcsess : IDataAcsessRepostory
    {
        public void Ekle()
        {
            Console.WriteLine("MySQL Ekleme Başarılı");
        }

        public void Guncelle()
        {
            Console.WriteLine("MySQL Güncelleme Başarılı");
        }

        public void Sil()
        {
            Console.WriteLine("MySQL Silme Başarılı");
        }

        public void Sorgula()
        {
            Console.WriteLine("MySQL Sorgulama Başarılı");
        }


    }
}

