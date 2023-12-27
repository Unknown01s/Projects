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

*/
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





















    }
}





