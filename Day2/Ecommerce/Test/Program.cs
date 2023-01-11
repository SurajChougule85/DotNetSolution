// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using MemberShip;
using HR;

// Tester for Ecommerce Solution...

Console.WriteLine("Enter your email");
string email=Console.ReadLine();

Console.WriteLine("Enter your passward");
string passward=Console.ReadLine();

if(AuthManager.validation(email,passward)){

    Console.WriteLine(" welcome to CDAC ");
    Employee emp=new SalesEmployee();
    emp.Work();
    Console.WriteLine(emp.ToString);
    double salary=emp.ComputeSalary();
    Console.WriteLine("Salary="+salary);
}
else{
    Console.WriteLine("Invalid User");
}