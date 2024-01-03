import java.util.Scanner;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) {

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

*/

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