import javax.sound.midi.Soundbank;
import javax.swing.*;
import java.awt.*;
import java.net.SocketTimeoutException;
import java.net.StandardSocketOptions;
import java.sql.SQLOutput;
import java.util.Scanner;
import java.util.SortedMap;//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    enum Gunler{
        pazartesi,
        sali,
        carsamba,
        persembe,
        cuma,
        cumartesi,
        pazar
    }
    enum Caseler {
        tekcift,
        birineksigi,
        karsılama,
        gunler

    }


    public static void main(String[] args) {
        /*
        int sayi = 4;
        double sayi1 = 11.2;
        float sayi2 = 11.2f;
        char sayi3 = 'a';
        String isim = "alihan";

        int[] sayilar = new int[3];
        sayilar[0] = 2;
        sayilar[1] = 3;
        sayilar[2] = 4;

            System.out.println(sayilar[0]);

        System.out.println(isim);
        System.out.println(sayi3);
        System.out.println(sayi2);
        System.out.println(sayi1);
        System.out.println(sayi);
        System.out.println("hello world");


        // değer tipli veri
        int value1 = 12;
        double value2 = 12.20;
        float value3 = 12.21f;
        char value4 = 's';

/* referans tipli değişkenler
        string value5 = "hello";

        int[] values = new int[5];

        values[0] = 1;
        values[1] = 2;
        values[2] = 3;
        values[3] = 4;
        values[4] = 5;

        System.out.println(values[3]);
        System.out.println(value1);
        System.out.println(value3);



        String sayi = "2";
        System.out.println(sayi + 1);
        int sayi1 = Integer.parseInt(sayi);
        System.out.println(sayi1 + 1);
        int sayi2 = 5;

        String sayi3 = String.valueOf(sayi2);
        System.out.println(sayi2 + 1);


        System.out.print("lütfen isminizi giriniz: " );
        Scanner tarayici = new Scanner(System.in);

        String isim = tarayici.nextLine();
        System.out.print("selamlar " + isim);

        System.out.println("lütfen bir sayı değeri giriniz: ");
        int sayi = tarayici.nextInt();
        System.out.println("girdiğiniz sayı değeri: " + sayi);


        Scanner scan = new Scanner(System.in);
        System.out.print("lütfen bir sayı değeri giriniz: ");
        int sayi = scan.nextInt();

        if (sayi % 2 == 0){
            System.out.print("girdiğiniz sayı değeri çifttir.");
        }
        else{
            System.out.print("girdiğiniz sayı değeri tektir.");
        }


        System.out.println("bir gün değeri tuşlayınız");
        System.out.println("pazartesi");
        System.out.println("salı");
        System.out.println("çarşaamba");

        Scanner scanner = new Scanner(System.in);

        Gunler gun = Gunler.values()[scanner.nextInt()];

        switch (gun){
            case pazartesi:
                System.out.print("bugün pazartesi.");
                break;
            case sali:
                System.out.println("bugün salı.");
                break;
            case carsamba:
                System.out.println("bugün carsamba");
                break;
            case persembe:
                System.out.println("bugün perşembe");
                break;
            case cuma:
                System.out.println("bugün cuma");
                break;
            case cumartesi:
                System.out.println("bugün cumartesi");
                break;
            case pazar:
                System.out.println("bugün pazar");
                break;
            default:
                System.out.println("doğru bir gün değeri giriniz");
                break;
        }

        System.out.println("programımıza hoşgeldiniz lütfen yapmak istediğiniz işlemi seçiniz");
        System.out.println("0: sayıların tek çift olduğunu öğrenme");
        System.out.println("1: girdiğiniz sayının bir eksiği");
        System.out.println("2: adınız ile karşılama");
        System.out.println("3: gününüzü belirleme");

      Scanner scanner = new Scanner(System.in);

      Caseler caseler = Caseler.values()[scanner.nextInt()];


        int sayi = 0;

        switch (caseler){

            case tekcift:
                System.out.println("lütfen bir sayı giriniz");
                sayi = scanner.nextInt();
                if(sayi % 2 == 0){
                    System.out.println("girdiğiniz sayı çifttir");
                }
                else {
                    System.out.println("girdiğiniz sayı tektir");
                }
                break;

            case birineksigi:
                System.out.println("bir sayı giriniz");
                sayi = scanner.nextInt();
                int ex = sayi - 1;
                System.out.println("girdiğiniz sayının bir eksiği:" + ex);
                break;

            case karsılama:
                System.out.println("lütfen adınızı giriniz");
                String name = scanner.next();
                System.out.println("hoşgeldiniz " + name);
                break;

            case gunler:
                System.out.println("pazartesi");
                System.out.println("salı");
                System.out.println("çarşamba");
                System.out.println("perşembe");
                System.out.println("cuma");
                System.out.println("cumartesi");
                System.out.println("pazar");

                Gunler gun = Gunler.values()[scanner.nextInt()];

                switch (gun){

                    case pazartesi:
                        System.out.println("bugün pazartesi");
                        break;

                    case sali:
                        System.out.println("bugün salı");
                        break;

                    case carsamba:
                        System.out.println("bugün çarşamba");
                        break;

                    case persembe:
                        System.out.println("bugün perşembe");
                        break;

                    case cuma:
                        System.out.println("bugün cuma");
                        break;

                    case cumartesi:
                        System.out.println("bugün cumartesi");
                        break;

                    case pazar:
                        System.out.println("bugün pazar");
                        break;

                    default:
                        System.out.println("lütfen geçerli bir gün giriniz");
                        break;

                }










        }


*/

       /* int i = 0;

        while (i<500){
            System.out.println("hello world");
            i++;

        }

        int[] dizi = new int[4];

        dizi[0] = 10;
        dizi[1] = 20;
        dizi[2] = 30;
        dizi[3] = 40;

        for(int i = 0; i<dizi.length;i++){
            System.out.println(dizi[i]);
        } */

        /* int[] dizi = new int[4];
        Scanner scanner = new Scanner(System.in);

        for(int i = 0; i<dizi.length; i = i + 2){
            System.out.print(i +1 + ". indeksli sayıyı giriniz: ");
            dizi[i] = scanner.nextInt();
        }
        //for(int i = 0; i< dizi.length; i++){
           // System.out.println(dizi[i]);
        // }

        //for each değer yazdırmak için
        for(int item: dizi){
            System.out.println(item);
        }
*/

Scanner scanner = new Scanner(System.in);

       do {
           System.out.println("lütfen bir gün giriniz");
           System.out.println("0: pazartesi");
           System.out.println("1: salı");
            Gunler gunler = Gunler.values()[scanner.nextInt()];

            if(gunler == Gunler.pazartesi){
                System.out.println("bugün pazartesi");

            }
            else if (gunler == Gunler.sali) {
                System.out.println("bugün salı");
            }
            else {
                System.out.println("sistemden çıkış yaptınız");
                break;
            }







            /*switch (gunler){

                case pazartesi:
                    System.out.println("bugün pazartesi");
                    break;

                case sali:
                    System.out.println("bugün salı");
                    break;
                default:
                    System.out.println("sistemden çıkış yaptınız");
                    break;
            }*/

       } while(true);















    }
}






