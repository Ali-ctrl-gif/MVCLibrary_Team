using MVCLibrary_Team.Data;
using MVCLibrary_Team.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IBaseDataModel, BaseDataModel>();
builder.Services.AddScoped<IRepository<Book>, BookRepository>();
builder.Services.AddScoped<IRepository<Member>, MemberRepository>();
builder.Services.AddScoped<IRepository<Borrow>, BorrowRepository>();
builder.Services.AddSingleton<IBaseDataModel, BaseDataModel>();
builder.Services.AddSingleton<IRepository<Borrow>, BorrowRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var baseData = services.GetRequiredService<IBaseDataModel>();
    SeedData.InitializeUser(baseData);
    SeedData.InitializeBook(baseData);
    SeedData.InitializeBorrow(baseData);
    SeedData.InitializeCategory(baseData);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
