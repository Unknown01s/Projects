// See https://aka.ms/new-console-template for more information
// deger tipli degiskenler

#region ilk ders
using hello;

int sayi = 4;
double sayi1 = 10.2;
float sayi2 = 10.2f;
long sayi3 = 1000000;
decimal sayi4 = 2000000;
char karakter = 'a';
bool dogru_mu = 1==2;

Console.WriteLine(dogru_mu);

// referans tipli degiskenler
int[] sayilar = new int[3];
sayilar[0] = 2;
sayilar[1] = 4;
//sayilar[2] = 7;
Console.WriteLine(sayilar[0]);

char[] isim = new char[10];
isim[0] = 'a';
isim[1] = 'l';
isim[2] = 'i';
string isim1 = "ali";
Console.WriteLine(isim1);

string karaktersayi = "2";
Console.WriteLine(karaktersayi+1);
Console.WriteLine(sayi + 1);

double sayi5 = (double)sayi;
Console.WriteLine(sayi5);

int karaktertoint = (int)karakter;
Console.WriteLine(karaktertoint);

string sayistringi = "2";
int stringsayisi = Convert.ToInt32(sayistringi);
Console.WriteLine(stringsayisi+1);

string karaktersayi1 = sayi.ToString();
Console.WriteLine(karaktersayi1 + 1);


// değişken tanımlamalar ( değer tipliler ve kullanıcıdan istenik yapma)

int deger1 = 12;
char deger2 = 'z';
double deger4 = 12.2;
float deger5 = 12.2f;
long deger6 = 100000;
decimal deger7 = 2000000;
bool deger8 = 12 > 10;

Console.WriteLine(deger1);
Console.WriteLine(deger2);
Console.WriteLine(deger4);
Console.WriteLine(deger5);
Console.WriteLine(deger6);
Console.WriteLine(deger7);
Console.WriteLine(deger8);

// string değişkenini int değişkenine çevirme

string degery = "3";

int degerx = Convert.ToInt32(degery);

Console.WriteLine(degerx);

//referans tipli değişkenler

string degera = "lime";

int[] number = new int[2];

number[0] = 1;

number[1] = 2;

Console.WriteLine(number[0] + number[1]);


char[] words = new char[3];
words[0] = 'a';
words[1] = 'b';
words[2] = 'c';

Console.WriteLine(words[2]);










//?????

// kendi yorumlamaya çalıştığım şeyler

//Console.WriteLine("lütfen bir sayı giriniz:");

//string value = "3";

//int valuex = Convert.ToInt32(value);

//Console.ReadLine(value);


#endregion

int degiskensayi = 6;

if (degiskensayi % 2 == 0)
{
    Console.WriteLine("çift sayıdır.");
}
else
{
    Console.WriteLine("tek sayıdır.");
}

//Console.Write("Lütfen bir gün giriniz: ");

//string gun = Console.ReadLine();

/*if (gun == "pazartesi")
{
    Console.WriteLine("bugün pazartesi");
}
else if (gun == "salı")
{
    Console.WriteLine("bugün salı");
}
else if (gun == "çarşamba")
{
    Console.WriteLine("bugün çarşamba");
}
else if (gun == "perşembe")
{
    Console.WriteLine("bugün perşembe");
}
else if(gun == "cuma")
{
    Console.WriteLine("bugün cuma");
}
else if(gun == "cumartesi")
{
    Console.WriteLine("bugün cumartesi");
}
else if(gun == "pazar")
{
    Console.WriteLine("bugün pazar");
}
else
{
    Console.WriteLine("lütfen bir gün değeri giriniz");
}*/

//string gun = "çarşamba";
/*Console.WriteLine("Bir gün seçin");
Console.WriteLine("0 Pazartesi");
Console.WriteLine("1 Salı");


Gunler.GunlerEnum gunler = (Gunler.GunlerEnum)Convert.ToInt32(Console.ReadLine());




//switch-case
switch (gunler)
{
    case Gunler.GunlerEnum.Pazartesi:
        Console.WriteLine("Bugün pazartesi");
        break;
    case Gunler.GunlerEnum.Sali:
        Console.WriteLine("Bugün Salı");
        break;
    case Gunler.GunlerEnum.Carsamba:
        Console.WriteLine("bugün çarşmaba");
        break;
    case Gunler.GunlerEnum.Persembe:
        Console.WriteLine("bugün perşembe");
        break;
    case Gunler.GunlerEnum.Cuma:
        Console.WriteLine("bugün cuma");
        break;
    case Gunler.GunlerEnum.Cumartesi:
        Console.WriteLine("bugün cumartesi");
        break;
    case Gunler.GunlerEnum.Pazar:
        Console.WriteLine("bugün pazar");
        break;
  default:   
        Console.WriteLine("lütfen geçerli bir gün giriniz");
        break;
}



// değeri değer referansı referans tipine ederken böyle

int sayi10 = 2;
double sayi11 = 0;

sayi11 = (double)sayi10;

*/







