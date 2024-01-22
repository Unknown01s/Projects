public class Headphones
{

    private String brand;
    public  String Model;
    public int Year;
    private int price;




    public void setbrand(String brand ){

        this.brand=brand;

    }
    public void setModel(String Model){
        this.Model=Model;
    }

    public void setYear(int Year){
        this.Year=Year;
    }

    public void setPrice(int price){

       this.price=price;

    }


    public String getbrand(){
        return brand;
}

    public String getModel(){
        return Model;
    }

    public int getYear(){
        return Year;
    }

    public int getPrice(){
        return price;
    }

}
