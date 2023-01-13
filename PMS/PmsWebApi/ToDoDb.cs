//DATABASE SET OF TODO OBJECT....

using Microsoft.EntityFrameworkCore;
using PMS;


//Dbcontext used for disconnected function for database connectivity..
public class ToDoDb:DbContext{
     
     public ToDoDb(DbContextOptions<ToDoDb> options):base(options){}  

     //using lambda function set disconnectivity...   
     public DbSet<Todo> todos => Set<Todo>();
}