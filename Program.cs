using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NovoProjetoCrianca.Data;
using NovoProjetoCrianca.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Contexto>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("conexao")));


// Configura��o do contexto de banco de dados
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Habilitar controle de erros de banco de dados durante o desenvolvimento
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Configura��o do Identity com suporte a User e Role
builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
    options.SignIn.RequireConfirmedAccount = true)  // Requer conta confirmada
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Adiciona suporte ao MVC (Controllers e Razor Pages)
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();  // Habilita Razor Pages

var app = builder.Build();

// Configura��o do pipeline de requisi��o HTTP
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();  // Permite servir arquivos est�ticos como CSS, JS, imagens etc.

app.UseRouting();

// Ativa a autentica��o e autoriza��o
app.UseAuthentication();  // Verifica a identidade do usu�rio
app.UseAuthorization();   // Verifica permiss�es do usu�rio

// Define o roteamento do MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Mapeia as Razor Pages para o pipeline
app.MapRazorPages();

app.Run();
