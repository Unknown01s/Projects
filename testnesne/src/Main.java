import java.sql.Array;
import java.sql.SQLOutput;
import java.util.ArrayList;
import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public enum daireler{
        daire1,
        daire2,
        daire3,
        daire4,
        daire5,
        daire6
    }
public enum watchs{
        seiko,
    tissot,
    ;


}

    public static  void main(String[] args) {

/*
    Car araba = new Car();

    araba.model="mustang";
    araba.brand="ford";
    araba.year= 1968;

        System.out.println(araba.model);
        System.out.println(araba.brand);
        System.out.println(araba.year);



        Car araba = new Car("mustang","ford",1968);

        System.out.println(araba.model);
        System.out.println(araba.brand);
        System.out.println(araba.year);
        araba.Yazdir();



        Car araba = new Car();
        Scanner scanner =  new Scanner(System.in);

        System.out.println("Lütfen bir araba markası yazınız");
        araba.brand = scanner.next();

        System.out.println("lütfen girdiğiniz markanın modelini giriniz");
        araba.model = scanner.next();

        System.out.println("lütfen marka ve modelin yılını giriniz");
        araba.year = scanner.nextInt();

        System.out.println("arabanın markası : " +araba.brand);
        System.out.println(" ");

        System.out.println("arabanın modeli : " +araba.model);
        System.out.println(" ");

        System.out.println("arabanın yılı : " +araba.year);
        System.out.println(" ");

        araba.Yazdir();


    }
}




        System.out.println("Binamıza Hoş geldiniz Lütfen Bilgileri görmek için 1 e basınız");
        Scanner scanner = new Scanner(System.in);

        int res = scanner.nextInt();

        Bina sec = new Bina();

        sec.adres = "Istanbul";
        sec.binano = 38;
        sec.binaadi = "Beyza Apartmanı";


        if (res == 1) {
            System.out.println("adres " + sec.adres + " no " + sec.binano + " adı " + sec.binaadi);
        } else {
            sec.Write1();
        }

        System.out.println("");
        System.out.println("Lütfen Zilini çalmak istediğiniz ve Bilgileri görmek istediğiniz daireyi seçin");
        System.out.println("");


        System.out.println("1.Alihan Uslu");
        System.out.println("");

        System.out.println("2.Ragıp Aşkar");
        System.out.println("");

        System.out.println("3.Guşan Saygın");
        System.out.println("");

        System.out.println("4.MISTIK");
        System.out.println("");

        System.out.println("5.Ömer Aytemiz");
        System.out.println("");

        System.out.println("6.Gökberk Mahomes");
        System.out.println("");



        daireler daire = daireler.values()[scanner.nextInt()];

        switch (daire) {
            case daire1:
                Bina alihan = new Bina(5,"1.kat","asansörün sağ tarafı");
                System.out.println(" ");
                System.out.println(alihan.binano + alihan.binaadi + alihan.adres);
                alihan.Write();
                break;
            case daire2:
                Bina ragıp = new Bina(6,"1.kat","asansörün sol tarafı");
                System.out.println(" ");
                System.out.println(ragıp.binano + ragıp.binaadi + ragıp.adres);
                ragıp.Write();
                break;
            case daire3:
                Bina gusan = new Bina(7,"2.kat","asansörün sağ tarafı");
                System.out.println(" ");
                System.out.println(gusan.binano + gusan.binaadi + gusan.adres);
                gusan.Write();
                break;
            case daire4:
                Bina mustafa = new Bina(8,"2.kat","asansörün sol tarafı");
                System.out.println(" ");
                System.out.println(mustafa.binano + mustafa.binaadi + mustafa.adres);
                mustafa.Write();
                break;
            case daire5:
                Bina omer = new Bina(9,"3.kat","asansörün sağ tarafı");
                System.out.println(" ");
                System.out.println(omer.binano + omer.binaadi + omer.adres);
                omer.Write();
                break;
            case daire6:
                Bina gokberk = new Bina(10,"3.kat","asansörün sol tarafı");
                System.out.println(gokberk.binano  + " " + gokberk.binaadi + " "  + gokberk.adres);
                System.out.println(" ");
                gokberk.Write();
                break;

 */
        /*
        Scanner scanner = new Scanner(System.in);

        Headphones headphones = new Headphones();

        System.out.println("lütfen girmek istediğiniz markayı seçiniz");

        headphones.setbrand(scanner.next());

        System.out.println("lütfen girmek yılı seçiniz");

        headphones.setYear(scanner.nextInt());

        System.out.println(headphones.getbrand());

        headphones.setPrice(7999);

        System.out.println(headphones.getPrice());
        System.out.println(headphones.getYear());

        Scanner scanner = new Scanner(System.in);
        Watch watch = new Watch();

        System.out.println("mağzamıza hoş geldiniz lütfen seçmek istediğiniz saat markasını seçini");
        System.out.println("0 : Seiko");
        System.out.println("1 . Tissot");

       watchs saat =watchs.values()[scanner.nextInt()];

       switch (saat){
           case seiko:
               watch.setBrand("seiko");
               watch.setType("leather");
               watch.setPressure(5);
               watch.setPrice(12900);

               System.out.println("brand :" + watch.getBrand());
               System.out.println("strap type : "+ watch.getType());
               System.out.println("atm : " +watch.getPressure());
               System.out.println("Price : "+watch.getPrice());
               break;

           case tissot:
               watch.setBrand("tissot");
               watch.setType("titanium");
               watch.setPressure(10);
               watch.setPrice(13800);

               System.out.println("brand :" + watch.getBrand());
               System.out.println("strap type : "+ watch.getType());
               System.out.println("atm : " +watch.getPressure());
               System.out.println("Price : "+watch.getPrice());
               break;
           }



        Araba araba =new Araba();

        Araba.Year=1996;
        Araba.yazdir1();
        araba.yazdir();
        KiralikEv kiralikEv = new KiralikEv(3,4,"adana");
Ev ev = new Ev(3,6,"istanbul");

kiralikEv.yazdir();
ev.yazdir2();


Kentseldonusum kentseldonusum=new Kentseldonusum();

kentseldonusum.dairesayisi=9;

        System.out.println(kentseldonusum.getDairesayisi());

Kentseldonusum.yazdir();

kentseldonusum.yazdir2();

*/


        Kare kare = new Kare();
        GeometrikSekiller main = new Ucgen();

        kare.islemformulu();
        main.islemformulu();


        IDataAcsess shortcut = new MyOracleAcsess();
        IDataAcsess shortcuts = new MySQLAcsess();

        shortcuts.Okuma();

        shortcut.Guncelle();

        shortcut.Cıkarma();

        shortcuts.Ekleme();

        ArrayList<Integer> list = new ArrayList<Integer>();

        list.add(1);
        list.add(2);
        list.add(4);


        for (int i = 0; i < list.size(); i++) {

            System.out.println(list.get(i));
        }


        ArrayList<ListTest> listTests=new ArrayList<>();
listTests.add(new ListTest("alihan",2));

for (int i=0;i<listTests.size();i++){
    System.out.println(listTests.get(i).isim);
}

    }
    }



