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






