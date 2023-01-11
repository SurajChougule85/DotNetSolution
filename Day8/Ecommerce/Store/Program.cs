
//web application is started here..
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
 //app aplication is checking for middleWare...
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();//checking up for Routing..

app.UseAuthorization();//checking for Authorization..

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//setting for controller Mapping..
//when run is started its waiting for request..
app.Run();
