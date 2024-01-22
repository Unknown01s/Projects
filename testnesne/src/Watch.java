public class Watch {

    public String Brand;
    public String Type;
    public int Pressure;
    private int price;

    public void setBrand(String Brand) {
        this.Brand = Brand;
    }

    public String getBrand() {

        return Brand;
    }

    public String getType() {
        return Type;
    }

    public void setType(String Type) {
        this.Type = Type;
    }
public void setPressure(int Pressure){
        this.Pressure=Pressure;
}
    public int getPressure(){
        return Pressure;
    }

    public void setPrice(int price){
        this.price=price;
    }

    public int getPrice(){
        return price;
    }
    public Watch(){

    }


    //public Watch (String Type,int Pressure,String Brand,int price){

        //this.price=price;
       // this=price
    //}
}
