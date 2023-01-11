namespace banking;
public class Account{

    private double balance;

    public Account (double amount){
        this.balance=amount;
    }

    public double Balance{
        get{return this.balance;}
        set{this.balance=value;}
    }

    public void Withdraw(double amount){
        if(balance==0){
            throw new Exception("your amount is zero");
        }
        this.balance=balance-amount;
    }

    public void Deposite(double amount){
        this.balance=balance+amount;
        
    }
    ~Account()
    {

    }
}