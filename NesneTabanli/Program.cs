// See https://aka.ms/new-console-template for more information
/*using NesneTabanli;

Home ev = new Home();

ev.odasayisi = 4;
ev.kapinumarasi = 5;
ev.adres = "istanbul";
Console.WriteLine("oda sayisi " + ev.odasayisi + " evin adresi " + ev.adres);
ev.yazdir();

Home alihaninevi = new Home(4,5,"istanbul");

alihaninevi.odasayisi = 4;
alihaninevi.kapinumarasi = 5;
alihaninevi.adres = "istanbul";
Console.WriteLine("oda sayisi " + alihaninevi.odasayisi + " evin adresi " + alihaninevi.adres);
alihaninevi.yazdir();

Home mustafaninevi = new Home(3,7,"ankara");
mustafaninevi.odasayisi = 3;
mustafaninevi.kapinumarasi = 7;
mustafaninevi.adres = "ankara";
Console.WriteLine("oda sayisi " + mustafaninevi.odasayisi + " evin adresi " + mustafaninevi.adres);
mustafaninevi.yazdir();
*/

/*
using NesneTabanli;


Cars car = new Cars();

car.brand = "audi";
car.model = "R8";
car.year = 2018;

Console.WriteLine("arabanın markası " + car.brand + " arabanın modeli " + car.model + " arabanın yılı " + car.year);
car.Yazdir();


Cars alihaninarabasi = new Cars();

alihaninarabasi.brand = "mini";
alihaninarabasi.model = "cooper";
alihaninarabasi.year = 2021;

Console.WriteLine("arabanın markası " + alihaninarabasi.brand + " arabanın modeli " + alihaninarabasi.model + " arabanın yılı " + alihaninarabasi.year);
alihaninarabasi.Yazdir();

Cars fonk = new Cars("bmw", "520d", 2017);
Console.WriteLine("arabanın markası " + fonk.brand + " arabanın modeli " + fonk.model + " arabanın yılı " + fonk.year);
fonk.Yazdir();
*/

/*
using NesneTabanli;

Telephone tele = new Telephone();

Console.WriteLine("Lütfen istediğiniz telefonun markasını giriniz");

tele.brand = Console.ReadLine();
Console.WriteLine(" ");


Console.WriteLine("lütfen seçmek istediğiniz modeli girin");

tele.model = Console.ReadLine();
Console.WriteLine(" ");



Console.WriteLine("lütfen seçmek istediğiniz yılı girin");

tele.syear = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" ");




Console.WriteLine(" telefonun markası " + tele.brand + " telefonun modeli " + tele.model + " telefonun yılı " + tele.syear);
tele.Yazdir();

*/


/*
using NesneTabanli;


Telephone ali = new Telephone("apple","iphone",2023);


Console.WriteLine("telefonun markası " + ali.brand + "telefonun modeli " + ali.model + " telefonun yılı " + ali.syear);

ali.Yazdir();


*/







