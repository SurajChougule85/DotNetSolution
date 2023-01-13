//Step 1:

//Install Dependecies for ORM using Entity Framework in asp.net core app...

//dotnet add package Microsoft.EntityFrameworkCore.InMemory
//dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore

//Step 2:
//Define POCO class 


//Step 3:
//Define DataContext for TodoItems

//Step 4:
//import Entity Frameowork namespace

using Microsoft.EntityFrameworkCore;
using PMS;

var builder = WebApplication.CreateBuilder(args);

//Step 5:
//Add In memory EntityFramework sercvices...u can add in MySql/mangodb etc...
builder.Services.AddDbContext<ToDoDb>(opt =>opt.UseInMemoryDatabase("TodoList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Middlewares...
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

//get welcome message
app.MapGet("/",() =>"Welcome To Store");

app.Run();
