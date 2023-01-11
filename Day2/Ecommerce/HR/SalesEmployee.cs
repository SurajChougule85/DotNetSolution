namespace HR;
public class SalesEmployee:Employee{
    public double Target{get;set;}
    public double SalesDone{get;set;}
    public double Incetives{get;set;}

    public SalesEmployee():base(){
        this.Target=0;
        this.SalesDone=0;
        this.Incetives=0;
    }

    public SalesEmployee(int id, string firstName, string lastName, 
                    string email, string contactNumber, string location,
                    DateTime dob, float da, float hra, float bsal,
                    float target, float salesDone):base(id,firstName,lastName,email,contactNumber,location,dob,da,hra,bsal){
                        this.Target=target;
                        this.SalesDone=salesDone;
                        this.Incetives=0;
                    }

    public override void Work()
    {
        if(Target<=SalesDone){
            this.Incetives=10000;
        }
        this.Incetives=0;
    }

    public override double ComputeSalary()
    {
        double salary=base.ComputeSalary()+Incetives;
        return salary;
    }

    public override string ToString()
    {
        return base.ToString()+"Incetive= "+Incetives+"Target= "+Target;
    }
}