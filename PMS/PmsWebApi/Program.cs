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

//get welcome message and do writing...
app.MapGet("/",() =>"Welcome To Store");

app.MapGet("/items",async(ToDoDb db)=>
await db.todos.ToListAsync()
);

//get all items which are completed in status..
app.MapGet("/items/complete",async(ToDoDb db) =>
await db.todos.Where(t => t.IsComplete).ToListAsync());

//get item whose id matching
app.MapGet("/items{id}",async( int id,ToDoDb db)=>
await db.todos.FindAsync(id)
is Todo todo ? Results.Ok(todo) :Results.NotFound()
);


//insert new item
app.MapPost("/todoitems", async (Todo todo, ToDoDb db) =>
{
    db.todos.Add(todo);
    await db.SaveChangesAsync();

    return Results.Created($"/todoitems/{todo.Id}", todo);
});

//update existing item
app.MapPut("/todoitems/{id}", async (int id, Todo inputTodo, ToDoDb db) =>
{
    var todo = await db.todos.FindAsync(id);

    if (todo is null) return Results.NotFound();

    todo.Name = inputTodo.Name;
    todo.IsComplete = inputTodo.IsComplete;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/todoitems/{id}", async (int id, ToDoDb db) =>
{
    if (await db.todos.FindAsync(id) is Todo todo)
    {
        db.todos.Remove(todo);
        await db.SaveChangesAsync();
        return Results.Ok(todo);
    }
    return Results.NotFound();
});



app.Run();

app.Run();