/*
using NesneTabanli;


Console.WriteLine("Lütfen istediğiniz telefonun markasını giriniz");


Telephone tel = new Telephone();
tel.brand = Console.ReadLine();


if(tel.brand == "apple")
{
    Console.WriteLine("Lütfen istediğiniz telefonun modelini seçiniz");
    Console.WriteLine("1 : 15 Pro Max");
    Console.WriteLine("2 : 15 Pro");
    Console.WriteLine("3 : 15 Plus");

    Telephone.Telefonlar tl = (Telephone.Telefonlar)Convert.ToInt32(Console.ReadLine());


    switch (tl)
    {




        case Telephone.Telefonlar.pro:


            tel.syear = 2023;
            Console.WriteLine("elimzide kalan model yılı " + tel.syear);

            break;

        case Telephone.Telefonlar.pro2:

            tel.syear = 2022;
            Console.WriteLine("elimzide kalan model yılı " + tel.syear);

            break;

        case Telephone.Telefonlar.pro3:

            tel.syear = 2023;
            Console.WriteLine("elimzide kalan model yılı " + tel.syear);
            break;


        default:

            break;
    }

}
else
{
    Console.WriteLine("lütfen geçerli bir marka giriniz");
}


using NesneTabanli;
internal class Program
{
    private static void Main(string[] args)
    {
        {


            Bina genel = new Bina();


            Console.WriteLine("kapıya hoşgeldiniz öncelikle lütfen nerde olduğunuzu görmek için 1 e basınız");
            Console.WriteLine(" ");

            genel.sum = Convert.ToInt32(Console.ReadLine());


            if (genel.sum == 1)
            {
                genel.adres = "istanbul/Levent";
                genel.binaadi = "beyza";
                genel.binano = 38;

                Console.WriteLine("adres: " + genel.adres + "  bina adı: " + genel.binaadi + "  bina no: " + genel.binano);
                genel.Yazdir();
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine("yanlış bina veya adres");
                Console.WriteLine(" ");
                Console.WriteLine("iyi günler dileriz");
            }

            Bina.daireler sec = new Bina.daireler();
            

            Console.WriteLine("lütfen zilini çalmak ve bilgilerini görmek istediğiniz daireyi seçiniz");
            Console.WriteLine("");

            Console.WriteLine("1:Alihan uslu");
            Console.WriteLine("");

            Console.WriteLine("2:Ahmet tandoğan");
            Console.WriteLine("");


            Console.WriteLine("3:Ömer faruk sanal");
            Console.WriteLine("");

            Console.WriteLine("4:Mustafa akdal");
            Console.WriteLine("");


            Console.WriteLine("5:Leyla pamuk");
            Console.WriteLine("");

            Console.WriteLine("6:Deniz okumuş");
            Console.WriteLine("");

            sec = (Bina.daireler)(Convert.ToInt32(Console.ReadLine()));

            switch (sec)
            {

                case Bina.daireler.daire:
                    Bina alihan = new Bina();

                    alihan.adres = "birinci kat sağ taraf ";
                    Console.WriteLine(" ");
                    Console.WriteLine(alihan.adres);
                    Console.WriteLine(" ");
                    alihan.Yazdir1();
                    break;


                case Bina.daireler.daire2:
                    Bina ahmet = new Bina();

                    ahmet.adres = "birinci kat sol taraf ";
                    Console.WriteLine(" ");
                    Console.WriteLine(ahmet.adres);
                    Console.WriteLine(" ");
                    ahmet.Yazdir1();
                   
                    break;


                case Bina.daireler.daire3:
                    Bina omer = new Bina();

                    omer.adres = "ikinci kat sağ taraf ";
                    Console.WriteLine(" ");
                    Console.WriteLine(omer.adres);
                    Console.WriteLine(" ");
                    omer.Yazdir1();
                    break;


                case Bina.daireler.daire4:
                    Bina mustafa = new Bina();

                    mustafa.adres = "ikinci kat sol taraf ";
                    Console.WriteLine(" ");
                    Console.WriteLine(mustafa.adres);
                    Console.WriteLine(" ");
                    mustafa.Yazdir1();
                    break;


                case Bina.daireler.daire5:
                    Bina leyla = new Bina();

                    leyla.adres = "üçüncü kat sağ taraf ";
                    Console.WriteLine(" ");
                    Console.WriteLine(leyla.adres);
                    Console.WriteLine(" ");
                    leyla.Yazdir1();
                    break;


                case Bina.daireler.daire6:
                    Bina deniz = new Bina();

                    deniz.adres = " üçüncü kat sol taraf ";
                    Console.WriteLine(" ");
                    Console.WriteLine(deniz.adres);
                    Console.WriteLine(" ");
                    deniz.Yazdir1();
                    break;


                default:
                    break;

            }

            Bina selam = new Bina(6, "beyzanur", "ankara");

            Console.WriteLine("bina no : " + selam.binano);

        }
    }
}


5 masa var masalara git    menüde çay ayran  ıhlamur kuşburnu latte espresso americano makarna pizza köfte patates hamburger 
1.  1Masadan kahve. Al
2.  2Masadan patates ve köfte
3.  3Çay
4. 4Ayran
5  5hesap istedi 
*/

