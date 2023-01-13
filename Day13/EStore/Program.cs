using EStore;

var builder = WebApplication.CreateBuilder(args);

// Install the Microsoft.AspNetCore.Cors Nuget package.
     builder.Services.AddCors();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
});

app.UseAuthorization();

app.MapControllers();

app.MapGet("/emp",() => {

    List<Emp> employees=new List<Emp>();

        employees.Add(new Emp{ Id=12, FirstName="Kusum", LastName="Sarade"});
        employees.Add(new Emp{ Id=13, FirstName="Rohit", LastName="Patil"});
        employees.Add(new Emp{ Id=14, FirstName="Rajan", LastName="More"});
         return (employees);

});


app.Run();
