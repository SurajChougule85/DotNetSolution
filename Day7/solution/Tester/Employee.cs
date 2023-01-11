namespace CDACcollection;


//POCO CLASS ===Plain Old CLR Object
public class Employee{
    public int id;
    public string? name;
    public double salary;

    public Employee(int id,string name,double salary){
        this.id=id;
        this.name=name;
        this.salary=salary;
        
    }

}