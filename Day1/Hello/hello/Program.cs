using banking;
using maths;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Account act1=new Account(100000);

Console.WriteLine("Balance= "+act1.Balance);
act1.Deposite(20000);
Console.WriteLine("banance after depositing of amount= "+ act1.Balance);

act1.Withdraw(50000);
Console.WriteLine("banance after withdraw of amount= "+ act1.Balance);

var p= new{
    FirstName="sagar",
    LastName="kale",
};

Console.WriteLine(p.FirstName+" "+p.LastName);

Complex c1=new Complex(24,12);
Complex c2 =new Complex(34,56);
Complex c3=c2 - c1;

Console.WriteLine(c1);
Console.WriteLine(c2);
Console.WriteLine(c3);