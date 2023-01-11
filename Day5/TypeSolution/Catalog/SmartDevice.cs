namespace Catalog;

public class SmartDevice:Product{

    public int Count{get;set;}
    public String? Specification{get;set;}

    public SmartDevice():base(){

    }

     public void Connect(){
        Console.WriteLine("connecting to a device");

     }

     public void Disconnect(){
        Console.WriteLine("Disconnecting to a server");
     }
    ~SmartDevice(){

    }

    
}