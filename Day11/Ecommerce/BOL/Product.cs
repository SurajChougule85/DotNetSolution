namespace BOL;
public class Product

{
    public int Id{get;set;}
    public string? Title{get;set;}
    public string? ImageUrl{get;set;}
    public string? Catagary{get;set;}
    public string? Description{get;set;}
    public string? PaymentTerm{get;set;}
    public string? Delivery{get;set;}
    public double UnitPrice{get;set;}
    public int Balance{get;set;}

    public Product(){
    }

    public Product(int productId, string title){
        this.Id = productId;
        this.Title = title;
    }

    public Product(int productId, string title, string category){
        this.Id = productId;
        this.Title = title;       
        this.Category = category;
    }
         public Product(int productId, string title, string brand,
                    string category, float unitPrice, int balance){
        this.Id = productId;
        this.Title = title;
        this.Category = category;
        this.UnitPrice = unitPrice;
        this.Balance = balance;
    }

    public Product(int productId, string title, string category,
                    float unitPrice, 
                    int balance, string description, string imageURL){
        this.Id = productId;
        this.Title = title;   
        this.Category = category;
        this.UnitPrice = unitPrice;
        this.Balance = balance;
        this.Description = description;
        this.ImageURL = imageURL;
    }
}
