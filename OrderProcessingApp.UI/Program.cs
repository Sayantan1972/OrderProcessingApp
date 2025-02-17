using OrderProcessingApp.Business;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IProcessOrder, ProcessOrder>();


var app = builder.Build();

// Configure the HTTP request pipeline
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Order}/{action=Index}/{id?}"
);

app.Run();