/* kullanıcının girdiği değeri tek mi çift mi diye ayırma

// öncelikle kullanıcıdan değer istememiz lazım

Console.WriteLine("programa hoşgeldiniz lütfen bir sayı değeri giriniz:");

// kullanıcı değeri girmesi için parametreleri eşitlememiz lazım burda değer ve referansı eşitledik

int kullanıcıdegeri = Convert.ToInt32(Console.ReadLine());

//sonra ise kullanıcının girdiği değeri tek mi çift mi diye ayırabilmemiz için koşul parametresi kullanmamız lazım

if(kullanıcıdegeri % 2 == 0)
{
    Console.WriteLine("girdiğiniz sayı çift sayıdır.");
}
else
{
    Console.WriteLine("girdiğiniz sayı tek sayıdır.");
}

// sonrasında ise yorum katarak dün ki derselerden tekrar yapıp bir sayı tanımlayıp toplama işlemi yapalım

int sum1 = 3;

double sum2 = (double)sum1; // aynı değer parametrelerini çevirerek ondalıklı sayı elde edelim 

double sum3 = sum2 + kullanıcıdegeri;

Console.WriteLine(sum3); //sonucumuz burda çıkıcaktır
*/



 /*switch case ile tool bar menüsü seçme yapmaya çalışıcağım

Console.WriteLine("masaüstüne hoşgeldiniz lütfen yapmak istediğiniz işlemi seçiniz");// kullanıcıdan seçim yapması için çıktı üretiyorum
Console.WriteLine("bilgisayarım: 1");
Console.WriteLine("indirilenler: 2");
Console.WriteLine("terminal: 3");
Console.WriteLine("oyunlar: 4");
Console.WriteLine("safari: 5");

string kullanıcıislemi = Console.ReadLine(); //sadece sayı seçeceğimiz için string tipi sayıyıda tutabilir


//int kısayol = Convert.ToInt32(kullanıcıislemi); ??





switch (kullanıcıislemi) // switch case yazarak işlem seçtiriyoruz ayrıca sayı değerleri ile işlemi kısaltıp hata yapımını azaltıyoruz
{

    case ("1"):
        Console.WriteLine("bilgisayarıma hoşgeldiniz");
        break;

    case ("2"):
        Console.WriteLine("indirilenlere hoşgeldiniz");
        break;

    case ("3"):
        Console.WriteLine("terminale hoşgeldiniz");
        break;

    case ("4"):
        Console.WriteLine("oyunlara hoşgeldiniz");
        break;

    case ("5"):
        Console.WriteLine("safariye hoşgeldiniz");
        break;

        default:
        Console.WriteLine("lütfen geçerli bir işlem yapın"); // int değere çevirdiğimizde yapabilir miyiz bakalım 
        break;


}
 */




//public class ve enum deniyerek seçim şansı yapma
Console.WriteLine("lütfen bir araba markası seçimiz");
Console.WriteLine("1 : ford");
Console.WriteLine("2 : nissan");
Console.WriteLine("3 : seat");
Console.WriteLine("4 : skoda");
Console.WriteLine("5 : mercedes");
Console.WriteLine("6 : bmw");



Car.Cars araba = (Car.Cars)Convert.ToInt32(Console.ReadLine());



switch (araba)
{
    case Car.Cars ford:
        Console.WriteLine("seçtiğiniz araç : ford");
        break;

    case Car.Cars nissan :
        Console.WriteLine("seçtiğiniz araç : nissan");
        break;

    case Car.Cars seat :
        Console.WriteLine("seçtiğiniz araç :seat");
        break;


    case Car.Cars skoda :
        Console.WriteLine("seçtiğiniz araç : skoda");
        break;

    case Car.Cars mercedes :
        Console.WriteLine("seçtiğiniz araç : mercedes");
        break;

    case Car.Cars bmw :
        Console.WriteLine("seçtiğiniz araç : bmw");
        break;
    default:



}

//hocaya sor */































