using System.ComponentModel.DataAnnotations;
namespace Catalog;

public class Product{

 [Required]
  public int Id{get;set;}
  public string? Title{get;set;}
  public string? Description{get;set;}
  public double UnitPrice{get;set;}

  public Product(){
    this.Id=101;
    this.Title="Neem";
    this.Description="Cure Insomnia";
    this.UnitPrice=5000;
  }
  

  public Product( int id,string title,string description,double price){
    this.Id=id;
    this.Title=title;
    this.Description=description;
    this.UnitPrice=price;

  }

}


