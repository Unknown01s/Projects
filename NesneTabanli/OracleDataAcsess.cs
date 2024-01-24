using System;
namespace NesneTabanli
{
    public class OracleDataAcsess : IDataAcsessRepostory
    {
        public void Ekle()
        {
            Console.WriteLine("Oracle Ekleme Başarılı");
        }

        public void Guncelle()
        {
            Console.WriteLine("Oracle Güncelle Başarılı");
        }

        public void Sil()
        {
            Console.WriteLine("Oracle Sil Başarılı");
        }

        public void Sorgula()
        {
            Console.WriteLine("Oracle Sorgula Başarılı");
        }

    }
}

