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