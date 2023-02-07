using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using webOnlyFeiras.Areas.Identity;
using webOnlyFeiras.Data;
using Radzen;
using MudBlazor.Services;
using webOnlyFeiras.Model;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddIdentity<Utilizador, IdentityRole>(options => {
    options.SignIn.RequireConfirmedEmail = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireDigit = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddScoped<NotificationService>();

var app = builder.Build();
/*
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

    var _roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    var _userManager = scope.ServiceProvider.GetRequiredService<UserManager<Utilizador>>();

    // adicionando um admin
    var Password = "$404Admin";

    var novoAdmin = new Utilizador() { UserName = "admin", Nome = "Jorge Fernando", Email = "jorgefernando@onlyfeiras.pt", DataNascimento = DateTime.Now };

    var result = await _userManager.CreateAsync(novoAdmin, Password);
    var userRole = new IdentityRole("Admin");
    var addRoleResult = await _roleManager.CreateAsync(userRole);
    var addUserRoleResult = await _userManager.AddToRoleAsync(novoAdmin, "Admin");

    if (result.Succeeded && addUserRoleResult.Succeeded)
    {
        Console.WriteLine("Administrador criado");
    }
    else
    {
        Console.WriteLine("Erro a criar administrador");

    }
}
*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
