using HR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! ");


var employee=new Employee(){Id=201,FirstName="karan",LastName="kumar",Email="karan@123"};


List<Employee> emp=new List<Employee>();

emp.Add(new Employee{Id=101,FirstName="Rohan",LastName="Sane",Email="rohan@123"});
emp.Add(new Employee{Id=106,FirstName="Mangal",LastName="Patil",Email="mangal@333"});
emp.Add(new Employee{Id=103,FirstName="Sudha",LastName="Salgar",Email="sudha@3539"});
emp.Add(new Employee{Id=110,FirstName="Rahul",LastName="Lavate",Email="rahul@94"});

app.MapGet("/emp",()=>emp);
app.MapGet("/api/employee",()=>employee);


app.Run();