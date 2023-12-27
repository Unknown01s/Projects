// See https://aka.ms/new-console-template for more information
// deger tipli degiskenler
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



