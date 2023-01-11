namespace HR;
public abstract class Employee

{
    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public String Email{get;set;}
    public string ContactNumber{get;set;}
    public string Location{get;set;}
    public DateTime Dob{get;set;}
    public double DA{get;set;}
    public double HRA{get;set;}
    public double BasicSalary{get;set;}

    public abstract void Work();

    public virtual double ComputeSalary(){
        double payment=(DA *27)+BasicSalary+HRA;
        return payment;
    }

    public override string ToString()
    {
        return base.ToString();
    }
//Employee.Employee(int, string, string, string,
// string, string, DateTime, float, float, float)
    public Employee(int id,string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime dob, float da, float hra, float bsal){
                        this.Id=id;
                        this.FirstName=firstName;
                        this.LastName=lastName;
                        this.Email=email;
                        this.ContactNumber=contactNumber;
                        this.Location=location; 
                        this.Dob=dob;
                        this.HRA=hra;
                        this.DA=da;
                        this.BasicSalary=bsal;

                    }
 //constructor chaining ....

 public Employee():this(101,"suraj","chougule","suraj@123","2367239239","pune",new DateTime(2022,12,30),500,5000,50000){

 }

}