using NesneTabanli;
internal class Program
{
    private static void Main(string[] args)
    {

        {
            Console.WriteLine("Kafemize Hoşgeldiniz Lütfen Gördüğünüz Boş Alanları Tercih Ediniz");
            Console.WriteLine(" ");

            Cafe cafe = new Cafe();
            
            
            Console.WriteLine("lütfen seçmek isteiğiniz masayı belirtiniz");
            Console.WriteLine(" ");
            Console.WriteLine("NOT : Sadece 1 den 5 e kadar numaralı masalarımız müsaittir.");
            Console.WriteLine(" ");
            Console.WriteLine("Lütfen bir Masa Numarası seçiniz");

            Cafe.Cafelermasa masalar = new Cafe.Cafelermasa();

            masalar = (Cafe.Cafelermasa)(Convert.ToInt32(Console.ReadLine()));

            switch (masalar)
               

                {
                case Cafe.Cafelermasa.masa1:

                        Console.WriteLine("menüden ne sipariş vermek istersiniz");
                        Console.WriteLine(" ");

                        do
                        {

                            Console.WriteLine("espresso 6");
                            Console.WriteLine(" ");


                            Console.WriteLine("latte 5");
                            Console.WriteLine(" ");


                            Console.WriteLine("americano 7");
                            Console.WriteLine(" ");

                            Cafe.Cafeler num = new Cafe.Cafeler();
                            num = (Cafe.Cafeler)(Convert.ToInt32(Console.ReadLine()));



                            switch (num)
                            {
                                case Cafe.Cafeler.espresso:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("espressonuz getiriliyor");
                                    Console.WriteLine(" ");

                                    break;

                                case Cafe.Cafeler.latte:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("latteniz getiriliyor");
                                    Console.WriteLine(" ");

                                    break;


                                case Cafe.Cafeler.americano:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("americanonuz getiriliyor");
                                    Console.WriteLine(" ");

                                    break;
                            }

                        }

                        while (false);

                        break;

                    case Cafe.Cafelermasa.masa2:


                        Console.WriteLine("menüden ne sipariş vermek istersiniz");
                        Console.WriteLine(" ");

                        do
                        {

                            Console.WriteLine("makarna 8");
                            Console.WriteLine(" ");


                            Console.WriteLine("pizza 9");
                            Console.WriteLine(" ");


                            Console.WriteLine("patates köfte 10");
                            Console.WriteLine(" ");

                            Cafe.Cafeler num = new Cafe.Cafeler();
                            num = (Cafe.Cafeler)(Convert.ToInt32(Console.ReadLine()));



                            switch (num)
                            {
                                case Cafe.Cafeler.makarna:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("makarnanız getiriliyor");
                                    Console.WriteLine(" ");

                                    break;

                                case Cafe.Cafeler.patateskofte:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("patates köfteniz getiriliyor");
                                    Console.WriteLine(" ");

                                    break;


                                case Cafe.Cafeler.pizza:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("pizzanız getiriliyor");
                                    Console.WriteLine(" ");

                                    break;
                            }

                        }

                        while (false);

                        break;



                    case Cafe.Cafelermasa.masa3:



                        Console.WriteLine("menüden ne sipariş vermek istersiniz");
                        Console.WriteLine(" ");

                        do
                        {

                            Console.WriteLine("ıhlamur 3");
                            Console.WriteLine(" ");


                            Console.WriteLine("kuşburnu 4");
                            Console.WriteLine(" ");


                            Console.WriteLine("çay 1");
                            Console.WriteLine(" ");

                            Cafe.Cafeler num = new Cafe.Cafeler();
                            num = (Cafe.Cafeler)(Convert.ToInt32(Console.ReadLine()));



                            switch (num)
                            {
                                case Cafe.Cafeler.ihlamur:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("ıhlamurunuz getiriliyor");
                                    Console.WriteLine(" ");

                                    break;

                                case Cafe.Cafeler.cay:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("çayınız getiriliyor");
                                    Console.WriteLine(" ");

                                    break;


                                case Cafe.Cafeler.kusburnu:

                                    Console.WriteLine(" ");
                                    Console.WriteLine("kuşburnunuz getiriliyor");
                                    Console.WriteLine(" ");

                                    break;
                            }

                        }

                        while (false);

                        break;

                case Cafe.Cafelermasa.masa4:

                    Console.WriteLine("maalesef bu masamız doludur");

                    break;

                    


                    case Cafe.Cafelermasa.masa5:

                        do
                        {
                            Console.WriteLine("menüden ne sipariş vermek istersiniz");
                            Console.WriteLine(" ");

                            cafe.Yazmak();

                        }
                        while (false);

                        break;

                    }



                }



            }
                
        
}
